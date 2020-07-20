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
       
        private void ApproveTransfers_Load(object sender, EventArgs e)
        {
            //Loads data from ReferralRegister table
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM ReferralRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvAllTransfersApprove.AutoGenerateColumns = false;
                dgvAllTransfersApprove.DataSource = dtbl;

                //Pending Approval Status
                foreach (DataGridViewRow row in dgvAllTransfersApprove.Rows)
                {
                    for (int i = 0; i < dgvAllTransfersApprove.Rows.Count; i++)
                    {
                        row.Cells[12].Value = "Pending Approval";
                    }
                }

                // Adding checkbox to the datagrideview for approval
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Approved";
                chk.Name = "CheckBox";
                dgvAllTransfersApprove.Columns.Add(chk);

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                foreach (DataGridViewRow row in dgvAllTransfersApprove.Rows)
                {
                    for (int i = 0; i < dgvAllTransfersApprove.Rows.Count; i++)
                    {                  

                        if (row.Cells[12].Value != null)
                        {
                            row.Cells[12].Value = "Approved";
                            

                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("ReferralApprovedAdd", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@PatientNo", dgvAllTransfersApprove.Rows[i].Cells[1].Value);
                            sqlCmd.Parameters.AddWithValue("@PatientName", dgvAllTransfersApprove.Rows[i].Cells[2].Value);
                            sqlCmd.Parameters.AddWithValue("@ReasonForReferral", dgvAllTransfersApprove.Rows[i].Cells[3].Value);
                            sqlCmd.Parameters.AddWithValue("@Facility", dgvAllTransfersApprove.Rows[i].Cells[4].Value);
                            sqlCmd.Parameters.AddWithValue("@NurseReferring", dgvAllTransfersApprove.Rows[i].Cells[5].Value);
                            sqlCmd.Parameters.AddWithValue("@NurseOnTransit", dgvAllTransfersApprove.Rows[i].Cells[6].Value);
                            sqlCmd.Parameters.AddWithValue("@DriverIncharge", dgvAllTransfersApprove.Rows[i].Cells[7].Value);
                            sqlCmd.Parameters.AddWithValue("@DriverNo", dgvAllTransfersApprove.Rows[i].Cells[8].Value);
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvAllTransfersApprove.Rows[i].Cells[9].Value);
                            sqlCmd.Parameters.AddWithValue("@Date", dgvAllTransfersApprove.Rows[i].Cells[10].Value);
                            sqlCmd.Parameters.AddWithValue("@TimeOfCall", dgvAllTransfersApprove.Rows[i].Cells[11].Value);
                            sqlCmd.Parameters.AddWithValue("@TransferStatus", dgvAllTransfersApprove.Rows[i].Cells[12].Value);                            
                            sqlCmd.Parameters.AddWithValue("@Approved", dgvAllTransfersApprove.Rows[i].Cells[13].Value);
                            sqlCmd.ExecuteNonQuery();                           
                            sqlCon.Close();
                        }
                        
                    }
                   
                }

            }


        }

        private void dgvAllTransfersApprove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }

