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
    public partial class ApprovedTransferReport : Form
    {
        public ApprovedTransferReport()
        {
            InitializeComponent();
        }

        public ApprovedTransferReport(string username)
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

        private void ApprovedTransferReport_Load(object sender, EventArgs e)
        {
            label3.Hide();
            // TODO: This line of code loads data into the 'cmbloginDataSet11.ReferralRegisterApproved' table. You can move, or remove it, as needed.
            this.referralRegisterApprovedTableAdapter1.Fill(this.cmbloginDataSet11.ReferralRegisterApproved);
            // TODO: This line of code loads data into the 'cmbloginDataSet7.ReferralRegisterApproved' table. You can move, or remove it, as needed.
            this.referralRegisterApprovedTableAdapter.Fill(this.cmbloginDataSet7.ReferralRegisterApproved);

        }
    }
}
