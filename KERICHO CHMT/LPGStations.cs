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
    public partial class LPGStations : Form
    {

        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public LPGStations()
        {
            InitializeComponent();
        }

        public LPGStations(string username)
        {
            InitializeComponent();
            label4.Text = username;
        }
        //Dialog Box Custom
        static LPGStations MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new LPGStations();
            MsgBox.lblStation.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnOK;
            MsgBox.ShowDialog();
            return result;

        }

        private void LPGStations_Load(object sender, EventArgs e)
        {
            label4.Hide();
            dgv1.Show();
            lblStation.Show();
            reportViewerKipsigis.Hide();
            reportViewerHomeline.Hide();
            reportViewerJumbo.Hide();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Homelinelpg", sqlCon);
                SqlDataAdapter sqlDa2 = new SqlDataAdapter("SELECT * FROM Kipsigislpg", sqlCon);
                SqlDataAdapter sqlDa3 = new SqlDataAdapter("SELECT * FROM Jumbolpg", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                sqlDa2.Fill(dtbl);
                sqlDa3.Fill(dtbl);
                dgv1.DataSource = dtbl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblStation.Show();
            
            if (comboBox1.SelectedIndex == 0)
            {
                //lblStation.Text = "Jumbo Petrol Station";
                dgv1.Hide();
                reportViewerKipsigis.Hide();
                reportViewerHomeline.Hide();
                reportViewerJumbo.Show();
                this.AddByRegNoTableAdapter.Fill(this.cmbloginDataSet33.AddByRegNo,textBox1.Text);
                this.reportViewerJumbo.RefreshReport();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //lblStation.Text = "Kipsigis Petrol Station";
                dgv1.Hide();
                reportViewerJumbo.Hide();
                reportViewerHomeline.Hide();
                reportViewerKipsigis.Show();
                this.AddByRegNoKTableAdapter.Fill(this.cmbloginDataSet34.AddByRegNoK, textBox1.Text);
                this.reportViewerKipsigis.RefreshReport();

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                //lblStation.Text = "Homeline Petrol Station";
                dgv1.Hide();
                reportViewerKipsigis.Hide();
                reportViewerJumbo.Hide();
                reportViewerHomeline.Show();
                this.AddByRegNoHTableAdapter.Fill(this.cmbloginDataSet34.AddByRegNoH, textBox1.Text);
                this.reportViewerHomeline.RefreshReport();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                lblStation.Text = "All Filling Stations";
                dgv1.Show();
                reportViewerKipsigis.Hide();
                reportViewerJumbo.Hide();
                reportViewerHomeline.Hide();
                PopulateDataGridView();
            }
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rr = new Reports(label4.Text);
            rr.Show();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
