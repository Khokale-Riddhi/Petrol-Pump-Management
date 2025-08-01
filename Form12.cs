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
using CrystalDecisions.CrystalReports.Engine;

namespace PetrolPumpManagement
{
    public partial class RptCreditSale : Form
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public RptCreditSale()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        private void GetReport()
        {
            SqlConnection con = new SqlConnection(c);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("Select EntryCode,EntryDate,EmployeeName,EmployeeCode,FirmName,CustomerCode,VehicleNo,MPD,Nozzle,FuelType,TodaysRate,Amount,Litres,Note from TblCreditSale where CustomerCode = @i1", con);
            da.SelectCommand.Parameters.AddWithValue("@i1", txtCustomerCode.Text);
            da.Fill(ds,"TblCreditSale");

            ReportDocument cryrpt = new ReportDocument();
            cryrpt.Load(@"C:\Users\abc\documents\visual studio 2013\Projects\PetrolPumpManagement\PetrolPumpManagement\CreditSaleCrystalReport.rpt");
            cryrpt.Database.Tables["TblCreditSale"].SetDataSource(ds);
            crystalReportViewer1.ReportSource = cryrpt;
            crystalReportViewer1.RefreshReport();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}
