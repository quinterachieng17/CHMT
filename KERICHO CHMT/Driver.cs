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

        public Driver(string username)
        {
            InitializeComponent();
            label5.Text = username;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbDriverNo.Text == "" || cmbDriverName.Text == "" || txtMileage.Text == "" || txtAuthorizingOfficerNo.Text == "")
                MessageBox.Show("Driver's/Authorizing Officer's Details or Mileage cannot be blank");

            //Jumbo lpg
            else if (cmbStation.SelectedIndex == 0)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("JumboAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    sqlCmd.Parameters.AddWithValue("@DriverID", cmbDriverNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DriverName", cmbDriverName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MileageReading", txtMileage.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lpgStation", cmbStation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Destination", txtDestination.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@VoucherNo", txtVoucherNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", txtAuthorizingOfficerName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", txtAuthorizingOfficerNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", cmbAuthorizingOfficerDesignation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Mileage Recorded succsessfully");
                    Clear();
                }

            }
            //Kipsigis lpg
            else if (cmbStation.SelectedIndex == 1)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("KipsigisAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    sqlCmd.Parameters.AddWithValue("@DriverID", cmbDriverNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DriverName", cmbDriverName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MileageReading", txtMileage.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lpgStation", cmbStation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Destination", txtDestination.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@VoucherNo", txtVoucherNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", txtAuthorizingOfficerName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", txtAuthorizingOfficerNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", cmbAuthorizingOfficerDesignation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Mileage Recorded succsessfully");
                    Clear();
                }

            }
            //Homeline lpg
            else if (cmbStation.SelectedIndex == 2)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("HomelineAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    sqlCmd.Parameters.AddWithValue("@DriverID", cmbDriverNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DriverName", cmbDriverName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@MileageReading", txtMileage.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@RegNo", cmbRegNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lpgStation", cmbStation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Destination", txtDestination.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@VoucherNo", txtVoucherNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", txtAuthorizingOfficerName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", txtAuthorizingOfficerNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", cmbAuthorizingOfficerDesignation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Mileage Recorded succsessfully");
                    Clear();
                }
            }
           
        }
        void Clear()
        {
            cmbDriverNo.Text = cmbDriverNo.Text = txtMileage.Text =  cmbRegNo.Text=cmbStation.Text = txtOilDrawn.Text = txtFuelDrawn.Text = txtDestination.Text = txtVoucherNo.Text = txtAuthorizingOfficerName.Text = txtAuthorizingOfficerNo.Text = cmbAuthorizingOfficerDesignation.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor ss = new Doctor(label5.Text);
            ss.Show();
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet42.UserRegister' table. You can move, or remove it, as needed.
            this.userRegisterTableAdapter1.Fill(this.cmbloginDataSet42.UserRegister);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            label5.Hide();
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
