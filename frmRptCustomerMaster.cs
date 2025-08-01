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
    public partial class frmRptCustomerMaster : Form
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmRptCustomerMaster()
        {
            InitializeComponent();
        }

        private void txtOwnerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRptCustomerMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PetrolPumpDbDataSet30.TblCustomerMaster' table. You can move, or remove it, as needed.
            this.TblCustomerMasterTableAdapter.Fill(this.PetrolPumpDbDataSet30.TblCustomerMaster);

           // this.reportViewer1.RefreshReport();
        }
        private void GetReport()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblCustomermaster where FirmName = @FirmName AND OwnerName = @OwnerName order by CustomerCode" , con);
            da.SelectCommand.Parameters.AddWithValue("@FirmName", txtFirmName.Text);
            da.SelectCommand.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
            this.PetrolPumpDbDataSet30.TblCustomerMaster.Clear();
            da.Fill(this.PetrolPumpDbDataSet30.TblCustomerMaster);
            this.reportViewer1.RefreshReport();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}
