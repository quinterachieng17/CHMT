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
    public partial class VehicleRegistration : Form
    {
        String connectionString = @"Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True;";
        SqlConnection con = new SqlConnection("Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True");
        public VehicleRegistration()
        {
            InitializeComponent();
        }

        public VehicleRegistration(string username)
        {
            InitializeComponent();
            label11.Text = username;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("Select * from VehicleRegistration where RegNo = '" + txtRegNo + "'", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //if(dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("A Vehicle with registration No" + txtRegNo.Text+ "already exists");
            //}

             if (txtRegNo.Text == "" || txtMake.Text == "" || txtModel.Text == "" || txtChasisNo.Text == "" || txtEngineNo.Text == "" || txtPlateNo.Text == "" )
            {
                MessageBox.Show("All fields MUST be filled");
            }
            
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(connectionString))
                {
                    sqlcon.Open();
                    string fname = txtRegNo.Text + ".jpg";
                    string flocation = "C:\\Users\\User\\Desktop\\DHIS2";
                    string pathstring = System.IO.Path.Combine(flocation, fname);
                    SqlCommand sqlCmd = new SqlCommand("VehicleAdd", sqlcon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Make", txtMake.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ChasisNo", txtChasisNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@EngineNo", txtEngineNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PlateNo", txtPlateNo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@pic", pathstring);
                    Image a = pictureBox1.Image;
                    a.Save(pathstring);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("New Motor Vehicle Details Recorded Successfuly");
                    Clear();

                }
            }
        }
        void Clear()
        {
            txtRegNo.Text = txtMake.Text = txtModel.Text = txtChasisNo.Text = txtEngineNo.Text = txtPlateNo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Doctor ss = new Doctor(label11.Text);
            ss.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void VehicleRegistration_Load(object sender, EventArgs e)
        {
            label11.Hide();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            //label6.Text = DateTime.Now.ToLongDateString();
        }

        private void txtRegNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if(p != null)
            {
                op.Filter = "(*.jpg; *.jpeg; *.png)| *.jpg; *.jpeg; *.png";
                if(op.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(op.FileName);
                }
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
