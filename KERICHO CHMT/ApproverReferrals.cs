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
        public static DialogResult Show(string Text, string Caption, string btnApprove, string btnCancel)
        {
            MsgBox = new ApproverReferrals();
            MsgBox.label1.Text = Text;          
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnApprove;
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

                //Pending Approval Status
                foreach (DataGridViewRow row in dgvAllCasesApproved.Rows)
                {
                    for (int i = 0; i < dgvAllCasesApproved.Rows.Count - 1; i++)
                    {
                        row.Cells[12].Value = "Pending Approval";
                    }
                }

                // Adding checkbox to the datagrideview for approval
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "Approve";
                chk.Name = "CheckBox";
                dgvAllCasesApproved.Columns.Add(chk);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                foreach(DataGridViewRow row in dgvAllCasesApproved.Rows)
                {
                    for (int i = 0; i < dgvAllCasesApproved.Rows.Count-1; i++)
                    {
                        
                                             
                        if (row.Cells[12].Value != null)
                        {
                            row.Cells[12].Value = "Approved";
                            
                                sqlCon.Open();
                                SqlCommand sqlCmd = new SqlCommand("PatientApprovedAdd", sqlCon);
                                sqlCmd.CommandType = CommandType.StoredProcedure;
                                sqlCmd.Parameters.AddWithValue("@PatientNo", dgvAllCasesApproved.Rows[i].Cells[1].Value);
                                sqlCmd.Parameters.AddWithValue("@PatientName", dgvAllCasesApproved.Rows[i].Cells[2].Value);                              
                                sqlCmd.Parameters.AddWithValue("@ReasonForReferral", dgvAllCasesApproved.Rows[i].Cells[3].Value);
                                sqlCmd.Parameters.AddWithValue("@Facility", dgvAllCasesApproved.Rows[i].Cells[4].Value);
                                sqlCmd.Parameters.AddWithValue("@NurseReceiving", dgvAllCasesApproved.Rows[i].Cells[5].Value);
                                sqlCmd.Parameters.AddWithValue("@NurseOnTransit", dgvAllCasesApproved.Rows[i].Cells[6].Value);
                                sqlCmd.Parameters.AddWithValue("@DriverIncharge", dgvAllCasesApproved.Rows[i].Cells[7].Value);
                                sqlCmd.Parameters.AddWithValue("@DriverNo", dgvAllCasesApproved.Rows[i].Cells[8].Value);
                                sqlCmd.Parameters.AddWithValue("@RegNo", dgvAllCasesApproved.Rows[i].Cells[9].Value);                               
                                sqlCmd.Parameters.AddWithValue("@Date", dgvAllCasesApproved.Rows[i].Cells[10].Value);
                                sqlCmd.Parameters.AddWithValue("@TimeOfCall", dgvAllCasesApproved.Rows[i].Cells[11].Value);
                                sqlCmd.Parameters.AddWithValue("@ApprovalStatus", dgvAllCasesApproved.Rows[i].Cells[12].Value);
                                sqlCmd.Parameters.AddWithValue("@Approved", dgvAllCasesApproved.Rows[i].Cells[13].Value);
                                sqlCmd.ExecuteNonQuery();                               
                                sqlCon.Close();
                        }
                                   
                    }
                   
                }
               
            }
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiefNurse cn = new ChiefNurse();
            cn.Show();
        }
    }
}
