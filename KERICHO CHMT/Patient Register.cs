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

        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public Patient_Register()
        {

            InitializeComponent();
        }

        private void Patient_Register_Load(object sender, EventArgs e)
        {
                    
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
            this.Hide();
            Nurse nn = new Nurse();
            nn.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
                if (txtPatientName.Text == "" || txtPatientNo.Text == "" || txtFacility.Text == "")
                    MessageBox.Show("Patient Details and Facility From cannot be blank");

               
                else
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("PatientAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@PatientID", 0);
                        sqlCmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@PatientNo", txtPatientNo.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@ReasonForRefferal", txtReasonForRefferal.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Facility", txtFacility.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@NurseAttending", txtNurseAttending.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@DriverIncharge", txtDriverIncharge.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@DriverNo", txtDriverNo.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@NurseOnTransit", txtNurseOnTransit.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Patient successfully added");
                        Clear();

                    }
                }
            }
            void Clear()
        {
            txtPatientName.Text = txtPatientNo.Text = txtReasonForRefferal.Text = txtFacility.Text = txtNurseAttending.Text = txtRegNo.Text = txtDriverIncharge.Text = txtDriverNo.Text = txtNurseOnTransit.Text = "";
            
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
    }
}
