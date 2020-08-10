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
    public partial class UpdateStaffDetails : Form
    {
        //Integrated Security=True since we are using windows authentication
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public UpdateStaffDetails()
        {
            InitializeComponent();
        }

        public UpdateStaffDetails(string username)
        {
            InitializeComponent();
            label2.Text = username;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateStaffDetails_Load(object sender, EventArgs e)
        {
            //label2.Hide();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM UserRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
            }
            label1.Text = "Update Driver Details";
        }

        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM UserRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
            }
        }

       
        private void dgvEmployee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)  //selects current row in focus
            {
                //Insert Operation
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvEmployee.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("UserAddOrEdit", sqlCon); //Avoids sql injections
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtUserID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@UserID", 0);
                        sqlCmd.Parameters.AddWithValue("@FirstName", dgvRow.Cells["txtFirstName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFirstName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@LastName", dgvRow.Cells["txtLastName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtLastName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@IDNumber", dgvRow.Cells["txtIDNumber"].Value == DBNull.Value ? "" : dgvRow.Cells["txtIDNumber"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Password", dgvRow.Cells["txtPassword"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPassword"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Username", dgvRow.Cells["txtUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["txtUsername"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DesignationID", dgvRow.Cells["txtDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDesignation"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegionID", dgvRow.Cells["txtRegion"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegion"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView();
                    }

                    else
                    //update operation
                    {
                        sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgvRow.Cells["txtUserID"].Value));
                        sqlCmd.Parameters.AddWithValue("@FirstName", dgvRow.Cells["txtFirstName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFirstName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@LastName", dgvRow.Cells["txtLastName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtLastName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@IDNumber", dgvRow.Cells["txtIDNumber"].Value == DBNull.Value ? "" : dgvRow.Cells["txtIDNumber"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Password", dgvRow.Cells["txtPassword"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPassword"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Username", dgvRow.Cells["txtUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["txtUsername"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DesignationID", dgvRow.Cells["txtDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDesignation"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegionID", dgvRow.Cells["txtRegion"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegion"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView();
                    }
                }
                
            }

        }

        private void dgvEmployee_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           if (e.Exception.Message == " Input string was not in a correct format.")
            {
               object value = dgvEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
             
                   e.ThrowException = false;
                
           }
        }

        private void dgvEmployee_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= AllowNumbersOnly; //avoids the already binded textbox keypress event
            if (dgvEmployee.CurrentCell.ColumnIndex == 3)// Allows only numbers into the ID Number cell
            {
               
                e.Control.KeyPress += AllowNumbersOnly; //Adds keypress event into the textbox
            }
        }

        //allow numbers and control keys only during editting
        private void AllowNumbersOnly(Object sender,KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgvEmployee_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvEmployee.CurrentRow.Cells["txtUserID"].Value != DBNull.Value)

                //Deletes only if the user confirms by pressing "Yes"
            {
                if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("EmployeeDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgvEmployee.CurrentRow.Cells["txtUserID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Deleted.");
                }
                //  Blocks the default delete operation
                else
                    e.Cancel = true;
            }
           
            else
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (SqlConnection sqlCon = new SqlConnection(connectionString))
            //{
            //    sqlCon.Open();
            //    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM UserRegister", sqlCon);
            //    DataTable dtbl = new DataTable();
            //    sqlDa.Fill(dtbl);
            //    dgvEmployee.DataSource = dtbl;
            //}
            //label1.Text = "Update Staff Details";
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails sd = new StaffDetails(label2.Text);
            sd.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
            PopulateDataGridView();
            MessageBox.Show("Update success");
        }
    }
}
