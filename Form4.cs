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
    public partial class frmExpenseEntry : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmExpenseEntry()
        {
            InitializeComponent();
        }

        private void lblRemark_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(c);
            SqlCommand cmd = new SqlCommand("delete from TblExpenseEntry where EntryCode=@i1", con);
            cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Expense details are successfully deleted ");
            ClearAll();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmExpense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet23.TblExpenseEntry' table. You can move, or remove it, as needed.
            this.tblExpenseEntryTableAdapter2.Fill(this.petrolPumpDbDataSet23.TblExpenseEntry);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet16.TblExpenseEntry' table. You can move, or remove it, as needed.
          //  this.tblExpenseEntryTableAdapter1.Fill(this.petrolPumpDbDataSet16.TblExpenseEntry);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet.TblExpenseEntry' table. You can move, or remove it, as needed.
            //this.tblExpenseEntryTableAdapter.Fill(this.petrolPumpDbDataSet.TblExpenseEntry);
            ClearAll();

        }
        private bool Validator()
        {
            if (txtEntryCode.Text == "" || dateTimePickerExpense.Text == ""|| txtPaidTo.Text == "" || txtAmount.Text == "" || cmbPaymentMode.Text == "" || txtRemark.Text == "")
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                try
                {
                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("insert into TblExpenseEntry values(@i1,@i2,@i3,@i4,@i5,@i6)", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerExpense.Text);
                    cmd.Parameters.AddWithValue("@i3", txtPaidTo.Text);
                    cmd.Parameters.AddWithValue("@i4", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@i5", cmbPaymentMode.Text);
                    cmd.Parameters.AddWithValue("@i6", txtRemark.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Expense details Succesfully Saved");
                    ClearAll();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("All field are mandatory !!");
            }
          
        }

        private void grpExpenseDetails_Enter(object sender, EventArgs e)
        {

        }

        private void grpExpenseEntry_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator())
            {

                try
                {
                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("update TblExpenseEntry set ExpenseDate=@i2,PaidTo=@i3,Amount=@i4,PaymentMode=@i5,Remark=@i6 where EntryCode=@i1", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerExpense.Text);
                    cmd.Parameters.AddWithValue("@i3", txtPaidTo.Text);
                    cmd.Parameters.AddWithValue("@i4", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@i5", cmbPaymentMode.Text);
                    cmd.Parameters.AddWithValue("@i6", txtRemark.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Expense details are Succesfully updated ");
                    ClearAll();
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
        private void ClearAll()
        {
            txtEntryCode.Text = "";
            dateTimePickerExpense.ResetText();
            txtPaidTo.Text = "";
            txtAmount.Text = "";
            cmbPaymentMode.SelectedIndex = -1;
            txtRemark.Text = "";

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
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblExpenseEntry", con);
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
                SqlDataAdapter da = new SqlDataAdapter("Select Max(EntryCode) as MaxId from TblExpenseEntry", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxEntryCode = 0;
                if (dt.Rows[0]["MaxId"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxEntryCode = Convert.ToInt32(dt.Rows[0]["MaxId"]);
                }
                MaxEntryCode = MaxEntryCode + 1;
                txtEntryCode.Text = MaxEntryCode.ToString();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtEntryCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dateTimePickerExpense.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtPaidTo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cmbPaymentMode.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtRemark.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

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
    }
}
