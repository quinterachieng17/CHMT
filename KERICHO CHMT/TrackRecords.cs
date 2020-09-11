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
            //using (SqlConnection sqlCon = new SqlConnection(connectionString))
            //{
            //    foreach (DataGridViewRow row in dgv1.Rows)
            //    {
            //        for (int i = 0; i < dgv1.Rows.Count; i++)                        
            //            {                           
            //                sqlCon.Open();
            //                SqlCommand sqlCmd = new SqlCommand("MileageAdd", sqlCon);
            //                sqlCmd.CommandType = CommandType.StoredProcedure;
            //                sqlCmd.Parameters.AddWithValue("@UserID", 0);
            //                sqlCmd.Parameters.AddWithValue("@DriverID", dgv1.Rows[i].Cells["txtDriverID"].Value);
            //                sqlCmd.Parameters.AddWithValue("@RegNo", dgv1.Rows[i].Cells["txtRegNo"].Value);
            //                sqlCmd.Parameters.AddWithValue("@MileageReading", dgv1.Rows[i].Cells["txtMileageReading"].Value);
            //                sqlCmd.Parameters.AddWithValue("@OilDrawn", dgv1.Rows[i].Cells["txtOilDrawn"].Value);
            //                sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgv1.Rows[i].Cells["txtFuelDrawn"].Value);
            //                sqlCmd.Parameters.AddWithValue("@Destination", dgv1.Rows[i].Cells["txtDestination"].Value);
            //                sqlCmd.Parameters.AddWithValue("@lpgStation", dgv1.Rows[i].Cells["txtlpgStation"].Value);
            //                sqlCmd.Parameters.AddWithValue("@Date", dgv1.Rows[i].Cells["txtDate"].Value);                            
            //                sqlCmd.Parameters.AddWithValue("@VoucherNo", dgv1.Rows[i].Cells["txtVoucherNo"].Value);
            //                sqlCmd.Parameters.AddWithValue("@FinalSpeedReading", dgv1.Rows[i].Cells["txtFinalSpeedReading"].Value);
            //                sqlCmd.Parameters.AddWithValue("@journeyKilometer", dgv1.Rows[i].Cells["txtjourneyKilometer"].Value);
            //                sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", dgv1.Rows[i].Cells["txtAuthorizingOfficerName"].Value);
            //                sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", dgv1.Rows[i].Cells["txtAuthorizingOfficerNo"].Value);
            //                sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", dgv1.Rows[i].Cells["txtAuthorizingOfficerDesignation"].Value);
            //                sqlCmd.ExecuteNonQuery();
            //                sqlCon.Close(); 
            //        }
            //        }                
            //}
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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
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
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Homelinelpg", sqlCon);
                    SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT * FROM Kipsigislpg", sqlCon);
                    SqlDataAdapter sqlDa3 = new SqlDataAdapter("SELECT * FROM Jumbolpg", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    sqlDa2.Fill(dtbl);
                    sqlDa3.Fill(dtbl);
                    dgv1.DataSource = dtbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
                      
        }

        private void dgv1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTicketSummary ss = new WorkTicketSummary(label3.Text);
            ss.Show();
        }

       //void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath,string strHeader)
       // {
       //     System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
       //     Document document = new Document();
       //     document.SetPageSize(iTextSharp.text.PageSize.A4);
       //     PdfWriter writer = PdfWriter.GetInstance(document, fs);
       //     document.Open();

       //     //Report header
       //     BaseFont bfnHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
       //     iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfnHead, 16, 1, BaseColor.GRAY);
       //     Paragraph prgHeading = new Paragraph();
       //     prgHeading.Alignment = Element.ALIGN_CENTER;
       //     prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
       //     document.Add(prgHeading);

       //     //Date
       //     Paragraph prgAuthor = new Paragraph();
       //     BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
       //     iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, BaseColor.GRAY);
       //     prgAuthor.Alignment = Element.ALIGN_LEFT;
       //     prgAuthor.Add(new Chunk("Kericho Referral Hospital", fntAuthor));
       //     prgAuthor.Add(new Chunk("\nDate: "+DateTime.Now.ToShortDateString(), fntAuthor));
       //     document.Add(prgAuthor);
       //     //Linr Separation
       //     Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT,1)));
       //     document.Add(p);
       //     //Line Break
       //     document.Add(new Chunk("\n", fntHead));

       //     //Table
       //     PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
       //     //Table Header
       //     BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
       //     iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
       //     for(int i = 0; i < dtblTable.Columns.Count; i++)
       //     {
       //         PdfPCell cell = new PdfPCell();
       //         cell.BackgroundColor = BaseColor.GRAY;
       //         cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
       //         table.AddCell(cell);
       //     }
       //     //Data
       //     for (int i = 0; i<dtblTable.Rows.Count; i++)
       //     {
       //         for (int j = 0; j < dtblTable.Columns.Count; j++)
       //         {
       //             table.AddCell(dtblTable.Rows[i][j].ToString());
       //         }

       //     }
       //     document.Add(table);
       //     document.Close();
       //     writer.Close();
       //     fs.Close();

       // }
        private void button10_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dgv1, "KTIMS Records");
            //try
            //{
            //    DataTable dtbl = new DataTable();
            //    ExportDataTableToPdf(dtbl, @"D:\test.pdf", "KTIMS Record");
            //    System.Diagnostics.Process.Start(@"E:\test.pdf");
            //    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error Message");
            //}
        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dgv1, string filename)
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
            p2.Add(new Chunk("Daily Record of Ambulances"));

            //Table Data
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable records = new PdfPTable(dgv1.Columns.Count);
            records.DefaultCell.Padding = 1;
            records.WidthPercentage = 100;
            PdfPCell cells = new PdfPCell();            
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
            foreach (DataGridViewRow row in dgv1.Rows)
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




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Homelinelpg where date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT * FROM Kipsigislpg where Date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    SqlDataAdapter sqlDa3 = new SqlDataAdapter("SELECT * FROM Jumbolpg where Date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    sqlDa2.Fill(dtbl);
                    sqlDa3.Fill(dtbl);
                    dgv1.DataSource = dtbl;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
