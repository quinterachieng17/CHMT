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
            if (cmbPatientNo.Text != null || txtArrivalTime.Text != null || txtCommentsDelays.Text != null)
            {


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("CommentsAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@PatientID", 0);
                    sqlCmd.Parameters.AddWithValue("@PatientNo", txtArrivalTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Arrivaltime", txtArrivalTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CommentsDelays", txtCommentsDelays.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Details added");

                }
            }
            else
            {
                MessageBox.Show("These fields are Mandatory");
            }
        }
    }
}
