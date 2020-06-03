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
    public partial class Register : Form
    {

        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";

        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor();
            ss.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleRegistration ss = new VehicleRegistration();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           Driver ss = new Driver();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ss = new EditVehicle();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIDNumber.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill mandatory fields");

            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Passwords do not match!");

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("StaffAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID",0);
                    sqlCmd.Parameters.AddWithValue("@DesignationID", cbxDesignation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegionID", cbxRegion.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Staff successfully added");
                    Clear();

                }
            }
        }
        void Clear()
        {
            cbxDesignation.Text = cbxRegion.Text = txtFirstName.Text = txtLastName.Text = txtIDNumber.Text =  txtPassword.Text = txtConfirmPassword.Text = "";
        }
    }
}
