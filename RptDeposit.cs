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
    public partial class frmRptDeposit : Form
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmRptDeposit()
        {
            InitializeComponent();
        }

        private void RptDeposit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PetrolPumpDbDataSet26.TblDepositEntry' table. You can move, or remove it, as needed.
            this.TblDepositEntryTableAdapter.Fill(this.PetrolPumpDbDataSet26.TblDepositEntry);
            
           // this.reportViewer1.RefreshReport();
        }
        private void GetReport()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblDepositEntry where DepositDate between @FromDate AND @ToDate order by Depositdate ", con);
            da.SelectCommand.Parameters.AddWithValue("@FromDate", FromdateTimePicker.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@ToDate", TodateTimePicker2.Value.Date);
            this.PetrolPumpDbDataSet26.TblDepositEntry.Clear();
            da.Fill(this.PetrolPumpDbDataSet26.TblDepositEntry);
            this.reportViewer1.RefreshReport();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}
