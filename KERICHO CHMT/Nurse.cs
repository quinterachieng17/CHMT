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
    public partial class Nurse : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public Nurse()
        {
            InitializeComponent();

        }       
        public Nurse(string cmb)
        {
            InitializeComponent();
            label3.Text =cmb;          
        }

        //public Nurse(string username)
        //{
        //    InitializeComponent();
        //    label3.Text = username;
        //}


        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Patient_Register.Show("Patient Name","PATIENT REGISTRATION", "OK", "Cancel");
        }

        private void btnReferralCases_Click(object sender, EventArgs e)
        {
            
            SpecificSearch.Show("Select Case to View", "PATIENT SEARCH", "OK", "Cancel");
            
            //Referrals.Show("Enter Patient Number", "Search Patient Details", "OK", "Cancel");
        }

        private void Nurse_Load(object sender, EventArgs e)
        {
            if (label3.Text == "Nurse")
            {
                pictureBoxBack.Hide();
            }


            //Loading to the dataGridView                    
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PatientRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvPatientDetails.AutoGenerateColumns = false;
                dgvPatientDetails.DataSource = dtbl;
            }
                //Loading the charts
            chartReferrals.Series["chartReferrals"].Points.AddXY("TopHill",1000 );
            chartReferrals.Series["chartReferrals"].Points.AddXY("MediHill", 1200);
            chartReferrals.Series["chartReferrals"].Points.AddXY("Real", 3000);
            chartReferrals.Series["chartReferrals"].Points.AddXY("Tenwek", 11000);
            chartReferrals.Series["chartReferrals"].Points.AddXY("Nairobi Hospital", 11000);
            //
            chartTransfers.Series["ChartTransfers"].Points.AddXY("Moi Referral Hospital", 1000);
            chartTransfers.Series["ChartTransfers"].Points.AddXY("Kenyatta Hospital", 1200);
            chartTransfers.Series["ChartTransfers"].Points.AddXY("Kericho CHMT", 3000);
            chartTransfers.Series["ChartTransfers"].Points.AddXY("Sigowet TTC", 11000);
            //

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rr = new Reports();
            rr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PatientRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvPatientDetails.AutoGenerateColumns = false;
                dgvPatientDetails.DataSource = dtbl;

            }

            label2.Text = "Incomming Referral Cases";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM ReferralRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvPatientDetails.AutoGenerateColumns = false;
                dgvPatientDetails.DataSource = dtbl;

            }
            label2.Text = "Outgoing Referral cases";
        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dgvPatientDetails, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
           
            PdfPTable referrals = new PdfPTable(dgvPatientDetails.Columns.Count);
            referrals.DefaultCell.Padding = 3;
            referrals.WidthPercentage = 100;
            referrals.HorizontalAlignment = Element.ALIGN_LEFT;
            referrals.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
           
            //For cell header
            foreach (DataGridViewColumn column in dgvPatientDetails.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(230, 238, 255);
                referrals.AddCell(cell);
            }

            //Add datarow
            foreach (DataGridViewRow row in dgvPatientDetails.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    referrals.AddCell(new Phrase(cell.Value?.ToString(), text));

                }
            }

            //For save Dialog
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
                    pdfdoc.Add(referrals);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dgvPatientDetails, "Referral Case for ");
        }

       
        private void dgvPatientDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
            Msg1.Show("View All Cases", "", "OK", "Cancel");           
        }

        private void dgvPatientDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chartTransfers_Click(object sender, EventArgs e)
        {

        }

        private void chartReferrals_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
                this.Hide();
                Doctor ss = new Doctor(label3.Text);
                ss.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
