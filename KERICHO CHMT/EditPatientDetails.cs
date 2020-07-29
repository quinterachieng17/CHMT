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
    public partial class EditPatientDetails : Form
    {
        public EditPatientDetails()
        {
            InitializeComponent();
        }
        //Dialog Box Custom
        static EditPatientDetails MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnEdit, string btnCancel)
        {
            MsgBox = new EditPatientDetails();
            MsgBox.label1.Text = "EDIT TRANSFERRED REFERRAL CASE FROM KERICHO COUNTY REFERRAL HOSPITAL";
            MsgBox.label2.Text = "Patient No.";
            MsgBox.button1.Text = "Preview";
            MsgBox.button2.Text = "Incoming Referral";
            MsgBox.button3.Text = "Transferred Case";
            MsgBox.btnCancel.Text = "Cancel";
            MsgBox.btnEdit.Text = "Edit";
            MsgBox.ShowDialog();
            return result;

        }

        private void EditPatientDetails_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
