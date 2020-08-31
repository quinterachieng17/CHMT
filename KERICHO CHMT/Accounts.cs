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
    public partial class Accounts : Form
    {
        String connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True;";
        public Accounts()
        {
            InitializeComponent();
        }

        public Accounts(string username)
        {
            InitializeComponent();
            label7.Text = username;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet45.VehicleRegistration' table. You can move, or remove it, as needed.
            this.vehicleRegistrationTableAdapter.Fill(this.cmbloginDataSet45.VehicleRegistration);
            // TODO: This line of code loads data into the 'cmbloginDataSet21.VehicleRegistration' table. You can move, or remove it, as needed.
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            label7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor doc = new Doctor(label7.Text);
            doc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cmbStation.Text == "" || cmbVehicleNo.Text == "" || txtLpoNo.Text == "" || txtMaintenance.Text == "" || txtFuelDrawn.Text=="" || txtOilDrawn.Text=="" )
                MessageBox.Show("Driver's/Authorizing Officer's Details or Mileage cannot be blank");

            
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AccountsAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@VehicleID", 0);
                    sqlCmd.Parameters.AddWithValue("@VehicleNo", cmbVehicleNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Station", cmbStation.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LpoNo", txtLpoNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Payments",txtPayments.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Maintenance", txtMaintenance.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FuelDrawn", txtFuelDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@OilDrawn", txtOilDrawn.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Others", txtOthers.Text.Trim());                 
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Recorded succsessful");
                    Clear();
                }

            }
        }
        void Clear()
        {
            cmbVehicleNo.Text = cmbStation.Text = txtLpoNo.Text = txtPayments.Text = txtOilDrawn.Text = txtFuelDrawn.Text = txtMaintenance.Text = txtOthers.Text = "";
        }
    }
}
