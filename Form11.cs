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
    public partial class frmCreditEntry : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmCreditEntry()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtVehicleNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreditEntry_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet19.TblCreditSale' table. You can move, or remove it, as needed.
            this.tblCreditSaleTableAdapter3.Fill(this.petrolPumpDbDataSet19.TblCreditSale);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet15.TblCreditSale' table. You can move, or remove it, as needed.
          //  this.tblCreditSaleTableAdapter2.Fill(this.petrolPumpDbDataSet15.TblCreditSale);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet12.TblCreditSale' table. You can move, or remove it, as needed.
            // this.tblCreditSaleTableAdapter1.Fill(this.petrolPumpDbDataSet12.TblCreditSale);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet6.TblCreditSale' table. You can move, or remove it, as needed.
            //this.tblCreditSaleTableAdapter.Fill(this.petrolPumpDbDataSet6.TblCreditSale);
            ClearAll();
        }
        private bool Validator()
        {
            if (txtEntryCode.Text == "" || dateTimePickerCreditEntry.Text == "" || txtEmployeeName.Text == "" || txtEmployeeCode.Text == "" || txtFirmName.Text == "" || txtCustomerCode.Text == "" ||txtVehicleNo.Text == "" || cmbSelectMPD.Text == "" || cmbSelectNozzle.Text == "" || cmbSelectFuelType.Text == "" || txtTodaysRate.Text == "" || txtAmount.Text == "" || txtLitres.Text == "" || txtNote.Text == "")
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
                    SqlCommand cmd = new SqlCommand("insert into TblCreditSale values(@i1,@i2,@i3,@i4,@i5,@i6,@i7,@i8,@i9,@i10,@i11,@i12,@i13,@i14)", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerCreditEntry.Value.Date);
                    cmd.Parameters.AddWithValue("@i3", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@i4", txtEmployeeCode.Text);
                    cmd.Parameters.AddWithValue("@i5", txtFirmName.Text);
                    cmd.Parameters.AddWithValue("@i6", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i7", txtVehicleNo.Text);
                    cmd.Parameters.AddWithValue("@i8", cmbSelectMPD.Text);
                    cmd.Parameters.AddWithValue("@i9", cmbSelectNozzle.Text);
                    cmd.Parameters.AddWithValue("@i10", cmbSelectFuelType.Text);
                    cmd.Parameters.AddWithValue("@i11", txtTodaysRate.Text);
                    cmd.Parameters.AddWithValue("@i12", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@i13", txtLitres.Text);
                    cmd.Parameters.AddWithValue("@i14", txtNote.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Credit details are successfully saved");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                try
                {
                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("update TblCreditSale set EntryDate=@i2,EmployeeName=@i3,EmployeeCode=@i4,FirmName=@i5,CustomerCode=@i6,VehicleNo=@i7,MPD=@i8,Nozzle=@i9,FuelType=@i10,TodaysRate=@i11,Amount=@i11,Litres=@i12,Note=@i13 where EntryCode=@i1", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerCreditEntry.Value.Date);
                    cmd.Parameters.AddWithValue("@i3", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@i4", txtEmployeeCode.Text);
                    cmd.Parameters.AddWithValue("@i5", txtFirmName.Text);
                    cmd.Parameters.AddWithValue("@i6", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i7", txtVehicleNo.Text);
                    cmd.Parameters.AddWithValue("@i8", cmbSelectMPD.Text);
                    cmd.Parameters.AddWithValue("@i9", cmbSelectNozzle.Text);
                    cmd.Parameters.AddWithValue("@i10", cmbSelectFuelType.Text);
                    cmd.Parameters.AddWithValue("@i11", txtTodaysRate.Text);
                    cmd.Parameters.AddWithValue("@i12", txtAmount.Text);
                    cmd.Parameters.AddWithValue("@i13", txtLitres.Text);
                    cmd.Parameters.AddWithValue("@i14", txtNote.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Credit details are successfully updated");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlCommand cmd = new SqlCommand("delete from TblCreditSale where EntryCode=@i1", con);
                cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Credit details are deleted successfully");
                ClearAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void ClearAll()
        {
            txtEntryCode.Text = "";
            dateTimePickerCreditEntry.ResetText();
            txtEmployeeName.Text = "";
            txtEmployeeCode.Text = "";
            txtFirmName.Text = "";
            txtCustomerCode.Text = "";
            txtVehicleNo.Text = "";
            cmbSelectMPD.SelectedIndex = -1;
            cmbSelectNozzle.SelectedIndex = -1;
            cmbSelectFuelType.SelectedIndex = -1;
            txtTodaysRate.Text = "";
            txtAmount.Text = "";
            txtLitres.Text = "";
            txtNote.Text = "";

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;

            FillGrid();
            GenerateID();
        }
        private void FillGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select* from TblCreditSale", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GenerateID()
        {
            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select Max(EntryCode) as MaxID from TblCreditSale", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxCreditCode = 0;
                if (dt.Rows[0]["MaxID"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxCreditCode = Convert.ToInt32(dt.Rows[0]["MaxID"]);
                }
                MaxCreditCode = MaxCreditCode + 1;
                txtEntryCode.Text = MaxCreditCode.ToString();
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

        private void grpCreditEntry_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtEntryCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dateTimePickerCreditEntry.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtEmployeeName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtEmployeeCode.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtFirmName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtCustomerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtVehicleNo.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    cmbSelectMPD.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    cmbSelectNozzle.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    cmbSelectFuelType.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtTodaysRate.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                    txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
                    txtLitres.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
                    txtNote.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();

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

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectFuelType_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmployeeName_Leave(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text != "")
            {

                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select EmployeeCode from TblEmployeeMaster where Name = @i1", con);
                da.SelectCommand.Parameters.AddWithValue("@i1", txtEmployeeName.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtEmployeeCode.Text = dt.Rows[0][0].ToString();
                }
            }
        }

        private void txtFirmName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirmName_Leave(object sender, EventArgs e)
        {
            if (txtFirmName.Text != "")
            {

                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select CustomerCode from TblCustomerMaster where FirmName = @i1", con);
                da.SelectCommand.Parameters.AddWithValue("@i1", txtFirmName.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtCustomerCode.Text = dt.Rows[0][0].ToString();
                }
            }
        }

        private void cmbSelectFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectFuelType.Text != "")
            {

                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select "+cmbSelectFuelType.Text+" from TblTodaysRate where TDate= @i1", con);
                da.SelectCommand.Parameters.AddWithValue("@i1", dateTimePickerCreditEntry.Value.Date);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtTodaysRate.Text = dt.Rows[0][0].ToString();
                }
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text!="")
            {
                double rate = 0;
                double litres = 0;
                double amount = 0;
                if (txtTodaysRate.Text!="")
                {
                    rate = Convert.ToDouble(txtTodaysRate.Text);
                    
               }
                if (txtAmount.Text!="")
                {
                    amount = Convert.ToDouble(txtAmount.Text);
                }
                litres = amount / rate;
                txtLitres.Text = litres.ToString();
            }
        }

        private void txtLitres_TextChanged(object sender, EventArgs e)
        {
            if (txtLitres.Text != "")
            {
                double rate = 0;
                double litres = 0;
                double amount = 0;
                if (txtTodaysRate.Text != "")
                {
                    rate = Convert.ToDouble(txtTodaysRate.Text);

                }
                if (txtLitres.Text != "")
                {
                    litres = Convert.ToDouble(txtLitres.Text);
                }
                amount = litres*rate;
                txtAmount.Text = amount.ToString();
            }
        }
    }
}
