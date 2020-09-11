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
    public partial class Referrals : Form
    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";

        public Referrals()
        {
            InitializeComponent();
        }

        public Referrals(string username)
        {
            InitializeComponent();
            label5.Text = username;
        }
        //dtbl is used as global variable
        DataTable dtbl;

        //Dialog Box Custom
        static Referrals MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string  Caption, string btnDownload, string btnCancel)
        {
            MsgBox = new Referrals();
            MsgBox.label1.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnDownload.Text = btnDownload;
            MsgBox.ShowDialog();
            return result;

        }

        private void Referrals_Load(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM PatientRegisterApproved", sqlCon);
                dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                // Displays only the selected columns
                dgvSpecificSearch.AutoGenerateColumns = false;
                dgvSpecificSearch.DataSource = dtbl;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Filtering data using PatientNo
            DataView DV = new DataView(dtbl);
            DV.RowFilter = string.Format("PatientNo LIKE '%{0}'", txtPatientNo.Text);
            dgvSpecificSearch.DataSource = DV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            //Print Operation goes here
            if (txtPatientNo.Text == "")
            {
                MessageBox.Show("Please Enter Patient Number to find patient details to print."); 
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
