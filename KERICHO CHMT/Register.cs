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

        public Register(string username)
        {
            InitializeComponent();
            label6.Text = username;
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
            Doctor ss = new Doctor(label6.Text);
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
       

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIDNumber.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Please fill mandatory fields");

            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Passwords do not match!");

            //Adds nurse to StaffReister Table
            else if (cbxDesignation.SelectedIndex==0)
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
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Staff added successfully");
                    Clear();

                }
            }

            //Add Driver to UserRegister Table
            else if (cbxDesignation.SelectedIndex == 1)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    sqlCmd.Parameters.AddWithValue("@DesignationID", cbxDesignation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegionID", cbxRegion.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("User added successfully");
                    Clear();

                }
            }
        }
        void Clear()
        {
            cbxDesignation.Text = cbxRegion.Text = txtFirstName.Text = txtLastName.Text = txtIDNumber.Text = txtUsername.Text =  txtPassword.Text = txtConfirmPassword.Text = "";
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails(label6.Text);
            ss.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleRegistration ss = new VehicleRegistration();
            ss.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ss = new EditVehicle();
            ss.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Driver ss = new Driver();
            ss.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTicketSummary ss = new WorkTicketSummary();
            ss.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords();
            ss.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.Hide();
            Nurse nn = new Nurse(label2.Text);
            nn.ShowDialog();
        }
    }
}
