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
using System.Windows.Forms.DataVisualization.Charting;


namespace PetrolPumpManagement
{
    public partial class frmDashboard : Form
    {
        string c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmDashboard()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }
        private void LoadDepositChart()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("Select DepositDate,SUM(NetPaid)AS TotalDeposit from TblDepositEntry where DATEPART(WEEK,DepositDate) = DATEPART(WEEK,GETDATE()) AND YEAR(DepositDate) = YEAR(GETDATE()) group by DepositDate ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chartDeposit.Series.Clear();
            Series series = new Series("Deposit");
            series.ChartType = SeriesChartType.Column;
            chartDeposit.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(Convert.ToDateTime(row["DepositDate"]).ToShortDateString(), Convert.ToDouble(row["TotalDeposit"]));
            }

            chartDeposit.ChartAreas[0].AxisX.Title = "Date";
            chartDeposit.ChartAreas[0].AxisY.Title = "Total Deposit" + "\u20B9";
        }
 
        private void LoadExpenseChart()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("Select ExpenseDate,SUM(Amount)AS TotalExpense From TblExpenseEntry where DATEPART(WEEK, ExpenseDate)=DATEPART(WEEK, GETDATE()) AND YEAR(ExpenseDate)=YEAR(GETDATE()) group by ExpenseDate", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            ChartExpense.Series.Clear();
            Series series = new Series("Expense");
            series.ChartType = SeriesChartType.Line;
            ChartExpense.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(Convert.ToDateTime(row["ExpenseDate"]).ToShortDateString(), Convert.ToDouble(row["TotalExpense"]));
            }
            ChartExpense.ChartAreas[0].AxisX.Title = "Date";
            ChartExpense.ChartAreas[0].AxisY.Title = "Total Expense" + "\u20B9";
        }
        private void LoadCreditSaleChart()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("Select FuelType,SUM(Amount) AS TotalSales From TblCreditSale where DATEPART(WEEK,EntryDate)  = DATEPART(WEEK,GETDATE()) AND YEAR(EntryDate) = YEAR(GETDATE()) group by EntryDate,FuelType", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            chartCreditSale.Series.Clear();
            Series series = new Series("Fuel Sales");
            series.ChartType = SeriesChartType.Pie;
            chartCreditSale.Series.Add(series);

            foreach (DataRow row in dt.Rows)
	        {
 		      series.Points.AddXY(row["FuelType"].ToString(),Convert.ToDouble(row["TotalSales"]));
	        }
            chartCreditSale.ChartAreas[0].AxisX.Title = "Fuel Type";
            chartCreditSale.ChartAreas[0].AxisY.Title = "Total Sales" + "\u20B9";
            chartCreditSale.Legends[0].Enabled = true;
        }

        
        private void LoadTodaysRates()
        {
            try
            {

                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select Petrol,Diesel,CNG,XtraPremium from TblTodaysRate where TDate = Convert(Date,GETDATE())", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lblPetrolRate.Text = "\u20B9" + Convert.ToDecimal(dt.Rows[0]["Petrol"]).ToString();
                    lblDieselRate.Text = "\u20B9" + Convert.ToDecimal(dt.Rows[0]["Diesel"]).ToString();
                    lblCNGRate.Text = "\u20B9" + Convert.ToDecimal(dt.Rows[0]["CNG"]).ToString();
                    lblXtraPrmiumRate.Text = "\u20B9" + Convert.ToDecimal(dt.Rows[0]["XtraPremium"]).ToString();
                }
                else
                {
                    lblPetrolRate.Text = "\u20B9" + "0.00";
                    lblDieselRate.Text = "\u20B9" + "0.00";
                    lblCNGRate.Text = "\u20B9" + "0.00";
                    lblXtraPrmiumRate.Text = "\u20B9" + "0.00";

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

       private void frmDashboard_Load(object sender, EventArgs e)
        {
            LoadTodaysRates();
            LoadExpenseChart();
            LoadDepositChart();
            LoadCreditSaleChart();
           
            
        }

       private void frmDashboard_Activated(object sender, EventArgs e)
       {
           LoadTodaysRates();
           LoadExpenseChart();
           LoadDepositChart();
           LoadCreditSaleChart();
        
       }

       private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
       {

       }

       private void panel3_Paint(object sender, PaintEventArgs e)
       {

       }

       private void lblCNGTitle_Click(object sender, EventArgs e)
       {

       }

       private void lblDieselTitle_Click(object sender, EventArgs e)
       {

       }

       private void pnlPetrol_MouseClick(object sender, MouseEventArgs e)
       {
         
       }

       private void pnlPetrol_MouseLeave(object sender, EventArgs e)
       {
           pnlPetrol.BackColor = Color.White;
       }

       private void pnlPetrol_MouseEnter(object sender, EventArgs e)
       {
           pnlPetrol.BackColor = Color.WhiteSmoke;
          
       }

       private void pnlDiesel_MouseEnter(object sender, EventArgs e)
       {
           pnlDiesel.BackColor = Color.WhiteSmoke;
       }

       private void pnlCNG_MouseEnter(object sender, EventArgs e)
       {
           pnlCNG.BackColor = Color.WhiteSmoke;
       }

       private void pnlXtraPremium_MouseEnter(object sender, EventArgs e)
       {
           pnlXtraPremium.BackColor = Color.WhiteSmoke;
       }

       private void pnlXtraPremium_MouseLeave(object sender, EventArgs e)
       {
           pnlXtraPremium.BackColor = Color.White;
       }

       private void pnlCNG_MouseLeave(object sender, EventArgs e)
       {
           pnlCNG.BackColor = Color.White;
       }

       private void pnlDiesel_MouseLeave(object sender, EventArgs e)
       {
           pnlDiesel.BackColor = Color.White;
       }

       private void lblXtraPrmiumRate_Click(object sender, EventArgs e)
       {

       }

       private void panel2_Paint(object sender, PaintEventArgs e)
       {

       }

       private void label1_Click_1(object sender, EventArgs e)
       {

       }

       private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
       {

       }

       private void Expense_Click(object sender, EventArgs e)
       {
            
       }

       private void panel1_Paint(object sender, PaintEventArgs e)
       {

       }

       private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
       {

       }

       private void chartDeposit_Click(object sender, EventArgs e)
       {

       }

    

       private void ChartExpense_MouseEnter(object sender, EventArgs e)
       {
        
       }

     /*  private void frmDashboard_MouseEnter(object sender, EventArgs e)
       {
           
       }

       private void frmDashboard_MouseLeave(object sender, EventArgs e)
       {
          
       }*/
       
    }
}
