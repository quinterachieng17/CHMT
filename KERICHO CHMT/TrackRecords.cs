using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace KERICHO_CHMT
{
    public partial class TrackRecords : Form

    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public TrackRecords()
        {
            InitializeComponent();
        }

        public TrackRecords(string username)
        {
            InitializeComponent();
            label3.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor(label3.Text);
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           TrackRecords ss = new TrackRecords(label3.Text);
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor(label3.Text);
            ss.Show();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register(label3.Text);
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver ss = new Driver(label3.Text);
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleRegistration ss = new VehicleRegistration(label3.Text);
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ss = new EditVehicle(label3.Text);
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails(label3.Text);
            ss.Show();
        }

        private void TrackRecords_Load(object sender, EventArgs e)
        {
           PopulateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHead_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void PopulateDataGridView()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM RecordMileage", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void dgv1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv1.CurrentRow != null)  //selects current row in focus
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgv1.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("MileageAddOrEdit", sqlCon); //Avoids sql inections
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtUserID"].Value == DBNull.Value)
                    { //Insert operation
                        sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    }
                    else
                    //update operation
                    {
                        sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgvRow.Cells["txtUserID"].Value));
                        sqlCmd.Parameters.AddWithValue("@DriverID", Convert.ToInt32(dgvRow.Cells["txtDriverID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverID"].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@MileageReading", dgvRow.Cells["txtMileageReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMileageReading"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@OilDrawn", dgvRow.Cells["txtOilDrawn"].Value == DBNull.Value ? "" : dgvRow.Cells["txtOilDrawn"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgvRow.Cells["txtFuelDrawn"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFuelDrawn"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Destination", dgvRow.Cells["txtDestination"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDestination"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();

                    }
                }
            }
        }

        private void dgv1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgv1.CurrentRow.Cells["txtUserID"].Value != DBNull.Value)

            //Deletes only if the user confirms by pressing "Yes"
            {
                if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("MileageDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgv1.CurrentRow.Cells["txtUserID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                //  Blocks the default delete operation
                else
                    e.Cancel = true;
            }

            else
                e.Cancel = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTicketSummary ss = new WorkTicketSummary();
            ss.Show();
        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dgv1,string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable records = new PdfPTable(dgv1.Columns.Count);
            records.DefaultCell.Padding = 3;
            records.WidthPercentage = 100;
            records.HorizontalAlignment = Element.ALIGN_LEFT;
            records.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                //For header
            foreach (DataGridViewColumn column in dgv1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                records.AddCell(cell);

            }
            //Add datarow
            foreach(DataGridViewRow row in dgv1.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    records.AddCell(new Phrase(cell.Value.ToString(), text));

                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(records);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dgv1, "KTIMS Records");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
