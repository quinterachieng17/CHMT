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
    public partial class Msg1 : Form
    {
        // SqlConnection con = new SqlConnection(@"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True");
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public Msg1()
        {
            InitializeComponent();
        }
        
        //Dialog Box Custom
        static Msg1 MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOk, string btnCancel)
        {
            MsgBox = new Msg1();
            MsgBox.label4.Text = Text;
            MsgBox.label5.Text = Text;
            MsgBox.label6.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnOk;
            MsgBox.ShowDialog();
            return result;

        }

        private void Msg1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet8.PatientRegister' table. You can move, or remove it, as needed.
            this.patientRegisterTableAdapter.Fill(this.cmbloginDataSet8.PatientRegister);

        }

        //send to patientRegisterApprove and TransferRegisterApprove tables
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbPatientNo.Text == "" || txtArrivalTime.Text == "" || txtCommentsDelays.Text == "")           
                MessageBox.Show("These fields are Mandatory");
            
            else
            { 
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("ArrivalTimeAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@PatientID", 0);
                    sqlCmd.Parameters.AddWithValue("@PatientNo", cmbPatientNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Arrivaltime", txtArrivalTime.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CommentsDelays", txtCommentsDelays.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    sqlCon.Close();
                    MessageBox.Show("Details added");
                    Clear();                
                }
                
            }
           
          
        }
        void Clear()
        {
          cmbPatientNo.Text = txtArrivalTime.Text = txtCommentsDelays.Text =  "";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
