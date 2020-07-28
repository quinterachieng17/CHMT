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
            if (cmbDriverNo.Text == "" || txtMileage.Text == "")
                MessageBox.Show("Driver's ID or Mileage cannot be blank");

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("MileageAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    sqlCmd.Parameters.AddWithValue("@DriverID", cmbDriverNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MileageReading", txtMileage.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lpgStation", cmbStation.Text.Trim());
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
            cmbDriverNo.Text = txtMileage.Text =  cmbRegNo.Text=cmbStation.Text = txtOilDrawn.Text = txtFuelDrawn.Text = txtDestination.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor();
            ss.Show();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet21.VehicleRegistration' table. You can move, or remove it, as needed.
            this.vehicleRegistrationTableAdapter.Fill(this.cmbloginDataSet21.VehicleRegistration);
            // TODO: This line of code loads data into the 'cmbloginDataSet20.UserRegister' table. You can move, or remove it, as needed.
            this.userRegisterTableAdapter.Fill(this.cmbloginDataSet20.UserRegister);

        }

        private void DriverID_Click(object sender, EventArgs e)
        {

        }

        private void txtMileage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDriverID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtVehicleReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDestination_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
