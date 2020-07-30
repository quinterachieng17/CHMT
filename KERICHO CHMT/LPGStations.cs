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
            lblStation.Show();
            reportViewerKipsigis.Hide();
            reportViewerHomeline.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblStation.Text == "Jumbo Petrol Station")
            {
                reportViewerKipsigis.Hide();
                reportViewerHomeline.Hide();
                this.AddByRegNoTableAdapter.Fill(this.cmbloginDataSet33.AddByRegNo,textBox1.Text);
                this.reportViewerJumbo.RefreshReport();
            }
            else if (lblStation.Text == "Kipsigis Petrol Station")
            {
                reportViewerJumbo.Hide();
                reportViewerHomeline.Hide();
                this.AddByRegNoKTableAdapter.Fill(this.cmbloginDataSet34.AddByRegNoK,textBox1.Text);
                this.reportViewerKipsigis.RefreshReport();

            }
            else if (lblStation.Text == "Homeline Petrol Station")
            {
                reportViewerKipsigis.Hide();
                reportViewerJumbo.Hide();
                this.AddByRegNoHTableAdapter.Fill(this.cmbloginDataSet34.AddByRegNoH,textBox1.Text);
                this.reportViewerHomeline.RefreshReport();
            }
            else if (lblStation.Text == "All Filling Stations")
            {

            }
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
