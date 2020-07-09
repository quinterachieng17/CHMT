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
    public partial class StaffDetails : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public StaffDetails()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails();
            ss.Show();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver ss = new Driver();
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleRegistration ss = new VehicleRegistration();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ss = new EditVehicle();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords();
            ss.Show();
        }
        void PopulateDesignationComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Designation", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                //Binding combobox values to the datagridview combo

                cbxDesignation.ValueMember = "DesignationID";
                cbxDesignation.DisplayMember = "Designation";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                cbxDesignation.DataSource = dtbl;
            }
        }

        void PopulateRegionComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Region", sqlCon);
                DataTable dtbl2 = new DataTable();
                sqlDa.Fill(dtbl2);
                cbxRegion.ValueMember = "RegionID";
                cbxRegion.DisplayMember = "Region";
                DataRow topItem = dtbl2.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl2.Rows.InsertAt(topItem, 0);
                cbxRegion.DataSource = dtbl2;
            }
        }


        //Displays on DataGridView for view satff
        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))

            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StaffRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtbl;

            }
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'cmbloginDataSet.RegisterStaff' table. You can move, or remove it, as needed.
            //this.registerStaffTableAdapter.Fill(this.cmbloginDataSet.RegisterStaff);
            PopulateDesignationComboBox();
            PopulateRegionComboBox();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Officers ss = new Officers();
            //ss.Show();

        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dataGridView1, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftableStaff = new PdfPTable(dataGridView1.Columns.Count);
            pdftableStaff.DefaultCell.Padding = 3;
            pdftableStaff.WidthPercentage = 100;
            pdftableStaff.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftableStaff.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //For header
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftableStaff.AddCell(cell);

            }
            //Add datarow
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftableStaff.AddCell(new Phrase(cell.Value?.ToString(), text));

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
                    pdfdoc.Add(pdftableStaff);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dataGridView1, "KTIMS Staff Detail");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateStaffDetails ss = new UpdateStaffDetails();
            ss.Show();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

             if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
            {
             object value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                e.ThrowException = false;

             }
        }
    }
}
       
    
