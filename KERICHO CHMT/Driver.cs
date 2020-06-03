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
    public partial class Driver : Form
    {
        String connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True;";
        public Driver()
        {
            InitializeComponent();
        }

     
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDriverID.Text == "" || txtMileage.Text == "")
                MessageBox.Show("Driver's ID or Mileage cannot be blank");

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("MileageAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    sqlCmd.Parameters.AddWithValue("@DriverID", txtDriverID.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MileageReading", txtMileage.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegNo", txtVehicleReg.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Destination", txtDestination.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Mileage Recorded succsessfully");
                    Clear();
                }
            }
        }
        void Clear()
        {
            txtDriverID.Text = txtMileage.Text =  txtVehicleReg.Text = txtOilDrawn.Text = txtFuelDrawn.Text = txtDestination.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor();
            ss.Show();
        }

        private void Driver_Load(object sender, EventArgs e)
        {

        }

        private void DriverID_Click(object sender, EventArgs e)
        {

        }

        private void txtMileage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
