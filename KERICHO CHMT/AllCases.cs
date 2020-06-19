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
    public partial class AllCases : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public AllCases()
        {
            InitializeComponent();
        }

        //Dialog Box Custom
        static AllCases MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnDownload, string btnCancel)
        {
            MsgBox = new AllCases();
            MsgBox.label1.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnDownload;
            MsgBox.ShowDialog();
            return result;

        }

        private void AllCases_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PatientRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvAllCases.AutoGenerateColumns = false;
                dgvAllCases.DataSource = dtbl;

            }
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dgvAllCases, "Referral Case for ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
