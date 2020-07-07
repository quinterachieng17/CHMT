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
    public partial class ApproverReferrals : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public ApproverReferrals()
        {
            InitializeComponent();
        }

        //Dialog Box Custom
        static ApproverReferrals MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnSave, string btnCancel)
        {
            MsgBox = new ApproverReferrals();
            MsgBox.label1.Text = Text;          
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnSave;
            MsgBox.ShowDialog();
            return result;

        }

        private void dgvAllCases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApproverReferrals_Load(object sender, EventArgs e)
        {
           
            
            //Loads data from PatienRegister table
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PatientRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvAllCasesApproved.AutoGenerateColumns = false;
                dgvAllCasesApproved.DataSource = dtbl;

                // Adding checkbox to the datagrideview for approval
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Approved";
                chk.Name = "CheckBox";
                dgvAllCasesApproved.Columns.Add(chk);

            }
        }

    }
}
