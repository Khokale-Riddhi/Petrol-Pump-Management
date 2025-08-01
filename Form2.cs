using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PetrolPumpManagement
{
    public partial class frmSignUp : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmSignUp()
        {
            InitializeComponent();
        }
        private void ClearAll()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMobileNo.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";

        }
        private bool Validator()
        {
            if (txtFirstName.Text==""||txtLastName.Text==""||txtEmail.Text==""||txtMobileNo.Text==""||txtPassword.Text=="")
            {
                return false;
            }
            return true;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                SqlConnection con = new SqlConnection(c);
                SqlCommand cmd = new SqlCommand("insert into TblSignup values(@i1,@i2,@i3,@i4,@i5)", con);
                cmd.Parameters.AddWithValue("@i1", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@i2", txtLastName.Text);
                cmd.Parameters.AddWithValue("@i3", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@i4", txtEmail.Text);
                cmd.Parameters.AddWithValue("@i5", txtPassword.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Signup Successful! Please log in.");
                ClearAll(); 
            }
            else
            {
                MessageBox.Show("Fill the empty fields !!");
            }
           
            frmLogin obj = new frmLogin();
            obj.Show();
           
        }
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // frmLogin obj = new frmLogin();
            //obj.Show();
        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpSignUp_Enter(object sender, EventArgs e)
        {
           
        }

   /*     private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
        }*/

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length != 8)
            {
                MessageBox.Show("Password must be at least 8 characters long !!");
               
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (txtMobileNo.Text.Length != 10)
            {
                MessageBox.Show("Mobile number must be 10 digit !!");
               
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!email.Contains("@")||!email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address !!");
                
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }
        bool isPasswordVisible = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';

            if (Eyepass.BackColor==Color.Teal)
            {
                Eyepass.BackColor = Color.Transparent;
            }
            else
            {
                Eyepass.BackColor = Color.Teal;
            }
        }


    }



   
}

