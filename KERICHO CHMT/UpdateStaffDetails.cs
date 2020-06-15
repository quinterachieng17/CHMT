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

        void PopulateDesignationComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Designation", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                //Binding combobox values to the datagridview combo

                cbxDesignation.ValueMember = "DesignationID";
                cbxDesignation.DisplayMember = "Designation";
                DataRow topItem = dtbl.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl.Rows.InsertAt(topItem, 0);
                cbxDesignation.DataSource = dtbl;
            }
        }

        void PopulateRegionComboBox()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Region", sqlCon);
                DataTable dtbl2 = new DataTable();
                sqlDa.Fill(dtbl2);
                cbxRegion.ValueMember = "RegionID";
                cbxRegion.DisplayMember = "Region";
                DataRow topItem = dtbl2.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                dtbl2.Rows.InsertAt(topItem, 0); 
                cbxRegion.DataSource = dtbl2;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateStaffDetails_Load(object sender, EventArgs e)
        {
            PopulateDesignationComboBox();
            PopulateRegionComboBox();
            PopulateDataGridView();


        }
       
        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StaffRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgvEmployee.DataSource = dtbl;
            }
        }
        //Update & Insert Operation
        private void dgvEmployee_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {  
            if (dgvEmployee.CurrentRow != null)  //selects current row in focus
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dgvEmployee.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("EmployeeAddOrEdit", sqlCon); //Avoids sql inections
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtUserID"].Value == DBNull.Value) //Insert operation
                        sqlCmd.Parameters.AddWithValue("@UserID", 0);
                    else 
                    //update operation
                    {
                        sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgvRow.Cells["txtUserID"].Value));
                        sqlCmd.Parameters.AddWithValue("@DesignationID", Convert.ToInt64(dgvRow.Cells["cbxDesignation"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxDesignation"].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@RegionID", Convert.ToInt64(dgvRow.Cells["cbxRegion"].Value == DBNull.Value ? "0" : dgvRow.Cells["cbxRegionID"].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@FirstName", dgvRow.Cells["txtFirstName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFirstName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@LastName", dgvRow.Cells["txtLastName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtLastName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@IDNumber", Convert.ToInt32(dgvRow.Cells["txtIDNumber"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtIDNumber"].Value.ToString()));
                        sqlCmd.Parameters.AddWithValue("@Username", dgvRow.Cells["txtUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["txtUsername"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Password", dgvRow.Cells["txtPassword"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPassword"].Value.ToString());
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
                }
                //  Blocks the default delete operation
                else
                    e.Cancel = true;
            }
           
            else
                e.Cancel = true;
        }

       
    }
}
