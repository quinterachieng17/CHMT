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
    public partial class UpdateVehicleDetails : Form
    {       
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public UpdateVehicleDetails()
        {
            InitializeComponent();
        }

        public UpdateVehicleDetails(string username)
        {
            InitializeComponent();
            label1.Text = username;
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM VehicleRegistration", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvVehicleUpdate.DataSource = dtbl;
            }
        }

        private void UpdateVehicleDetails_Load(object sender, EventArgs e)
        {
            label1.Hide();
            PopulateDataGridView();
            
        }

        private void dgvVehicleUpdate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVehicleUpdate.CurrentRow != null)  //selects current row in focus
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    //Insert operation
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvVehicleUpdate.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("VehicleAddOrEdit", sqlCon); //Avoids sql injections
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtVehicleID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@VehicleID", 0);
                        sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Make", dgvRow.Cells["txtMake"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMake"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Model", dgvRow.Cells["txtModel"].Value == DBNull.Value ? "" : dgvRow.Cells["txtModel"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ChasisNo", dgvRow.Cells["txtChasisNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtChasisNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@EngineNo", dgvRow.Cells["txtEngineNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtEngineNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PlateNo", dgvRow.Cells["txtPlateNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPlateNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();                       
                        PopulateDataGridView();
                        
                    }                                    
                    else
                    //update operation
                    {
                        sqlCmd.Parameters.AddWithValue("@VehicleID", Convert.ToInt32(dgvRow.Cells["txtVehicleID"].Value));
                        sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Make", dgvRow.Cells["txtMake"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMake"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Model", dgvRow.Cells["txtModel"].Value == DBNull.Value ? "" : dgvRow.Cells["txtModel"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@ChasisNo", dgvRow.Cells["txtChasisNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtChasisNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@EngineNo", dgvRow.Cells["txtEngineNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtEngineNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@PlateNo", dgvRow.Cells["txtPlateNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPlateNo"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();                       
                        PopulateDataGridView();
                        
                    }
                }
            }
        }
        private void dgvVehicleUpdate_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly; //avoids the already binded textbox keypress event
            //if (dgvVehicleUpdate.CurrentCell.ColumnIndex == 1)// Allows only numbers into the ID Number cell
            //{

            //    e.Control.KeyPress += AllowNumbersOnly; //Adds keypress event into the textbox
            //}
        }
        private void AllowNumbersOnly(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private void dgvVehicleUpdate_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvVehicleUpdate.CurrentRow.Cells["txtVehicleID"].Value != DBNull.Value)

            //Deletes only if the user confirms by pressing "Yes"
             {
                if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("VehicleDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@VehicleID", Convert.ToInt32(dgvVehicleUpdate.CurrentRow.Cells["txtVehicleID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                }
                //  Blocks the default delete operation
                else
                    e.Cancel = true;
            }

            else
                e.Cancel = true;
        }

        private void dgvVehicleUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Please select a record to edit");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ev = new EditVehicle(label1.Text);
            ev.Show();
        }
    }
    }

