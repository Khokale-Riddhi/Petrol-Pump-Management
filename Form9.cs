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
    public partial class frmDepositEntry : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmDepositEntry()
        {
            InitializeComponent();
        }
        private bool Validator()
        {
            if (txtEntryCode.Text == "" || dateTimePickerDepositEntry.Text == "" || txtContactPerson.Text == "" || txtCustomerCode.Text == "" || txtNetCredit.Text == "" || txtNetPaid.Text == "" || txtNetBalance.Text == "" || txtNowPayingAmount.Text == "" || txtBalace.Text == "" || cmbPaymentMode.Text == "" || txtNote.Text == "" )
            {
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                try
                {
                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("insert into TblDepositEntry values (@i1,@i2,@i3,@i4,@i5,@i6,@i7,@i8,@i9,@i10,@i11)", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerDepositEntry.Value.Date);
                    cmd.Parameters.AddWithValue("@i3", txtContactPerson.Text);
                    cmd.Parameters.AddWithValue("@i4", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i5", txtNetCredit.Text);
                    cmd.Parameters.AddWithValue("@i6", txtNetPaid.Text);
                    cmd.Parameters.AddWithValue("@i7", txtNetBalance.Text);
                    cmd.Parameters.AddWithValue("@i8", txtNowPayingAmount.Text);
                    cmd.Parameters.AddWithValue("@i9", txtBalace.Text);
                    cmd.Parameters.AddWithValue("@i10", cmbPaymentMode.Text);
                    cmd.Parameters.AddWithValue("@i11", txtNote.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deposit Entries are successfully Saved");
                    AllClear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("All fields are mandatory !!");
            }

        }

        private void frmDepositEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet20.TblDepositEntry' table. You can move, or remove it, as needed.
            this.tblDepositEntryTableAdapter2.Fill(this.petrolPumpDbDataSet20.TblDepositEntry);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet9.TblDepositEntry' table. You can move, or remove it, as needed.
            //this.tblDepositEntryTableAdapter1.Fill(this.petrolPumpDbDataSet9.TblDepositEntry);

            
            AllClear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                try
                {
                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("update TblDepositEntry set DepositDate=@i2,ContactPerson=@i3,CustomerCode=@i4,NetCredit=@i5,NetPaid=@i6,NetBalance=@i7,NowPayingAmount=@i8,Balance=@i9,PaymentMode=@i10,Note=@i11 where EntryCode=@i1", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerDepositEntry.Value.Date);
                    cmd.Parameters.AddWithValue("@i3", txtContactPerson.Text);
                    cmd.Parameters.AddWithValue("@i4", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i5", txtNetCredit.Text);
                    cmd.Parameters.AddWithValue("@i6", txtNetPaid.Text);
                    cmd.Parameters.AddWithValue("@i7", txtNetBalance.Text);
                    cmd.Parameters.AddWithValue("@i8", txtNowPayingAmount.Text);
                    cmd.Parameters.AddWithValue("@i9", txtBalace.Text);
                    cmd.Parameters.AddWithValue("@i10", cmbPaymentMode.Text);
                    cmd.Parameters.AddWithValue("@i11", txtNote.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deposit details are succesfully updated ");
                    AllClear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("All fields are mandatory !!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(c);
                SqlCommand cmd = new SqlCommand("delete from TblDepositEntry where EntryCode=@i1", con);
                cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deposit details are successfully deleted ");
                AllClear();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        private void AllClear()
        {
            txtEntryCode.Text = "";
            dateTimePickerDepositEntry.ResetText();
            txtContactPerson.Text = "";
            txtCustomerCode.Text = "";
            txtNetPaid.Text = "";
            txtNetCredit.Text = "";
            txtNetBalance.Text = "";
            txtNowPayingAmount.Text = "";
            txtBalace.Text = "";
            cmbPaymentMode.SelectedIndex = -1;
            txtNote.Text = "";


            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
            

            FillGrid();
            GenerateId();

        }
        private void FillGrid()
        {
            try
            {

                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblDepositEntry", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        private void GenerateId()
        {
            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select Max(EntryCode) as MaxId from TblDepositEntry", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxDepositCode = 0;
                if (dt.Rows[0]["MaxId"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxDepositCode = Convert.ToInt32(dt.Rows[0]["MaxId"]);
                }
                MaxDepositCode = MaxDepositCode + 1;
                txtEntryCode.Text = MaxDepositCode.ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtEntryCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dateTimePickerDepositEntry.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtContactPerson.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtCustomerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtNetCredit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtNetPaid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtNetBalance.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtNowPayingAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtBalace.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    cmbPaymentMode.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtNote.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

                    btnSave.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnClear.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void txtNowPayingAmount_TextChanged(object sender, EventArgs e)
        {
            //netbal
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpDepositEntry_Enter(object sender, EventArgs e)
        {

        }

        private void txtContactPerson_Leave(object sender, EventArgs e)
        {
            if (txtContactPerson.Text!= "")
            {

                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select CustomerCode from TblCustomerMaster where OwnerName = @i1", con);
                da.SelectCommand.Parameters.AddWithValue("@i1",txtContactPerson.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtCustomerCode.Text = dt.Rows[0][0].ToString();
                }
            }
            GetNetCredit();
            GetNetPaid();
            GetNetBalance();
        }
        private void GetNetCredit()
        {
            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("select isnull(SUM(Amount),0) as NetCredit from TblCreditSale where CustomerCode=@i1",con);
            da.SelectCommand.Parameters.AddWithValue("@i1",txtCustomerCode.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtNetCredit.Text = dt.Rows[0][0].ToString();

        }

        private void GetNetPaid()
        {

            SqlConnection con = new SqlConnection(c);
            SqlDataAdapter da = new SqlDataAdapter("select isnull(SUM(NowPayingAmount),0) as NetPaid from TblDepositEntry where CustomerCode=@i1", con);
            da.SelectCommand.Parameters.AddWithValue("@i1", txtCustomerCode.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtNetPaid.Text = dt.Rows[0][0].ToString();
            
        }
        private void GetNetBalance()
        {
            
            double NetBalance, NetPaid, NetCredit = 0;
            NetPaid = Convert.ToDouble(txtNetPaid.Text);
            NetCredit = Convert.ToDouble(txtNetCredit.Text);
            NetBalance = NetCredit - NetPaid;
            txtNetBalance.Text = NetBalance.ToString();
            
        }

        private void txtNetCredit_Leave(object sender, EventArgs e)
        {

        }


        private void txtNowPayingAmount_Leave(object sender, EventArgs e)
        {
            if (txtNowPayingAmount.Text != "")
            {
                //balance = netbalance-nowpaying
                double NetBalance, NowPayingAmount, Balance = 0;
                NetBalance = Convert.ToDouble(txtNetBalance.Text);
                NowPayingAmount = Convert.ToDouble(txtNowPayingAmount.Text);
                Balance = NetBalance - NowPayingAmount;
                txtBalace.Text = Balance.ToString(); 
            }
            
        }
    }
}
