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
    public partial class frmRptEmployeemaster : Form
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmRptEmployeemaster()
        {
            InitializeComponent();
        }

        private void RptEmployeemaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PetrolPumpDbDataSet27.TblEmployeeMaster' table. You can move, or remove it, as needed.
            this.TblEmployeeMasterTableAdapter.Fill(this.PetrolPumpDbDataSet27.TblEmployeeMaster);

     

            //this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void GetReport()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("select * from TblEmployeeMaster where Name= @Name AND Designation = @Designation order by EmployeeCode ", con);
            da.SelectCommand.Parameters.AddWithValue("@Name", txtName.Text);
            da.SelectCommand.Parameters.AddWithValue("@Designation", cmbDesignation.Text);
            this.PetrolPumpDbDataSet27.TblEmployeeMaster.Clear();
            da.Fill(this.PetrolPumpDbDataSet27.TblEmployeeMaster);
            this.reportViewer1.RefreshReport();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            GetReport();
        }

        private void lblDesignation_Click(object sender, EventArgs e)
        {

        }
    }
}
