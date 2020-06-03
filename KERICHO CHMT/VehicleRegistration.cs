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
    public partial class VehicleRegistration : Form
    {
        String connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True;";
        public VehicleRegistration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text == "" || txtMake.Text == "" || txtModel.Text == "" || txtChasisNo.Text == "" || txtEngineNo.Text == "" || txtPlateNo.Text == "")
                MessageBox.Show("All fields MUST be filled");

            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    SqlCommand sqlCmd = new SqlCommand("VehicleAdd", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Make", txtMake.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ChasisNo", txtChasisNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EngineNo", txtEngineNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PlateNo", txtPlateNo.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("New Motor Vehicle Details Recorded Successfuly");
                    Clear();

                }
            }
        }
        void Clear()
        {
            txtRegNo.Text = txtMake.Text = txtModel.Text = txtChasisNo.Text = txtEngineNo.Text = txtPlateNo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Doctor ss = new Doctor();
            ss.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void VehicleRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
