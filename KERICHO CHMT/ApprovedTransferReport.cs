using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace KERICHO_CHMT
{
    public partial class ApprovedTransferReport : Form
    {
        public ApprovedTransferReport()
        {
            InitializeComponent();
        }

        public ApprovedTransferReport(string username)
        {
            InitializeComponent();
            label3.Text = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rr = new Reports(label3.Text);
            rr.ShowDialog();
        }

        private void ApprovedTransferReport_Load(object sender, EventArgs e)
        {
            label3.Hide();
            // TODO: This line of code loads data into the 'cmbloginDataSet11.ReferralRegisterApproved' table. You can move, or remove it, as needed.
            this.referralRegisterApprovedTableAdapter1.Fill(this.cmbloginDataSet11.ReferralRegisterApproved);
            // TODO: This line of code loads data into the 'cmbloginDataSet7.ReferralRegisterApproved' table. You can move, or remove it, as needed.
            this.referralRegisterApprovedTableAdapter.Fill(this.cmbloginDataSet7.ReferralRegisterApproved);

        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dataGridView1, string filename)
        {
            ////Report Header
            BaseFont head = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            Paragraph p = new Paragraph();
            p.Alignment = Element.ALIGN_CENTER;
            p.Add(new Chunk("KERICHO COUNTY REFERRAL HOSPITAL"));
            p.Add(new Chunk("\nP.O BOX 11 -20200 KERICHO"));
            p.Add(new Chunk("\nDate: " + DateTime.Now.ToShortDateString()));

            //Line Separation
            Paragraph pra = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            p.Add(new Chunk("\n"));

            //Table Head
            Paragraph p2 = new Paragraph();
            p2.Alignment = Element.ALIGN_CENTER;
            p2.Add(new Chunk("Approved Referral Cases from Kericho County Referral Hospital"));

            //Table Data
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable records = new PdfPTable(dataGridView1.Columns.Count);
            records.DefaultCell.Padding = 1;
            records.WidthPercentage = 100;
            PdfPCell cells = new PdfPCell();
            records.HorizontalAlignment = Element.ALIGN_LEFT;
            records.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //For header
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                records.AddCell(cell);

            }
            //Add datarow
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            exportgridviewtopdf(dataGridView1, "Approved Outgoing Referrals from KCRH");
        }
    }
}
