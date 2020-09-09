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
    public partial class SpecificSearch : Form

    {        public SpecificSearch()
        {
            InitializeComponent();
        }

        //Dialog Box Custom
        static SpecificSearch MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new SpecificSearch();
            MsgBox.label1.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnOK;
            MsgBox.ShowDialog();
            return result;       
        }

        private void SpecificSearch_Load(object sender, EventArgs e)
        {
      
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (cmbCase2.SelectedIndex == 0)
                {
                Referrals.Show("Enter Patient No.", "Search Patient Details", "Print", "Back"); MsgBox.Close();
            }
                else if (cmbCase2.SelectedIndex == 1)
                {
                    Transfers.Show("Enter Patient No.", "Search Patient Details", "Print", "Back"); MsgBox.Close();
            }            
                else
                {
                    MessageBox.Show("Please Select at least one Case to view");
                }
           
            
        }
       

        private void cmbCase2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }
    }
}
