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
    public partial class LPG : Form
    {
        public LPG()
        {
            InitializeComponent();
        }
        //Dialog Box Custom
        static LPG MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new LPG();
            MsgBox.label1.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnOK;
            MsgBox.ShowDialog();
            return result;

        }

        private void LPG_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbLPG.SelectedIndex == 0)
            {
                LPGStations.Show("ALL AMBULANCES FUELING AT JUMBO  PETROL STATION", "", "Download", "Cancel"); MsgBox.Close();

            }
            else if (cmbLPG.SelectedIndex == 1)
            {
                LPGStations.Show("ALL AMBULANCES FUELING AT KIPSIGIS(TOTAL) PETROL STATION", "", "Download", "Cancel"); MsgBox.Close();
            }
            else if (cmbLPG.SelectedIndex == 2)
            {
                LPGStations.Show("ALL AMBULANCES FUELING AT HOTLINE PETROL STATION", "", "Download", "Cancel"); MsgBox.Close();
            }
            else if (cmbLPG.SelectedIndex == 3)
            {
                LPGStations.Show("ALL AMBULANCES AT KERICHO DISTRICT REFERRAL HOSPITAL", "", "Download", "Cancel"); MsgBox.Close();
            }

            else
            {
                MessageBox.Show("Please Select at least one Station to view");
            }
        }
    }
}
