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
    public partial class frmChangePassword : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private string currentUser;
        
        public frmChangePassword(string txtUsername)
        {
            InitializeComponent();
            currentUser = txtUsername;
        }
        private void ClearAll()
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("select Password from TblSignup where FirstName='"+txtUsername.Text+"' and Password ='" + txtOldPassword.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count.ToString() == "1")
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update TblSignup set Password = '" + txtNewPassword.Text + "' where FirstName ='"+txtUsername.Text+"' and Password ='"+txtOldPassword.Text+"'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Password Updated Successfully");
                }
                else
                {
                    MessageBox.Show("New Password And Confirm Password Should be Same");
                }
            }

            else
            {
                MessageBox.Show("Check Your Old Password");
            }
            ClearAll();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = currentUser;
            txtUsername.ReadOnly = true;
        }

        private void txtNewPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length != 8)
            {
                MessageBox.Show("Password must be at least 8 characters long !!");
            }
        }
        bool isPasswordVisible = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = ! isPasswordVisible;
            txtOldPassword.PasswordChar = isPasswordVisible ? '\0' : '*';

            if (ShowOldPass.BackColor == Color.Teal)
            {
                ShowOldPass.BackColor = Color.Transparent;
            }
            else
            {
                ShowOldPass.BackColor = Color.Teal;
            }
        }
        bool isPasswordShow = false;
        private void ShowNewPass_Click(object sender, EventArgs e)
        {
            isPasswordShow = !isPasswordShow;
            txtNewPassword.PasswordChar = isPasswordShow ? '\0' : '*';

            if (ShowNewPass.BackColor == Color.Teal)
            {
                ShowNewPass.BackColor = Color.Transparent; 
            }
            else
            {
                ShowNewPass.BackColor = Color.Teal;
            }
        }
    }
}
