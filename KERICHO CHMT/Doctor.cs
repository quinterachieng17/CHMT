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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords();
            ss.Show();
        }

        private void btnRegisterStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register();
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
            VehicleRegistration ss = new VehicleRegistration();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
           TrackRecords ss = new TrackRecords();
            ss.Show();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditVehicle ss = new EditVehicle();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffDetails ss = new StaffDetails();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrackRecords ss = new TrackRecords();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.Hide();
            Driver ss = new Driver();
            ss.Show();
        }
    }
}
