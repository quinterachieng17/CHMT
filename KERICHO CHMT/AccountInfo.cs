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
    public partial class AccountInfo : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public AccountInfo()
        {
            InitializeComponent();
        }

        public AccountInfo(string username)
        {
            InitializeComponent();
            label2.Text = username;
        }

        //void PopulateCombobox()
        //{
        //    using (SqlConnection sqlCon = new SqlConnection(connectionString))
        //    {
        //        sqlCon.Open();
        //        SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Designation", sqlCon);
        //        DataTable dtbl = new DataTable();
        //        sqlDa.Fill(dtbl);
        //        cbxDesignation.ValueMember = "DesignationID";
        //        cbxDesignation.DisplayMember = "Designation";
        //        //cbxRegion.ValueMember = "RegionID";
        //        //cbxRegion.DisplayMember = "Region";
        //        DataRow topItem = dtbl.NewRow();
        //        topItem[0] = 0;
        //        topItem[1] = "-Select";
        //        dtbl.Rows.InsertAt(topItem, 0);
        //        cbxDesignation.DataSource = dtbl;
        //        //cbxRegion.DataSource = dtbl;

        //    }
        //}
        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM StaffRegister", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            //PopulateCombobox();
            PopulateDataGridView();
            // TODO: This line of code loads data into the 'cmbloginDataSet36.StaffRegister' table. You can move, or remove it, as needed.
            //this.staffRegisterTableAdapter.Fill(this.cmbloginDataSet36.StaffRegister);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor cs = new Doctor(label2.Text);
            cs.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow != null)  //selects current row in focus
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    DataGridViewRow dgvRow = dataGridView1.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("StaffAddOrEdit", sqlCon); //Avoids sql injections
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    if (dgvRow.Cells["txtUserID"].Value == DBNull.Value)
                    {
                        sqlCmd.Parameters.AddWithValue("@UserID", 0);
                        sqlCmd.Parameters.AddWithValue("@FirstName", dgvRow.Cells["txtFirstName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFirstName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@LastName", dgvRow.Cells["txtLastName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtLastName"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@IDNumber", dgvRow.Cells["txtIDNumber"].Value == DBNull.Value ? "" : dgvRow.Cells["txtIDNumber"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Password", dgvRow.Cells["txtPassword"].Value == DBNull.Value ? "" : dgvRow.Cells["txtPassword"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@Username", dgvRow.Cells["txtUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["txtUsername"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@DesignationID", dgvRow.Cells["txtDesignationID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDesignationID"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegionID", dgvRow.Cells["txtRegionID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegionID"].Value.ToString());
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
                        sqlCmd.Parameters.AddWithValue("@DesignationID", dgvRow.Cells["txtDesignationID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDesignationID"].Value.ToString());
                        sqlCmd.Parameters.AddWithValue("@RegionID", dgvRow.Cells["txtRegionID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegionID"].Value.ToString());
                        sqlCmd.ExecuteNonQuery();
                        PopulateDataGridView();
                    }
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["txtUserID"].Value != DBNull.Value)

            //Deletes only if the user confirms by pressing "Yes"
            {
                if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("StaffDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dataGridView1.CurrentRow.Cells["txtUserID"].Value));
                        sqlCmd.ExecuteNonQuery();
                        sqlCon.Close();
                    }
                }
                //  Blocks the default delete operation
                else
                {
                    e.Cancel = true;
                }
                    
            }

            else
            {
                e.Cancel = true;
            }
                
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
