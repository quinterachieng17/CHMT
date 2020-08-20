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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
        }

        public Accounts(string username)
        {
            InitializeComponent();
            label7.Text = username;
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            label7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doctor doc = new Doctor(label7.Text);
            doc.Show();
        }
    }
}
