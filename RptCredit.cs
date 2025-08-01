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
    public partial class frmRptCredit : Form
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public frmRptCredit()
        {
            InitializeComponent();
        }

        private void frmRptCredit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PetrolPumpDbDataSet28.TblCreditSale' table. You can move, or remove it, as needed.
            this.TblCreditSaleTableAdapter.Fill(this.PetrolPumpDbDataSet28.TblCreditSale);

            //this.reportViewer1.RefreshReport();
        }
        private void GetReport()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblCreditSale where EntryDate between @FromDate AND @ToDate order by EntryDate", con);
            da.SelectCommand.Parameters.AddWithValue("@FromDate", FromdateTimePicker.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@ToDate", TodateTimePicker2.Value.Date);
            this.PetrolPumpDbDataSet28.TblCreditSale.Clear();
            da.Fill(this.PetrolPumpDbDataSet28.TblCreditSale);
            this.reportViewer1.RefreshReport();

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}
