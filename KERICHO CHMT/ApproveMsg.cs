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
    public partial class ApproveMsg : Form
    {
        public ApproveMsg()
        {
            InitializeComponent();
        }

        //Dialog Box Custom
        static ApproveMsg MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new ApproveMsg();
            MsgBox.label1.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnOK;
            MsgBox.ShowDialog();
            return result;

        }

        private void ApproveMsg_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbCase.SelectedIndex == 0)
            {
                
                ApproverReferrals.Show("KERICHO COUNTY REFERRAL HOSPITAL", "", "Approve", "Cancel"); MsgBox.Close();
                
            }
            else if (cmbCase.SelectedIndex == 1)
            {
                ApproveTransfers.Show("KERICHO COUNTY REFERRAL HOSPITAL", "", "Approve", "Cancel"); MsgBox.Close();
                              
            }
            else if (cmbCase.SelectedIndex == 2)
            {
                EditPatientDetails.Show("EDIT TRANSFERRED REFERRAL CASE FROM KERICHO COUNTY REFERRAL HOSPITAL", "", "Edit", "Cancel"); MsgBox.Close();

            }

            else
            {
                MessageBox.Show("Please Select at least one Case to view");
            }
        }
    }
}
