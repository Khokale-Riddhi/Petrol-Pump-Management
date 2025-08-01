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
    public partial class frmCustomerMaster : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmCustomerMaster()
        {
            InitializeComponent();
        }

        private void grpCustomerEntry_Enter(object sender, EventArgs e)
        {

        }

        private void frmCustomerMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet2.TblCustomerMaster' table. You can move, or remove it, as needed.
            this.tblCustomerMasterTableAdapter.Fill(this.petrolPumpDbDataSet2.TblCustomerMaster);
            ClearAll();
        }
        private bool Validator()
        {

            if (txtCustomerCode.Text == "" || txtFirmName.Text == "" || txtOwnerName.Text == "" || txtMobileNo1.Text == "")
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
                    SqlCommand cmd = new SqlCommand("insert into TblCustomerMaster values (@i1,@i2,@i3,@i4,@i5,@i6)", con);
                    cmd.Parameters.AddWithValue("@i1", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i2", txtFirmName.Text);
                    cmd.Parameters.AddWithValue("@i3", txtOwnerName.Text);
                    cmd.Parameters.AddWithValue("@i4", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@i5", txtMobileNo1.Text);
                    cmd.Parameters.AddWithValue("@i6", txtMobileNo2.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer details are successfully saved");
                    ClearAll();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("CustomerCode,FirmName,OwnerName and MobileNo1 are mandatory !!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                try
                {
                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("update TblCustomerMaster set FirmName=@i2,OwnerName=@i3,Address=@i4,MobileNo1=@i5,MobileNo2=@i6 where CustomerCode=@i1", con);
                    cmd.Parameters.AddWithValue("@i1", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i2", txtFirmName.Text);
                    cmd.Parameters.AddWithValue("@i3", txtOwnerName.Text);
                    cmd.Parameters.AddWithValue("@i4", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@i5", txtMobileNo1.Text);
                    cmd.Parameters.AddWithValue("@i6", txtMobileNo2.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Customer details are successfully updated ");
                    ClearAll();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("CustomerCode,FirmName,OwnerName and MobileNo1 are mandatory !!");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlCommand cmd = new SqlCommand("delete from TblCustomerMaster where CustomerCode=@i1", con);
                cmd.Parameters.AddWithValue("@i1", txtCustomerCode.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Customer details are Successfully deleted ");
                ClearAll();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearAll()
        {
            txtCustomerCode.Text = "";
            txtFirmName.Text = "";
            txtOwnerName.Text = "";
            txtAddress.Text = "";
            txtMobileNo1.Text = "";
            txtMobileNo2.Text = "";
            FillGrid();
            GenerateID();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
        }
        private void FillGrid()
        {
            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblCustomerMaster", con);
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
                SqlDataAdapter da = new SqlDataAdapter("Select Max(CustomerCode) as MaxID from TblCustomerMaster", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxCustomertCode = 0;
                if (dt.Rows[0]["MaxID"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxCustomertCode = Convert.ToInt32(dt.Rows[0]["MaxID"]);
                }
                MaxCustomertCode = MaxCustomertCode + 1;
                txtCustomerCode.Text = MaxCustomertCode.ToString();
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

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtCustomerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtFirmName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtOwnerName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtMobileNo1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtMobileNo2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileNo1_Leave(object sender, EventArgs e)
        {
            if (txtMobileNo1.Text.Length != 10)
            {
                MessageBox.Show("Mobile number must be 10 digit !!");
                txtMobileNo1.Focus();

            }
        }
    }
}
