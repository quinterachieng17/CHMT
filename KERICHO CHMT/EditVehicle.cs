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
    public partial class EditVehicle : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public EditVehicle()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
            Doctor ss = new Doctor();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditVehicle_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM VehicleRegistration", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvVehicle.AutoGenerateColumns = false;
                dgvVehicle.DataSource = dtbl;


            }
        }

        private void dgvVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dgvVehicle, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgvVehicle.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //For header
            foreach (DataGridViewColumn column in dgvVehicle.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);

            }
            //Add datarow
            foreach (DataGridViewRow row in dgvVehicle.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));

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
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dgvVehicle, "KTIMS Motor Vehicle Details");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateVehicleDetails ss = new UpdateVehicleDetails();
            ss.Show();
        }
    }
}
