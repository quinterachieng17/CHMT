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
    public partial class ChiefNurse : Form
    {
        public ChiefNurse()
        {
            InitializeComponent();
        }
        public ChiefNurse(string username)
        {
            InitializeComponent();
            label1.Text = username;
        }

        private void ChiefNurse_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reports rr = new Reports(label1.Text);
            rr.ShowDialog();
        }
    }
}
