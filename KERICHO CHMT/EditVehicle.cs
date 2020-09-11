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

        public EditVehicle(string username)
        {
            InitializeComponent();
            label4.Text = username;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor(label4.Text);
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor(label4.Text);
            ss.Show();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register(label4.Text);
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           Driver ss = new Driver(label4.Text);
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleRegistration ss = new VehicleRegistration(label4.Text);
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ss = new EditVehicle(label4.Text);
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails(label4.Text);
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords(label4.Text);
            ss.Show();
        }
        private void button12_Click(object sender, EventArgs e)
        {

            this.Hide();
            Nurse nn = new Nurse(label4.Text);
            nn.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTicketSummary ss = new WorkTicketSummary(label4.Text);
            ss.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateVehicleDetails ss = new UpdateVehicleDetails(label4.Text);
            ss.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditVehicle_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
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
            ////Report Header
            BaseFont head = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            Paragraph p = new Paragraph();
            p.Alignment = Element.ALIGN_CENTER;
            p.Add(new Chunk("KERICHO COUNTY REFERRAL HOSPITAL"));
            p.Add(new Chunk("\nP.O BOX 11 -20200 KERICHO"));
            p.Add(new Chunk("\nDate: " + DateTime.Now.ToShortDateString()));

            //Line Separation
            Paragraph pra = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 2)));
            p.Add(new Chunk("\n"));
            p.Add(new Chunk("\n"));
            p.Add(new Chunk("\n"));

            //Table Head
            Paragraph p2 = new Paragraph();
            p2.Alignment = Element.ALIGN_CENTER;
            p2.Add(new Chunk("Motor Vehicle Details at Kericho County Referral Hospital"));

            //Table Data
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable records = new PdfPTable(dgvVehicle.Columns.Count);
            records.DefaultCell.Padding = 1;
            records.WidthPercentage = 100;
            PdfPCell cells = new PdfPCell();
            records.HorizontalAlignment = Element.ALIGN_LEFT;
            records.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //For header
            foreach (DataGridViewColumn column in dgvVehicle.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                records.AddCell(cell);

            }
            //Add datarow
            foreach (DataGridViewRow row in dgvVehicle.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
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
                    pdfdoc.Add(p);
                    pdfdoc.Add(pra);
                    pdfdoc.Add(p2);
                    pdfdoc.Add(new Chunk("\n"));
                    pdfdoc.Add(records);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dgvVehicle, "KTIMS Motor Vehicle Details");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM VehicleRegistration", sqlCon);
                DataSet ds = new DataSet();
                sqlDa.Fill(ds, "VehicleRegistration");
                dgvVehicle.DataSource = ds.Tables["VehicleRegistration"];
                sqlCon.Close();
            }
        }
    }
}
