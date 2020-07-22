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
    public partial class AddDataMsg : Form
    {
        public AddDataMsg()
        {
            InitializeComponent();
        }
        //Dialog Box Custom
        static AddDataMsg MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new AddDataMsg();
            MsgBox.label1.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnOK;
            MsgBox.ShowDialog();
            return result;

        }

        private void AddDataMsg_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // If incomming referral is selected to add arrival time and comments/Delays
            if (cmbCase.SelectedIndex == 0)
            {
                this.Hide();
                Msg1 msg = new Msg1();
                msg.ShowDialog();

            }

            // If incomming referral is selected to add arrival time and comments/Delays
            else if (cmbCase.SelectedIndex == 1)
            {
                this.Hide();
                Msg2 msg = new Msg2();
                msg.ShowDialog();

            }

            else
            {
                MessageBox.Show("Please Select at least one Case to add data");
            }
        }
    }
}
