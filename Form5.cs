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
    public partial class frmEmployeeMaster : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmEmployeeMaster()
        {
            InitializeComponent();
        }

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEmployeeMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet1.TblEmployeeMaster' table. You can move, or remove it, as needed.
            this.tblEmployeeMasterTableAdapter.Fill(this.petrolPumpDbDataSet1.TblEmployeeMaster);
            ClearAll();
        }
        private bool Validator()
        {
            if (txtEmployeeCode.Text == "" || txtName.Text == "" || txtMobileNo1.Text == ""  || cmbDesignation.Text == "")
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
                    SqlCommand cmd = new SqlCommand("insert into TblEmployeeMaster values(@i1,@i2,@i3,@i4,@i5)", con);
                    cmd.Parameters.AddWithValue("@i1", txtEmployeeCode.Text);
                    cmd.Parameters.AddWithValue("@i2", txtName.Text);
                    cmd.Parameters.AddWithValue("@i3", txtMobileNo1.Text);
                    cmd.Parameters.AddWithValue("@i4", txtMobileNo2.Text);
                    cmd.Parameters.AddWithValue("@i5", cmbDesignation.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee details are successfully saved");
                    ClearAll();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("EmployeeCode,EmployeeName,MobileNo1 and Designation are mandatory !!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator())
            {
                try
                {

                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("update TblEmployeeMaster set Name=@i2,MobileNo1=@i3,MobileNo2=@i4,Designation=@i5 where EmployeeCode=@i1 ", con);
                    cmd.Parameters.AddWithValue("@i1", txtEmployeeCode.Text);
                    cmd.Parameters.AddWithValue("@i2", txtName.Text);
                    cmd.Parameters.AddWithValue("@i3", txtMobileNo1.Text);
                    cmd.Parameters.AddWithValue("@i4", txtMobileNo2.Text);
                    cmd.Parameters.AddWithValue("@i5", cmbDesignation.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee details are successfully updated");
                    ClearAll();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 
            }
            else
            {
                MessageBox.Show("EmployeeCode,EmployeeName,MobileNo1 and Designation are mandatory !!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlCommand cmd = new SqlCommand("delete from TblEmployeeMaster where EmployeeCode=@i1", con);
                cmd.Parameters.AddWithValue("@i1", txtEmployeeCode.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee details are successfully deleted");
                ClearAll();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearAll()
        {
            txtEmployeeCode.Text = "";
            txtName.Text = "";
            txtMobileNo1.Text = "";
            txtMobileNo2.Text = "";
            cmbDesignation.SelectedIndex = -1;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;
            FillGrid();
            GenerateId();

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
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblEmployeeMaster", con);
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
                SqlDataAdapter da = new SqlDataAdapter("Select Max(EmployeeCode) as MaxID from TblEmployeeMaster", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxEmployeeCode = 0;
                if (dt.Rows[0]["MaxID"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxEmployeeCode = Convert.ToInt32(dt.Rows[0]["MaxID"]);
                }
                MaxEmployeeCode = MaxEmployeeCode + 1;
                txtEmployeeCode.Text = MaxEmployeeCode.ToString();
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

        private void frmEmployeeMaster_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtEmployeeCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtMobileNo1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtMobileNo2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    cmbDesignation.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

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

        private void txtMobileNo1_Leave(object sender, EventArgs e)
        {
            if (txtMobileNo1.Text.Length!=10)
            {
                MessageBox.Show("Mobile number must be 10 digit !!");
                txtMobileNo1.Focus();
                
            }
        }

        private void lblEmployeeCode_Click(object sender, EventArgs e)
        {

        }
    }
}
