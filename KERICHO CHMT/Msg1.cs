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
    public partial class Msg1 : Form
    {
        public Msg1()
        {
            InitializeComponent();
        }
        
        //Dialog Box Custom
        static Msg1 MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnDownload, string btnCancel)
        {
            MsgBox = new Msg1();
            MsgBox.label1.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnDownload;
            MsgBox.ShowDialog();
            return result;

        }

        private void Msg1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbCase.SelectedIndex == 0)
            {
                AllCases.Show("ALL INCOMING REFERRAL CASES AT KERICHO COUNTY REFERRAL HOSPITAL", "All incoming Referral Cases", "Download", "Cancel"); MsgBox.Close();
            }
            else if(cmbCase.SelectedIndex == 1)
            {
                AllTransfers.Show("ALL TRANSFERRED REFERRAL CASES AT KERICHO COUNTY REFERRAL HOSPITAL", "All Outgoing Referral Cases", "Download", "Cancel"); MsgBox.Close();
            }

            else
            {
                MessageBox.Show("Please Select at least one Case to view");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
