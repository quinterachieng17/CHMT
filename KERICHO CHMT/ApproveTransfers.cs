using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KERICHO_CHMT
{
    public partial class ApproveTransfers : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public ApproveTransfers()
        {
            InitializeComponent();
        }
        //Dialog Box Custom
        static ApproveTransfers MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnSave, string btnCancel)
        {
            MsgBox = new ApproveTransfers();
            MsgBox.label1.Text = Text;            
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnSave;
            MsgBox.ShowDialog();
            return result;

        }
        // Adding checkbox to the datagrideview for approval
        public void update()
        {
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Approved";
            chk.Name = "CheckBox";
            dgvAllTransfersApprove.Columns.Add(chk);
        }

        private void ApproveTransfers_Load(object sender, EventArgs e)
        {
            Update();

            //Loads data from PatienRegister table
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM ReferralRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvAllTransfersApprove.AutoGenerateColumns = false;
                dgvAllTransfersApprove.DataSource = dtbl;

                // Adding checkbox to the datagrideview for approval
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Approved";
                chk.Name = "CheckBox";
                dgvAllTransfersApprove.Columns.Add(chk);

            }
        }

        

    }
 }

