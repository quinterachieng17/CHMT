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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rr = new Reports();
            rr.ShowDialog();
        }

        private void ApprovedReferralReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet6.PatientRegisterApproved' table. You can move, or remove it, as needed.
            this.patientRegisterApprovedTableAdapter.Fill(this.cmbloginDataSet6.PatientRegisterApproved);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
