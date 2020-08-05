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
    public partial class AccountInfo : Form
    {
        public AccountInfo()
        {
            InitializeComponent();
        }

        public AccountInfo(string username)
        {
            InitializeComponent();
            label2.Text = username;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cmbloginDataSet36.StaffRegister' table. You can move, or remove it, as needed.
            this.staffRegisterTableAdapter.Fill(this.cmbloginDataSet36.StaffRegister);
            // TODO: This line of code loads data into the 'cmbloginDataSet35.UserRegister' table. You can move, or remove it, as needed.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor cs = new Doctor(label2.Text);
            cs.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to reset this account!");
        }
    }
}
