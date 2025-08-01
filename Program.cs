using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PetrolPumpManagement
{
    static class Program
    {
       static String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        // to check user in database
        static bool IsUserExists()
        {
            
            SqlConnection con = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("Select Count(*) from TblSignUp", con);
            con.Open();
            int userCount = (int)cmd.ExecuteScalar();
            return userCount > 0;
           
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // check user exist or not
            if (IsUserExists())
            {
                Application.Run(new frmLogin()); //open login form if user exist
            }
            else
            {
                Application.Run(new frmSignUp()); //open Signup form if no users exist
            }

           
        }
    }
}
