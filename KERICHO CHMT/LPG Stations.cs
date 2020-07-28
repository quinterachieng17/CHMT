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
    public partial class LPGStations : Form
    {
        public LPGStations()
        {
            InitializeComponent();
        }
        //Dialog Box Custom
        static LPGStations MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new LPGStations();
            MsgBox.lblStation.Text = Text;
            MsgBox.btnCancel.Text = btnCancel;
            MsgBox.btnOK.Text = btnOK;
            MsgBox.ShowDialog();
            return result;

        }

        private void LPGStations_Load(object sender, EventArgs e)
        {

        }
    }
}
