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
    public partial class LOGIN : Form
    {
        int attempt = 1;
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
            //
            if (txtboxUsername.Text == "" || txtboxPassword.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Login Details cannot be blank");
            }
            //

            if (attempt < 4)
            {

                SqlConnection con = new SqlConnection("Data Source=WIN-O8HG7K9J35G;Initial Catalog=cmblogin;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from StaffRegister where username='" + txtboxUsername.Text + "' and password = '" + txtboxPassword.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string cmbItemValue = comboBox1.SelectedItem?.ToString();
               
                 if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["DesignationID"].ToString() == cmbItemValue)
                        {
                            MessageBox.Show("You are login as a " + dt.Rows[i][6], "LOGIN");
                            if (comboBox1.SelectedIndex == 0)
                            {
                                this.Hide();
                                Doctor ss = new Doctor(comboBox1.Text);
                                ss.ShowDialog();
                            }
                            else if (comboBox1.SelectedIndex == 1)
                            {
                                
                                this.Hide();
                                Nurse ss = new Nurse(comboBox1.Text);
                                ss.Show();
                            }
  
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Try again. " + attempt, "Information", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
                }
            }else if(attempt ==4)
            {
                MessageBox.Show("Login attempts exceeded");
                txtboxUsername.Enabled = false;
                txtboxPassword.Enabled = false;
                this.Close();
            }
            attempt ++;
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

        private void txtboxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
