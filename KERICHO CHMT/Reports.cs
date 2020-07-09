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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        public Reports(string lbl2)
        {
            InitializeComponent();
            label2.Text = lbl2;
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            if (label2.Text == "Chief Nurse")
            {
                button1.Hide();               
            }
            //
            if (label2.Text == "Nurse")
            {
                button3.Hide();
            }


            // TODO: This line of code loads data into the 'cmbloginDataSet2.CasesByHospital' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'cmbloginDataSet1.PatientRegister' table. You can move, or remove it, as needed.
            this.patientRegisterTableAdapter.Fill(this.cmbloginDataSet1.PatientRegister);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nurse nn = new Nurse(label2.Text);
            nn.ShowDialog();
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CasesByHospitalTableAdapter.Fill(this.cmbloginDataSet2.CasesByHospital,textBox1.Text);
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChiefNurse cn = new ChiefNurse(label2.Text);
            cn.ShowDialog();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            //this.CasesByHospitalTableAdapter.Fill(this.cmbloginDataSet2.CasesByHospital, textBox1.Text);
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
