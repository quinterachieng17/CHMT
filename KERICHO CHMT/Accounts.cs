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
    public partial class Accounts : Form
    {
        String connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True;";
        public Accounts()
        {
            InitializeComponent();
        }

        public Accounts(string username)
        {
            InitializeComponent();
            label7.Text = username;
        }

        //dtbl is used as global variable
        DataTable dtbl;

        private void Accounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet46.StatementOfAccounts' table. You can move, or remove it, as needed.
            this.statementOfAccountsTableAdapter.Fill(this.cmbloginDataSet46.StatementOfAccounts);

            // TODO: This line of code loads data into the 'cmbloginDataSet45.VehicleRegistration' table. You can move, or remove it, as needed.
            this.vehicleRegistrationTableAdapter.Fill(this.cmbloginDataSet45.VehicleRegistration);
            //Custom date formats
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            label7.Hide();
           
        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            //Filtering data using RegNo
            //DataView DV = new DataView(dtbl);
            //DV.RowFilter = string.Format("VehicleNo LIKE '%{0}'", txtRegNo.Text);
            //dgvAccounts.DataSource = DV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor doc = new Doctor(label7.Text);
            doc.Show();
        }

        void PopulateDataGridView()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StatementOfAccounts", sqlCon);                
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);               
                dgvAccounts.DataSource = dtbl;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (cmbStation.Text == "" || cmbVehicleNo.Text == "" || txtLpoNo.Text == "" || txtMaintenance.Text == "" || txtFuelDrawn.Text=="" || txtOilDrawn.Text=="" )
                MessageBox.Show("Payment Details or Expenditures cannot be blank");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AccountsAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@VehicleID", 0);
                    sqlCmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Station", cmbStation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LpoNo", txtLpoNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Payments",txtPayments.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Maintenance", txtMaintenance.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Others", txtOthers.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Expenses", txtTotalExpenses.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Balance", txtBalance.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Recorded succsessful");
                    PopulateDataGridView();
                    Clear();
                }

            }
        }
        void Clear()
        {
            cmbVehicleNo.Text = cmbStation.Text = txtLpoNo.Text = txtPayments.Text = txtOilDrawn.Text = txtFuelDrawn.Text = txtMaintenance.Text = txtOthers.Text = txtTotalExpenses.Text = txtBalance.Text= "";
        }

        private void dgvAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a1, b1, c1, d1, s;
            double.TryParse(txtMaintenance.Text, out a1);
            double.TryParse(txtOilDrawn.Text, out b1);
            double.TryParse(txtFuelDrawn.Text, out c1);
            double.TryParse(txtOthers.Text, out d1);
            s = a1 + b1 + c1 + d1;
            if (s > 0)
                txtTotalExpenses.Text = s.ToString("c").Remove(0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StatementOfAccounts where date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);                           
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);               
                dgvAccounts.DataSource = dtbl;

                // Displays only the selected columns
                dgvAccounts.AutoGenerateColumns = false;
                dgvAccounts.DataSource = dtbl;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double e1, f1, g;
            double.TryParse(txtPayments.Text, out e1);
            double.TryParse(txtTotalExpenses.Text, out f1);
            g = e1 - f1;
            if (g > 0)
                txtBalance.Text = g.ToString("c").Remove(0, 1);

        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dgvAccounts, string filename)
        {
            ////Report Header
            BaseFont head = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            Paragraph p = new Paragraph();
            p.Alignment = Element.ALIGN_CENTER;
            p.Add(new Chunk("KERICHO COUNTY REFERRAL HOSPITAL"));
            p.Add(new Chunk("\nP.O BOX 11 -20200 KERICHO"));
            p.Add(new Chunk("\nDate: " + DateTime.Now.ToShortDateString()));

            //Line Separation
            Paragraph pra = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT,1)));            
            p.Add(new Chunk("\n"));

            //Table Head
            Paragraph p2 = new Paragraph();
            p2.Alignment = Element.ALIGN_CENTER;
            p2.Add(new Chunk("Statement of Accounts"));

            //Table Data
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable records = new PdfPTable(dgvAccounts.Columns.Count);
            records.DefaultCell.Padding = 1;
            records.WidthPercentage = 100;
            PdfPCell cells = new PdfPCell();
            records.HorizontalAlignment = Element.ALIGN_LEFT;
            records.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //For header
            foreach (DataGridViewColumn column in dgvAccounts.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                records.AddCell(cell);

            }
            //Add datarow
            foreach (DataGridViewRow row in dgvAccounts.Rows)
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

        private void button3_Click(object sender, EventArgs e)
        {          
            exportgridviewtopdf(dgvAccounts, "Statement of Accounts - Transport Office");
        }
        
    }
}
