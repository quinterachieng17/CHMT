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
        //k2-expenses
        //k3-Payments
        //s1-deducting payment balance
        double k1, k2, k3, s1;


        private void Accounts_Load(object sender, EventArgs e)
        {
            
            dgvAccounts2.Hide();
            dgvAccounts3.Hide();
            txtTotalExpenses.Hide();
            txtBalance.Hide();
 
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

        //Populate dgvAccounts2
        void PopulateDataGridView2()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StatementOfAccounts2", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvAccounts2.DataSource = dtbl;
            }
        }

        //Populate dgvAccounts3
        void PopulateDataGridView3()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StatementOfAccounts3", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvAccounts3.DataSource = dtbl;
            }
        }

        //Save Button
        private void button5_Click(object sender, EventArgs e)
        {
            if(cmbStation.SelectedIndex == 0)
            {

                if (cmbStation.Text == "" || cmbVehicleNo.Text == "" || txtLpoNo.Text == "")
                    MessageBox.Show("Station and Vehicle Details cannot be blank");

                else if (txtMaintenance.Text == "" || txtFuelDrawn.Text == "" || txtOilDrawn.Text == "" || txtOthers.Text == "")
                {
                    txtMaintenance.Text = "00";
                    txtFuelDrawn.Text = "00";
                    txtOilDrawn.Text = "00";
                    txtOthers.Text = "00";
                }
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
                        sqlCmd.Parameters.AddWithValue("@Payments", txtPayments.Text.Trim());
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

                // computing balance as s1 (Payments-Total expences)
                //double k2, k3, s1;
                //double.TryParse(txtTotalExpenses.Text, out k2);
                //double.TryParse(txtPayments.Text, out k3);
                //s1 = k3 - k2;
                //if (s1 > 0)
                //    dgvAccounts[10, dgvAccounts.Rows.Count - 1].Value = s1.ToString("c").Remove(0, 1);


                //dgvAccounts.Rows[dgvAccounts.Rows.Count - 1].Cells[4].Style.BackColor = Color.White;
                //dgvAccounts.Rows[dgvAccounts.Rows.Count - 1].Cells[4].Style.BackColor = Color.Red;


                //Total of payments
                //    dgvAccounts[3, dgvAccounts.Rows.Count - 1].Value = "TOTAL";
                //    dgvAccounts.Rows[dgvAccounts.Rows.Count - 1].Cells[4].Style.BackColor = Color.White;
                //    dgvAccounts.Rows[dgvAccounts.Rows.Count - 1].Cells[4].Style.ForeColor = Color.Red;





                //    decimal total = 0;
                //    for (int i = 0; i < dgvAccounts.RowCount - 1; i++)
                //    {
                //        var value = dgvAccounts.Rows[i].Cells[8].Value;
                //        if (value != DBNull.Value)
                //        {
                //            total += Convert.ToDecimal(value);
                //        }
                //    }
                //    if (total == 0)
                //    {
                //        MessageBox.Show("Your payment Balance is zero");
                //    }

                //    dgvAccounts.Rows[dgvAccounts.Rows.Count - 1].Cells[4].Value = total.ToString();

                //double a1, b1, c1, d1, s;
                //double.TryParse(txtMaintenance.Text, out a1);
                //double.TryParse(txtOilDrawn.Text, out b1);
                //double.TryParse(txtFuelDrawn.Text, out c1);
                //double.TryParse(txtOthers.Text, out d1);
                //s = a1 + b1 + c1 + d1;
                //if (s > 0)
                //    txtTotalExpenses.Text = s.ToString("c").Remove(0, 1);
            }

            if(cmbStation.SelectedIndex == 1)
            {
                {

                    if (cmbStation.Text == "" || cmbVehicleNo.Text == "" || txtLpoNo.Text == "")
                        MessageBox.Show("Station and Vehicle Details cannot be blank");

                    else if (txtMaintenance.Text == "" || txtFuelDrawn.Text == "" || txtOilDrawn.Text == "" || txtOthers.Text == "")
                    {
                        txtMaintenance.Text = "00";
                        txtFuelDrawn.Text = "00";
                        txtOilDrawn.Text = "00";
                        txtOthers.Text = "00";
                    }
                    else
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("AccountsAdd2", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@VehicleID", 0);
                            sqlCmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Station", cmbStation.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@LpoNo", txtLpoNo.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Payments", txtPayments.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker3.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Maintenance", txtMaintenance.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Others", txtOthers.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Expenses", txtTotalExpenses.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Balance", txtBalance.Text.Trim());
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Recorded succsessful");
                            PopulateDataGridView2();
                            Clear();
                        }

                    }                  
                }
            }

            if(cmbStation.SelectedIndex == 2)
            {
                {

                    if (cmbStation.Text == "" || cmbVehicleNo.Text == "" || txtLpoNo.Text == "")
                        MessageBox.Show("Station and Vehicle Details cannot be blank");

                    else if (txtMaintenance.Text == "" || txtFuelDrawn.Text == "" || txtOilDrawn.Text == "" || txtOthers.Text == "")
                    {
                        txtMaintenance.Text = "00";
                        txtFuelDrawn.Text = "00";
                        txtOilDrawn.Text = "00";
                        txtOthers.Text = "00";
                    }
                    else
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("AccountsAdd3", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@VehicleID", 0);
                            sqlCmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Station", cmbStation.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@LpoNo", txtLpoNo.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Payments", txtPayments.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker3.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Maintenance", txtMaintenance.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Others", txtOthers.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Expenses", txtTotalExpenses.Text.Trim());
                            sqlCmd.Parameters.AddWithValue("@Balance", txtBalance.Text.Trim());
                            sqlCmd.ExecuteNonQuery();
                            MessageBox.Show("Recorded succsessful");
                            PopulateDataGridView3();
                            Clear();
                        }

                    }

                    
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

        //Total Expenses
        private void button7_Click(object sender, EventArgs e)
        {
            txtTotalExpenses.Show();
            button7.Text = "Total Expenses";         
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
                if(cmbStation.SelectedIndex == 0)
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

                if(cmbStation.SelectedIndex == 1)
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StatementOfAccounts2 where date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvAccounts2.DataSource = dtbl;

                    // Displays only the selected columns
                    dgvAccounts2.AutoGenerateColumns = false;
                    dgvAccounts2.DataSource = dtbl;
                }

                if(cmbStation.SelectedIndex == 2)
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StatementOfAccounts3 where date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgvAccounts3.DataSource = dtbl;

                    // Displays only the selected columns
                    dgvAccounts3.AutoGenerateColumns = false;
                    dgvAccounts3.DataSource = dtbl;
                }
                
            }
        }

        //Balance
        private void button8_Click(object sender, EventArgs e)
        {
            
            if (cmbStation.SelectedIndex == 0)
            {
                dgvAccounts.Rows[dgvAccounts.Rows.Count - 1].Cells[11].Style.ForeColor = Color.White;
                dgvAccounts.Rows[dgvAccounts.Rows.Count - 1].Cells[11].Style.BackColor = Color.Red;
                txtBalance.Show();
                button8.Text = "Balance";
                if (txtPayments.Text == "")
                {
                    txtPayments.Text = dgvAccounts[11, dgvAccounts.Rows.Count - 1].Value.ToString();
                }
                double e1, f1, g;
                double.TryParse(txtPayments.Text, out e1);
                double.TryParse(txtTotalExpenses.Text, out f1);
                g = e1 - f1;
                if (g > 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1);
                }
                else if (g == 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1); 
                }
                else if (g < 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1); 
                    MessageBox.Show("Please top up your balance");
                }
            }

            if(cmbStation.SelectedIndex == 1)
            {
                txtBalance.Show();
                button8.Text = "Balance";
                if (txtPayments.Text == "")
                {
                    txtPayments.Text = dgvAccounts2[11, dgvAccounts2.Rows.Count - 1].Value.ToString();
                }
                double e1, f1, g;
                double.TryParse(txtPayments.Text, out e1);
                double.TryParse(txtTotalExpenses.Text, out f1);
                g = e1 - f1;
                if (g > 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1);
                }
                else if (g == 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1); ;
                }
                else if (g < 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1); ;
                    MessageBox.Show("Please top up your balance");
                }
            }

            if(cmbStation.SelectedIndex == 2)
            {
                txtBalance.Show();
                button8.Text = "Balance";
                if (txtPayments.Text == "")
                {
                    txtPayments.Text = dgvAccounts3[11, dgvAccounts3.Rows.Count - 1].Value.ToString();
                }
                double e1, f1, g;
                double.TryParse(txtPayments.Text, out e1);
                double.TryParse(txtTotalExpenses.Text, out f1);
                g = e1 - f1;
                if (g > 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1);
                }
                else if (g == 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1); ;
                }
                else if (g < 0)
                {
                    txtBalance.Text = g.ToString("c").Remove(0, 1); ;
                    MessageBox.Show("Please top up your balance");
                }
            }

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalExpenses_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //For Kipsigis
            if(cmbStation.SelectedIndex == 0)
            {
                dgvAccounts.Show();
                dgvAccounts2.Hide();
                dgvAccounts3.Hide();
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

            //For Jumbo
            if (cmbStation.SelectedIndex == 1)
            {
                dgvAccounts.Hide();
                dgvAccounts2.Show();
                dgvAccounts3.Hide();
                
                // TODO: This line of code loads data into the 'cmbloginDataSet47.StatementOfAccounts2' table. You can move, or remove it, as needed.
                this.statementOfAccounts2TableAdapter.Fill(this.cmbloginDataSet47.StatementOfAccounts2);

                //Custom date formats
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd-MM-yyyy";
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "dd-MM-yyyy";
                dateTimePicker3.Format = DateTimePickerFormat.Custom;
                dateTimePicker3.CustomFormat = "dd-MM-yyyy";
                label7.Hide();
            }

            //For Omline
            if (cmbStation.SelectedIndex == 2)
            {
                dgvAccounts3.Show();
                dgvAccounts2.Hide();
                dgvAccounts.Hide();
                // TODO: This line of code loads data into the 'cmbloginDataSet48.StatementOfAccounts3' table. You can move, or remove it, as needed.
                this.statementOfAccounts3TableAdapter.Fill(this.cmbloginDataSet48.StatementOfAccounts3);

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
        }

        private void dgvStation2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void dgvAccounts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = 1;
            foreach(DataGridViewRow row in dgvAccounts.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }
    }
}
