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
    public partial class EditPatientDetails : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public EditPatientDetails()
        {
            InitializeComponent();
        }

        public EditPatientDetails(string username)
        {
            InitializeComponent();
            label3.Text = username;
        }
        //Dialog Box Custom
        static EditPatientDetails MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnEdit, string btnCancel)
        {
            MsgBox = new EditPatientDetails();
            MsgBox.label1.Text = "EDIT TRANSFERRED REFERRAL CASE FROM KERICHO COUNTY REFERRAL HOSPITAL";
            MsgBox.label2.Text = "Patient No.";
            MsgBox.button1.Text = "Preview";
            MsgBox.button2.Text = "Incoming Referral";
            MsgBox.button3.Text = "Transferred Case";
            MsgBox.btnCancel.Text = "Back";
            MsgBox.btnEdit.Text = "Save";
            MsgBox.ShowDialog();
            return result;

        }

        private void EditPatientDetails_Load(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView2.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiefNurse cn = new ChiefNurse(label3.Text);
            cn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PatientRegisterApproved", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
            label4.Text = "Incoming Referral Patients";
            dataGridView1.Show();
            dataGridView2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM ReferralRegisterApproved", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView2.DataSource = dtbl;
            }
            label4.Text = "Transferred Referral Patients";
            dataGridView1.Hide();
            dataGridView2.Show();
        }
        void PopulateDataGridView1()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PatientRegisterApproved", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)  //selects current row in focus
            {
                //Insert Operation
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("PatientAddOrEdit", sqlCon); //Avoids sql injections
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtPatientID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@PatientID", 0);
                        sqlCmd.Parameters.AddWithValue("@PatientName", dgvRow.Cells["txtPatientName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPatientName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PatientNo", dgvRow.Cells["txtPatientNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPatientNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ReasonForReferral", dgvRow.Cells["txtReasonForReferral"].Value == DBNull.Value ? "" : dgvRow.Cells["txtReasonForReferral"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Facility", dgvRow.Cells["txtFacility"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFacility"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseReceiving", dgvRow.Cells["txtNurseReceiving"].Value == DBNull.Value ? "" : dgvRow.Cells["txtNurseReceiving"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverIncharge", dgvRow.Cells["txtDriverIncharge"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverIncharge"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseOnTransit", dgvRow.Cells["txtNurseOnTransit"].Value == DBNull.Value ? "" : dgvRow.Cells["txtNurseOnTransit"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverNo", dgvRow.Cells["txtDriverNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@TimeOfCall", dgvRow.Cells["txtTimeOfCall"].Value == DBNull.Value ? "" : dgvRow.Cells["txtTimeOfCall"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ApprovalStatus", dgvRow.Cells["txtApprovalStatus"].Value == DBNull.Value ? "" : dgvRow.Cells["txtApprovalStatus"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ArrivalTime", dgvRow.Cells["txtArrivalTime"].Value == DBNull.Value ? "" : dgvRow.Cells["txtArrivalTime"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@CommentsDelays", dgvRow.Cells["txtCommentsDelays"].Value == DBNull.Value ? "" : dgvRow.Cells["txtCommentsDelays"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView1();
                    }

                    else
                    //update operation
                    {
                        sqlCmd.Parameters.AddWithValue("@PatientID", Convert.ToInt32(dgvRow.Cells["txtPatientID"].Value));
                        sqlCmd.Parameters.AddWithValue("@PatientName", dgvRow.Cells["txtPatientName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPatientName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PatientNo", dgvRow.Cells["txtPatientNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPatientNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ReasonForReferral", dgvRow.Cells["txtReasonForReferral"].Value == DBNull.Value ? "" : dgvRow.Cells["txtReasonForReferral"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Facility", dgvRow.Cells["txtFacility"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFacility"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseReceiving", dgvRow.Cells["txtNurseReceiving"].Value == DBNull.Value ? "" : dgvRow.Cells["txtNurseReceiving"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverIncharge", dgvRow.Cells["txtDriverIncharge"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverIncharge"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseOnTransit", dgvRow.Cells["txtNurseOnTransit"].Value == DBNull.Value ? "" : dgvRow.Cells["txtNurseOnTransit"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverNo", dgvRow.Cells["txtDriverNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@TimeOfCall", dgvRow.Cells["txtTimeOfCall"].Value == DBNull.Value ? "" : dgvRow.Cells["txtTimeOfCall"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ApprovalStatus", dgvRow.Cells["txtApprovalStatus"].Value == DBNull.Value ? "" : dgvRow.Cells["txtApprovalStatus"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ArrivalTime", dgvRow.Cells["txtArrivalTime"].Value == DBNull.Value ? "" : dgvRow.Cells["txtArrivalTime"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@CommentsDelays", dgvRow.Cells["txtCommentsDelays"].Value == DBNull.Value ? "" : dgvRow.Cells["txtCommentsDelays"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView1();
                    }
                }

            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["txtPatientID"].Value != DBNull.Value)

            //Deletes only if the user confirms by pressing "Yes"
            {
                if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("PatientDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@PatientID", Convert.ToInt32(dataGridView1.CurrentRow.Cells["txtPatientID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Deleted.");
                }
                //  Blocks the default delete operation
                else
                    e.Cancel = true;
            }

            else
                e.Cancel = true;
        }

        //Transfer DataGridView2
        void PopulateDataGridView2()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM ReferralRegisterApproved", sqlCon);
                DataTable dtbl2 = new DataTable();
                sqlDa.Fill(dtbl2);
                dataGridView2.DataSource = dtbl2;
            }
        }

        private void dataGridView2_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {      
            if (dataGridView2.CurrentRow != null)  //selects current row in focus
            {
                //Insert Operation
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgv2Row = dataGridView2.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("TransferAddOrEdit", sqlCon); //Avoids sql injections
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgv2Row.Cells["textBoxPatientID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@PatientID", 0);
                        sqlCmd.Parameters.AddWithValue("@PatientName", dgv2Row.Cells["textBoxPatientName"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxPatientName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PatientNo", dgv2Row.Cells["textBoxPatientNo"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxPatientNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ReasonForReferral", dgv2Row.Cells["textBoxReasonForReferral"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxReasonForReferral"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Facility", dgv2Row.Cells["textBoxFacility"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxFacility"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseReferring", dgv2Row.Cells["textBoxNurseReferring"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxNurseReferring"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegNo", dgv2Row.Cells["textBoxRegNo"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxRegNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverIncharge", dgv2Row.Cells["textBoxDriverIncharge"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxDriverIncharge"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseOnTransit", dgv2Row.Cells["textBoxNurseOnTransit"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxNurseOnTransit"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverNo", dgv2Row.Cells["textBoxDriverNo"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxDriverNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Date", dgv2Row.Cells["textBoxDate"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxDate"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@TimeOfCall", dgv2Row.Cells["textBoxTimeOfCall"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxTimeOfCall"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@TransferStatus", dgv2Row.Cells["textBoxTransferStatus"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxTransferStatus"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Time", dgv2Row.Cells["textBoxTime"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxTime"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Comments", dgv2Row.Cells["textBoxComments"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxComments"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView2();
                    }

                    else
                    //update operation
                    {
                        sqlCmd.Parameters.AddWithValue("@PatientID", Convert.ToInt32(dgv2Row.Cells["textBoxPatientID"].Value));
                        sqlCmd.Parameters.AddWithValue("@PatientName", dgv2Row.Cells["textBoxPatientName"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxPatientName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PatientNo", dgv2Row.Cells["textBoxPatientNo"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxPatientNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ReasonForReferral", dgv2Row.Cells["textBoxReasonForReferral"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxReasonForReferral"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Facility", dgv2Row.Cells["textBoxFacility"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxFacility"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseReferring", dgv2Row.Cells["textBoxNurseReferring"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxNurseReferring"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegNo", dgv2Row.Cells["textBoxRegNo"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxRegNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverIncharge", dgv2Row.Cells["textBoxDriverIncharge"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxDriverIncharge"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@NurseOnTransit", dgv2Row.Cells["textBoxNurseOnTransit"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxNurseOnTransit"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DriverNo", dgv2Row.Cells["textBoxDriverNo"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxDriverNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Date", dgv2Row.Cells["textBoxDate"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxDate"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@TimeOfCall", dgv2Row.Cells["textBoxTimeOfCall"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxTimeOfCall"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@TransferStatus", dgv2Row.Cells["textBoxTransferStatus"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxTransferStatus"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Time", dgv2Row.Cells["textBoxTime"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxTime"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Comments", dgv2Row.Cells["textBoxComments"].Value == DBNull.Value ? "" : dgv2Row.Cells["textBoxComments"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView2();
                    }
                }

            }
        }
      

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells["textBoxPatientID"].Value != DBNull.Value)

            //Deletes only if the user confirms by pressing "Yes"
            {
                if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("TransferDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@PatientID", Convert.ToInt32(dataGridView2.CurrentRow.Cells["textBoxPatientID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Deleted.");
                }
                //  Blocks the default delete operation
                else
                    e.Cancel = true;
            }

            else
                e.Cancel = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
