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
        SqlConnection sqlcon = new SqlConnection("Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True");
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
            String query = "select * from ReferralRegister,CommentsTableTransfers where ReferralRegister.PatientNo = CommentsTableTransfers.PatientNo";
            SqlCommand cmd = new SqlCommand(query, sqlcon);
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            DataTable dtbl = new DataTable();
            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);
            sqlDa.Fill(dtbl);
            dgvAllTransfersApprove.DataSource = dtbl;
            dgvAllTransfersApprove.AutoGenerateColumns = false; // Displays only the selected columns
            sqlcon.Close();

            //Pending Approval Status
            foreach (DataGridViewRow row in dgvAllTransfersApprove.Rows)
            {
                for (int i = 0; i < dgvAllTransfersApprove.Rows.Count; i++)
                {
                    row.Cells["TransferStatus"].Value = "Pending Approval";
                }
            }

            // Adding checkbox to the datagrideview for approval
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Approve";
            chk.Name = "CheckBox";
            dgvAllTransfersApprove.Columns.Add(chk);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                foreach (DataGridViewRow row in dgvAllTransfersApprove.Rows)
                {
                    for (int i = 0; i < dgvAllTransfersApprove.Rows.Count; i++)
                    {

                        if (row.Cells["CheckBox"].Value != null)
                        {
                            row.Cells["TransferStatus"].Value = "Approved";                            
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("ReferralApprovedAdd", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@PatientName", dgvAllTransfersApprove.Rows[i].Cells["PatientName"].Value);
                            sqlCmd.Parameters.AddWithValue("@PatientNo", dgvAllTransfersApprove.Rows[i].Cells["PatientNo"].Value);
                            sqlCmd.Parameters.AddWithValue("@ReasonForReferral", dgvAllTransfersApprove.Rows[i].Cells["ReasonForReferral"].Value);
                            sqlCmd.Parameters.AddWithValue("@Facility", dgvAllTransfersApprove.Rows[i].Cells["Facility"].Value);
                            sqlCmd.Parameters.AddWithValue("@NurseOnTransit", dgvAllTransfersApprove.Rows[i].Cells["NurseOnTransit"].Value);
                            sqlCmd.Parameters.AddWithValue("@Nursereferring", dgvAllTransfersApprove.Rows[i].Cells["NurseAttending"].Value);
                            sqlCmd.Parameters.AddWithValue("@DriverIncharge", dgvAllTransfersApprove.Rows[i].Cells["DriverIncharge"].Value);
                            sqlCmd.Parameters.AddWithValue("@DriverNo", dgvAllTransfersApprove.Rows[i].Cells["DriverNo"].Value);
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvAllTransfersApprove.Rows[i].Cells["RegNo"].Value);
                            sqlCmd.Parameters.AddWithValue("@Date", dgvAllTransfersApprove.Rows[i].Cells["Date"].Value);
                            sqlCmd.Parameters.AddWithValue("@TimeOfCall", dgvAllTransfersApprove.Rows[i].Cells["TimeOfCall"].Value);
                            sqlCmd.Parameters.AddWithValue("@TransferStatus", dgvAllTransfersApprove.Rows[i].Cells["TransferStatus"].Value);
                            sqlCmd.Parameters.AddWithValue("@Time", dgvAllTransfersApprove.Rows[i].Cells["Time"].Value);
                            sqlCmd.Parameters.AddWithValue("@Comments", dgvAllTransfersApprove.Rows[i].Cells["Comments"].Value);
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

