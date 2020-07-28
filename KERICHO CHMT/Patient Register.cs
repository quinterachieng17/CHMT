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
    public partial class Patient_Register : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True");
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public Patient_Register()
        {

            InitializeComponent();
           
        }

        // Register Patient Form as a customed message box
        static Patient_Register MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOk, string btnCancel)
        {
            MsgBox = new Patient_Register();
            MsgBox.label2.Text = "Patient Name";
            MsgBox.label3.Text = "Patient No";
            MsgBox.label4.Text = "Reason For Referral";
            MsgBox.label5.Text = "Facility";
            MsgBox.label6.Text = "Referring/Receiving Nurse";
            MsgBox.label9.Text = "Nurse(s) on Transit";
            MsgBox.label10.Text = "Driver's No.";
            MsgBox.label11.Text = "Driver In Charge";
            MsgBox.label12.Text = "Reg. No";
            MsgBox.label13.Text = "Date";
            MsgBox.label15.Text = "Time Of Call";
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnSubmit.Text = btnOk;
            MsgBox.ShowDialog();
            return result;

        }

        private void Patient_Register_Load(object sender, EventArgs e)
        {           
            RegNo();
            DriverIncharge();
            DriverName();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNurseAttending_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
                if (txtPatientName.Text == "" || txtPatientNo.Text == "" || cmbFacility.Text == "" || txtFacility.Text =="" || txtTimeOfCall.Text == "")
                    MessageBox.Show("Patient Details, Facility From and Time of call cannot be blank");

               
                else if (cmbFacility.SelectedIndex == 0)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("PatientAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@PatientID", 0);                   
                        sqlCmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@PatientNo", txtPatientNo.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@ReasonForReferral", txtReasonForReferral.Text.Trim());                       
                        sqlCmd.Parameters.AddWithValue("@Facility", txtFacility.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@NurseReceiving", txtNurseAttending.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@DriverIncharge",cmbDriverIncharge.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@DriverNo", cmbDriverNo.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@NurseOnTransit", txtNurseOnTransit.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker2.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@TimeOfCall", txtTimeOfCall.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Patient successfully added");
                        Clear();

                    }
                }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ReferralAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@PatientID", 0);                 
                    sqlCmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PatientNo", txtPatientNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ReasonForReferral", txtReasonForReferral.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Facility", txtFacility.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NurseReferring", txtNurseAttending.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DriverIncharge", cmbDriverIncharge.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DriverNo", cmbDriverNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@NurseOnTransit", txtNurseOnTransit.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@TimeOfCall", txtTimeOfCall.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Transfer Recorded successfully");
                    Clear();

                }

            }
            }
            void Clear()
        {
            txtPatientName.Text = txtPatientNo.Text = txtReasonForReferral.Text = cmbFacility.Text = txtNurseAttending.Text = cmbRegNo.Text = cmbDriverIncharge.Text = cmbDriverNo.Text = txtNurseOnTransit.Text = txtFacility.Text = txtTimeOfCall.Text ="";
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPatientNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReasonForRefferal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFacility_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNurseOnTransit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriverNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriverIncharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void cmbFacility_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //For regNo combo box
        public void RegNo()
        {
            cmbRegNo.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select RegNo from VehicleRegistration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbRegNo.Items.Add(dr["RegNo"].ToString());
            }
            con.Close();
        }

        //For Driver Number combo box
        public void DriverName()
        {
            cmbDriverNo.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select IDNumber from UserRegister";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbDriverNo.Items.Add(dr["IDNumber"].ToString());
            }
            con.Close();
        }
        //For Driver incharge combo box
        public void DriverIncharge()
        {
            cmbDriverIncharge.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select FirstName from UserRegister";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbDriverIncharge.Items.Add(dr["FirstName"].ToString());
            }
            con.Close();
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbDriverIncharge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
