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
    public partial class Officers : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public Officers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // To get data from the database into a table - DataBind

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM SignUp", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvOfficers.AutoGenerateColumns = false;
                dgvOfficers.DataSource = dtbl;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails();
            ss.Show();
        }

        //To export the dataGridView to pdf

        public void exportgridviewtopdf(DataGridView dgvOfficers, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgvOfficers.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);



            //For header

      
            foreach (DataGridViewColumn column in dgvOfficers.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);

            }

            //Add datarow
            foreach (DataGridViewRow row in dgvOfficers.Rows)
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

        private void button10_Click(object sender, EventArgs e)
        {
           
            exportgridviewtopdf(dgvOfficers, "KTIMS Officers");
        }

        private void Officers_Load(object sender, EventArgs e)
        {
            dgvOfficers.Columns["Password"].Visible = false;
        }
    }
}
