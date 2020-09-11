using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace KERICHO_CHMT
{
    public partial class WorkTicketSummary : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public WorkTicketSummary()
        {
            InitializeComponent();
        }

        public WorkTicketSummary(string username)
        {
            InitializeComponent();
            label2.Text = username;
        }

        private void WorkTicketSummary_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            label2.Hide();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Jumbolpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Homelinelpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;

            }
            label4.Text = "Homeline Filling Station";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Kipsigislpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;

            }
            label4.Text = "Kipsigis Filling Station";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Jumbolpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
            }
            label4.Text = "Jumbo Filling Station";
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor dd = new Doctor(label2.Text);
            dd.Show();
        }


        void PopulateDataGridView()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Homelinelpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv2.DataSource = dtbl;
            }
        }

        void PopulateDataGridView2()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Kipsigislpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv2.DataSource = dtbl;
            }
        }
        void PopulateDataGridView3()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Jumbolpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dgv2.DataSource = dtbl;
            }
        }

        private void dgv2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Jumbo
            if (label4.Text == "Homeline Filling Station")
            {
                if (dgv2.CurrentRow != null)  //selects current row in focus
                {
                    //Insert Operation
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dgv2.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("HomelineAddOrEdit", sqlCon); //Avoids sql injections
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        if (dgvRow.Cells["txtUserID"].Value == DBNull.Value)
                        {
                            sqlCmd.Parameters.AddWithValue("@UserID", 0);
                            sqlCmd.Parameters.AddWithValue("@DriverID", dgvRow.Cells["txtDriverID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverID"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@MileageReading", dgvRow.Cells["txtMileageReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMileageReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", dgvRow.Cells["txtoilConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtoilConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgvRow.Cells["txtfuelConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtfuelConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Destination", dgvRow.Cells["txtDestination"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDestination"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@lpgStation", dgvRow.Cells["txtlpgStation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlpgStation"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@VoucherNo", dgvRow.Cells["txtVoucherNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtVoucherNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FinalSpeedReading", dgvRow.Cells["txtFinalSpeedReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFinalSpeedReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@journeyKilometer", dgvRow.Cells["txtjourneyKilometer"].Value == DBNull.Value ? "" : dgvRow.Cells["txtjourneyKilometer"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", dgvRow.Cells["txtAuthorizingOfficerName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerName"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", dgvRow.Cells["txtAuthorizingOfficerNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value.ToString());
                            sqlCmd.ExecuteNonQuery();
                            PopulateDataGridView();
                        }

                        else
                        //update operation
                        {
                            sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgvRow.Cells["txtUserID"].Value));
                            sqlCmd.Parameters.AddWithValue("@DriverID", dgvRow.Cells["txtDriverID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverID"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@MileageReading", dgvRow.Cells["txtMileageReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMileageReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", dgvRow.Cells["txtoilConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtoilConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgvRow.Cells["txtfuelConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtfuelConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Destination", dgvRow.Cells["txtDestination"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDestination"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@lpgStation", dgvRow.Cells["txtlpgStation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlpgStation"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@VoucherNo", dgvRow.Cells["txtVoucherNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtVoucherNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FinalSpeedReading", dgvRow.Cells["txtFinalSpeedReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFinalSpeedReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@journeyKilometer", dgvRow.Cells["txtjourneyKilometer"].Value == DBNull.Value ? "" : dgvRow.Cells["txtjourneyKilometer"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", dgvRow.Cells["txtAuthorizingOfficerName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerName"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", dgvRow.Cells["txtAuthorizingOfficerNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value.ToString());
                            sqlCmd.ExecuteNonQuery();
                            PopulateDataGridView();
                        }
                    }

                }
            }
            //Kipsigis
            else if (label4.Text == "Kipsigis Filling Station")
            {
                if (dgv2.CurrentRow != null)  //selects current row in focus
                {
                    //Insert Operation
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dgv2.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("KipsigisAddOrEdit", sqlCon); //Avoids sql injections
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        if (dgvRow.Cells["txtUserID"].Value == DBNull.Value)
                        {
                            sqlCmd.Parameters.AddWithValue("@UserID", 0);
                            sqlCmd.Parameters.AddWithValue("@DriverID", dgvRow.Cells["txtDriverID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverID"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@MileageReading", dgvRow.Cells["txtMileageReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMileageReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", dgvRow.Cells["txtoilConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtoilConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgvRow.Cells["txtfuelConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtfuelConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Destination", dgvRow.Cells["txtDestination"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDestination"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@lpgStation", dgvRow.Cells["txtlpgStation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlpgStation"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@VoucherNo", dgvRow.Cells["txtVoucherNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtVoucherNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FinalSpeedReading", dgvRow.Cells["txtFinalSpeedReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFinalSpeedReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@journeyKilometer", dgvRow.Cells["txtjourneyKilometer"].Value == DBNull.Value ? "" : dgvRow.Cells["txtjourneyKilometer"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", dgvRow.Cells["txtAuthorizingOfficerName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerName"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", dgvRow.Cells["txtAuthorizingOfficerNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value.ToString());
                            sqlCmd.ExecuteNonQuery();
                            PopulateDataGridView2();
                        }

                        else
                        //update operation
                        {
                            sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgvRow.Cells["txtUserID"].Value));
                            sqlCmd.Parameters.AddWithValue("@DriverID", dgvRow.Cells["txtDriverID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverID"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@MileageReading", dgvRow.Cells["txtMileageReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMileageReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", dgvRow.Cells["txtoilConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtoilConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgvRow.Cells["txtfuelConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtfuelConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Destination", dgvRow.Cells["txtDestination"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDestination"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@lpgStation", dgvRow.Cells["txtlpgStation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlpgStation"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@VoucherNo", dgvRow.Cells["txtVoucherNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtVoucherNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FinalSpeedReading", dgvRow.Cells["txtFinalSpeedReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFinalSpeedReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@journeyKilometer", dgvRow.Cells["txtjourneyKilometer"].Value == DBNull.Value ? "" : dgvRow.Cells["txtjourneyKilometer"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", dgvRow.Cells["txtAuthorizingOfficerName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerName"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", dgvRow.Cells["txtAuthorizingOfficerNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value.ToString());
                            sqlCmd.ExecuteNonQuery();
                            PopulateDataGridView2();
                        }
                    }

                }
            }
            //Jumbo
            if (label4.Text == "Jumbo Filling Station")
            {
                if (dgv2.CurrentRow != null)  //selects current row in focus
                {
                    //Insert Operation
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        DataGridViewRow dgvRow = dgv2.CurrentRow;
                        SqlCommand sqlCmd = new SqlCommand("JumboAddOrEdit", sqlCon); //Avoids sql injections
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        if (dgvRow.Cells["txtUserID"].Value == DBNull.Value)
                        {
                            sqlCmd.Parameters.AddWithValue("@UserID", 0);
                            sqlCmd.Parameters.AddWithValue("@DriverID", dgvRow.Cells["txtDriverID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverID"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@MileageReading", dgvRow.Cells["txtMileageReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMileageReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", dgvRow.Cells["txtoilConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtoilConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgvRow.Cells["txtfuelConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtfuelConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Destination", dgvRow.Cells["txtDestination"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDestination"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@lpgStation", dgvRow.Cells["txtlpgStation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlpgStation"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@VoucherNo", dgvRow.Cells["txtVoucherNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtVoucherNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FinalSpeedReading", dgvRow.Cells["txtFinalSpeedReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFinalSpeedReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@journeyKilometer", dgvRow.Cells["txtjourneyKilometer"].Value == DBNull.Value ? "" : dgvRow.Cells["txtjourneyKilometer"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", dgvRow.Cells["txtAuthorizingOfficerName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerName"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", dgvRow.Cells["txtAuthorizingOfficerNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value.ToString());
                            sqlCmd.ExecuteNonQuery();
                            PopulateDataGridView3();
                        }

                        else
                        //update operation
                        {
                            sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgvRow.Cells["txtUserID"].Value));
                            sqlCmd.Parameters.AddWithValue("@DriverID", dgvRow.Cells["txtDriverID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDriverID"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@RegNo", dgvRow.Cells["txtRegNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRegNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@MileageReading", dgvRow.Cells["txtMileageReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtMileageReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@OilDrawn", dgvRow.Cells["txtoilConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtoilConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FuelDrawn", dgvRow.Cells["txtfuelConsumed"].Value == DBNull.Value ? "" : dgvRow.Cells["txtfuelConsumed"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Destination", dgvRow.Cells["txtDestination"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDestination"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@lpgStation", dgvRow.Cells["txtlpgStation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtlpgStation"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@Date", dgvRow.Cells["txtDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDate"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@VoucherNo", dgvRow.Cells["txtVoucherNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtVoucherNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@FinalSpeedReading", dgvRow.Cells["txtFinalSpeedReading"].Value == DBNull.Value ? "" : dgvRow.Cells["txtFinalSpeedReading"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@journeyKilometer", dgvRow.Cells["txtjourneyKilometer"].Value == DBNull.Value ? "" : dgvRow.Cells["txtjourneyKilometer"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerName", dgvRow.Cells["txtAuthorizingOfficerName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerName"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerNo", dgvRow.Cells["txtAuthorizingOfficerNo"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerNo"].Value.ToString());
                            sqlCmd.Parameters.AddWithValue("@AuthorizingOfficerDesignation", dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAuthorizingOfficerDesignation"].Value.ToString());
                            sqlCmd.ExecuteNonQuery();
                            PopulateDataGridView3();
                        }
                    }

                }
            }
        }
        private void dgv2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
             //Deleting from Kipsigis table
            if (label4.Text == "Kipsigis Filling Station")
            {   
            if (dgv2.CurrentRow.Cells["txtUserID"].Value != DBNull.Value)

            //Deletes only if the user confirms by pressing "Yes"
            {
                if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("KipsigisDeleteByID", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgv2.CurrentRow.Cells["txtUserID"].Value));
                        sqlCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record Deleted.");
                }
                //  Blocks the default delete operation
                else
                    e.Cancel = true;
            }
        }

            //Deleting from Jumbo table
            else if (label4.Text == "Jumbo Filling Station")
            {
                if (dgv2.CurrentRow.Cells["txtUserID"].Value != DBNull.Value)

                //Deletes only if the user confirms by pressing "Yes"
                {
                    if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("JumboDeleteByID", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgv2.CurrentRow.Cells["txtUserID"].Value));
                            sqlCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Record Deleted.");
                    }
                    //  Blocks the default delete operation
                    else
                        e.Cancel = true;
                }
            }
            //Deleting from Homeline table
           else if (label4.Text == "Homeline Filling Station")
            {
                if (dgv2.CurrentRow.Cells["txtUserID"].Value != DBNull.Value)

                //Deletes only if the user confirms by pressing "Yes"
                {
                    if (MessageBox.Show("Are you sure to Delete this Record ?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection sqlCon = new SqlConnection(connectionString))
                        {
                            sqlCon.Open();
                            SqlCommand sqlCmd = new SqlCommand("HomelineDeleteByID", sqlCon);
                            sqlCmd.CommandType = CommandType.StoredProcedure;
                            sqlCmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(dgv2.CurrentRow.Cells["txtUserID"].Value));
                            sqlCmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Record Deleted.");
                    }
                    //  Blocks the default delete operation
                    else
                        e.Cancel = true;
                }
            }

            else
                e.Cancel = true;
        }

        //To export the dataGridView to pdf
        public void exportgridviewtopdf(DataGridView dgv2, string filename)
        {
            ////Report Header
            BaseFont head = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);
            Paragraph p = new Paragraph();
            p.Alignment = Element.ALIGN_CENTER;
            p.Add(new Chunk("KERICHO COUNTY REFERRAL HOSPITAL"));
            p.Add(new Chunk("\nP.O BOX 11 -20200 KERICHO"));
            p.Add(new Chunk("\nDate: " + DateTime.Now.ToShortDateString()));

            //Line Separation
            Paragraph pra = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 2)));
            p.Add(new Chunk("\n"));
            p.Add(new Chunk("\n"));
            p.Add(new Chunk("\n"));

            //Table Head
            Paragraph p2 = new Paragraph();
            p2.Alignment = Element.ALIGN_CENTER;
            p2.Add(new Chunk("Transport - Daily Work Ticket"));

            //Table Data
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable records = new PdfPTable(dgv2.Columns.Count);
            records.DefaultCell.Padding = 1;
            records.WidthPercentage = 100;
            PdfPCell cells = new PdfPCell();
            records.HorizontalAlignment = Element.ALIGN_LEFT;
            records.DefaultCell.BorderWidth = 1;


            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            //For header
            foreach (DataGridViewColumn column in dgv2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                records.AddCell(cell);

            }
            //Add datarow
            foreach (DataGridViewRow row in dgv2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    records.AddCell(new Phrase(cell.Value.ToString(), text));

                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";
            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(p);
                    pdfdoc.Add(pra);
                    pdfdoc.Add(p2);
                    pdfdoc.Add(new Chunk("\n"));
                    pdfdoc.Add(records);
                    pdfdoc.Close();
                    stream.Close();

                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            exportgridviewtopdf(dgv2, "Daily Work Ticket");
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //Filtering using the selected date range
        private void button13_Click(object sender, EventArgs e)
        {
            if(label4.Text == "Jumbo Filling Station")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Jumbolpg where Date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' And '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds,"Jumbolpg");
                    dgv2.DataSource = ds.Tables["Jumbolpg"];
                    sqlCon.Close();
                }
            }

            else if (label4.Text == "Kipsigis Filling Station")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Kipsigislpg where Date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' And '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds, "Kipsigislpg");
                    dgv2.DataSource = ds.Tables["Kipsigislpg"];
                    sqlCon.Close();
                }
                
            }
            else if (label4.Text == "Homeline Filling Station")
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Homelinelpg where Date between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "' And '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", sqlCon);
                    DataSet ds = new DataSet();
                    sqlDa.Fill(ds, "Homelinelpg");
                    dgv2.DataSource = ds.Tables["Homelinelpg"];
                    sqlCon.Close();
                }
                
            }
            else
            {

            }
            
            
        }
    }
}
