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
        public Reports(string username)
        {
            InitializeComponent();
            label2.Text = username;
        }

        private void Reports_Load(object sender, EventArgs e)
        {    
            reportViewer1.Show();
            reportViewer2.Hide();
            reportViewer3.Hide();
                                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApprovedReferralReport rr = new ApprovedReferralReport(label2.Text);
            rr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApprovedTransferReport tr = new ApprovedTransferReport();
            tr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Nurse")
            {
                this.Hide();
                Nurse cn = new Nurse(label2.Text);
                cn.ShowDialog();
            }
            else if (label2.Text == "Chief Nurse")
            {
                this.Hide();
                ChiefNurse cn = new ChiefNurse(label2.Text);
                cn.ShowDialog();
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Loads report per Facility on clicking report by cases
            if (lblFacility.Text == "Facility")
                this.AddByFacilityTableAdapter.Fill(this.cmbloginDataSet19.AddByFacility, textBox1.Text);
                this.reportViewer1.RefreshReport();
            //Loads report per Nurses on clicking report by cases

            if (lblFacility.Text == "Nurses")
                this.AddByNursesTableAdapter.Fill(this.cmbloginDataSet16.AddByNurses, textBox1.Text);
                this.reportViewer2.RefreshReport();

            //Loads report per drivers on clicking report by cases
            if (lblFacility.Text == "Driver")            
                this.AddByDriversTableAdapter.Fill(this.cmbloginDataSet15.AddByDrivers, textBox1.Text);
                this.reportViewer3.RefreshReport();
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            lblFacility.Text = "Nurses";
            reportViewer1.Hide();
            reportViewer2.Show();
            reportViewer3.Hide();        
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            lblFacility.Text = "Facility";
            reportViewer1.Show();
            reportViewer2.Hide();
            reportViewer3.Hide();            
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            lblFacility.Text = "Driver";
            reportViewer1.Hide();
            reportViewer2.Hide();
            reportViewer3.Show();            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LPG.Show("Select LPG Station", "", "OK", "Cancel");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
