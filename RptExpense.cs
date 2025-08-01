using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetrolPumpManagement
{
    public partial class frmRptExpense : Form
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public frmRptExpense()
        {
            InitializeComponent();
        }

        private void frmRptExpense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PetrolPumpDbDataSet29.TblExpenseEntry' table. You can move, or remove it, as needed.
            this.TblExpenseEntryTableAdapter.Fill(this.PetrolPumpDbDataSet29.TblExpenseEntry);

           // this.reportViewer1.RefreshReport();
        }
        private void GetReport()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblExpenseEntry where ExpenseDate between @FromDate AND @ToDate order by ExpenseDate", con);
            da.SelectCommand.Parameters.AddWithValue("@FromDate", FromdateTimePicker.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@ToDate", TodateTimePicker2.Value.Date);
            this.PetrolPumpDbDataSet29.TblExpenseEntry.Clear();
            da.Fill(this.PetrolPumpDbDataSet29.TblExpenseEntry);
            this.reportViewer1.RefreshReport();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}
