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
    public partial class SpecificSearch : Form

    {
        string connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True";
        public SpecificSearch()
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
                Referrals.Show("Enter Patient Number", "Search Patient Details", "Print", "Cancel"); MsgBox.Close();
            }
                else if (cmbCase2.SelectedIndex == 1)
                {
                    Transfers.Show("Enter Patient Number", "Search Patient Details", "Print", "Cancel"); MsgBox.Close();
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
