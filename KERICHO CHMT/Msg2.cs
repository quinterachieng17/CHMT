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
    public partial class Msg2 : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public Msg2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbPatientNo.Text == "" || txtArrivalTime.Text == "" || txtCommentsDelays.Text == "")
                MessageBox.Show("These fields are Mandatory");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("CommentsAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@PatientID", 0);
                    sqlCmd.Parameters.AddWithValue("@PatientNo", cmbPatientNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Arrivaltime", txtArrivalTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CommentsDelays", txtCommentsDelays.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Details added");
                    Clear();
                }
            }
        }
        void Clear()
        {
            cmbPatientNo.Text = txtArrivalTime.Text = txtCommentsDelays.Text = "";

        }

        private void Msg2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet10.ReferralRegister' table. You can move, or remove it, as needed.
            this.referralRegisterTableAdapter.Fill(this.cmbloginDataSet10.ReferralRegister);

        }
    }
}
