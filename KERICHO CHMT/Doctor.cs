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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        //Parsing username to the next page
        public Doctor(string cmb)
        {
            InitializeComponent();
            label2.Text = cmb;            
        }
      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords(label2.Text);
            ss.Show();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register(label2.Text);
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN ss = new LOGIN();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VehicleRegistration ss = new VehicleRegistration(label2.Text);
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkTicketSummary ss = new WorkTicketSummary(label2.Text);
            ss.Show();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            //To read system time
            label1.Text = DateTime.Now.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ss = new EditVehicle(label2.Text);
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails(label2.Text);
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords(label2.Text);
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Hide();
            Driver ss = new Driver(label2.Text);
            ss.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.Hide();
            Nurse nn = new Nurse(label2.Text);
            nn.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountInfo cs = new AccountInfo(label2.Text);
            cs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
