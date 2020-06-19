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
        
        //Dialog Box Custom
        static Referrals MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string  Caption, string btnOk, string btnCancel)
        {
            MsgBox = new Referrals();
            MsgBox.label1.Text = Text;
            MsgBox.button1.Text = btnCancel;
            MsgBox.button2.Text = btnOk;
            MsgBox.ShowDialog();
            return result;

        }

        private void Referrals_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Search Operation goes here
            result = DialogResult.Yes; MsgBox.Close();

        }
    }
}
