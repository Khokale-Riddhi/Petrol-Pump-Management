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
    public partial class frmLogin : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void AllClear()
        {
            txtName.Text = "";
            txtPassword.Text = "";

        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            {

                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("select * from TblSignup where FirstName = '" + txtName.Text + "' and Password = '" + txtPassword.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {


                    Home obj = new Home();
                    obj.CurrentUsername = txtName.Text;
                    obj.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
                AllClear();
                
            }
         
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

       /* private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp obj = new frmSignUp();
            obj.Show();
        }*/

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length != 8)
            {
                MessageBox.Show("Password must be at least 8 characters long !!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
       


        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // show Password
        bool isPasswordVisible = false;
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';

            if (pictureBox2.BackColor==Color.Teal)
            {
                pictureBox2.BackColor = Color.Transparent;
            }
            else
            {
                pictureBox2.BackColor = Color.Teal;
            }
        }
    }
}
