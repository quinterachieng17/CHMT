﻿using System;
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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        
            
            {

            SqlConnection con = new SqlConnection("Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from StaffRegister where username='" + txtboxUsername.Text + "' and password = '" + txtboxPassword.Text + "'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if(dt.Rows.Count > 0)
            {
                for(int i =0; i<dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["DesignationID"].ToString() == cmbItemValue)
                    {
                       MessageBox.Show("you are login as a " + dt.Rows[i][6], "Login");
                        if (comboBox1.SelectedIndex == 0)
                        {
                            this.Hide();
                            Doctor ss = new Doctor();
                            ss.Show();
                        }
                        else if(comboBox1.SelectedIndex ==1)
                        {
                            this.Hide();
                            Nurse ss = new Nurse();
                            ss.Show();
                        }
                        /*else if(comboBox1.SelectedIndex ==2)
                        {
                            this.Hide();
                            Driver ss = new Driver();
                            ss.Show();
                        }*/
                        
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("error: Check login details","Error Message");

            }
       }
            
        

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)    
        {
            this.Hide();
            SignUp ss = new SignUp();
            ss.Show();
        }

    }

}
