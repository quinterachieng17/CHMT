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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports rr = new Reports();
            rr.ShowDialog();
        }

        private void ApprovedTransferReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet7.ReferralRegisterApproved' table. You can move, or remove it, as needed.
            this.referralRegisterApprovedTableAdapter.Fill(this.cmbloginDataSet7.ReferralRegisterApproved);

        }
    }
}
