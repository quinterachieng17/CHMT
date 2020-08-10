using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KERICHO_CHMT
{
    public partial class ApprovedReferralReport : Form
    {
        public ApprovedReferralReport()
        {
            InitializeComponent();
        }

        public ApprovedReferralReport(string username)
        {
            InitializeComponent();
            label3.Text = username;
        }

    private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rr = new Reports(label3.Text);
            rr.ShowDialog();
        }

        private void ApprovedReferralReport_Load(object sender, EventArgs e)
        {
            label3.Hide();
            // TODO: This line of code loads data into the 'cmbloginDataSet9.PatientRegisterApproved' table. You can move, or remove it, as needed.
            this.patientRegisterApprovedTableAdapter1.Fill(this.cmbloginDataSet9.PatientRegisterApproved);
            // TODO: This line of code loads data into the 'cmbloginDataSet6.PatientRegisterApproved' table. You can move, or remove it, as needed.
            this.patientRegisterApprovedTableAdapter.Fill(this.cmbloginDataSet6.PatientRegisterApproved);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
