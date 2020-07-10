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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        public Reports(string username)
        {
            InitializeComponent();
            label2.Text = username;
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApprovedReferralReport rr = new ApprovedReferralReport();
            rr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApprovedTransferReport tr = new ApprovedTransferReport();
            tr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiefNurse cn = new ChiefNurse();
            cn.ShowDialog();
        }
    }
}
