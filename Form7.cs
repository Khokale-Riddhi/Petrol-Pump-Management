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
    public partial class frmAddVehicles : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmAddVehicles()
        {
            InitializeComponent();
        }

        private void frmAddVehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet21.TblAddVehicles' table. You can move, or remove it, as needed.
            this.tblAddVehiclesTableAdapter1.Fill(this.petrolPumpDbDataSet21.TblAddVehicles);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet3.TblAddVehicles' table. You can move, or remove it, as needed.
          //  this.tblAddVehiclesTableAdapter.Fill(this.petrolPumpDbDataSet3.TblAddVehicles);
            
            ClearAll();

        }
        private bool Validator()
        {
            if (txtVehicleId.Text == "" || txtCustomerCode.Text == "" || txtVehicleNo.Text == "" )
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
                    SqlCommand cmd = new SqlCommand("insert into TblAddVehicles values(@i1,@i2,@i3)", con);
                    cmd.Parameters.AddWithValue("@i1", txtVehicleId.Text);
                    cmd.Parameters.AddWithValue("@i2", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i3", txtVehicleNo.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Vehicle deetails are Successfully added ");
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
            txtVehicleId.Text = "";
            txtCustomerCode.Text = "";
            txtVehicleNo.Text = "";

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClear.Enabled = true;

            GenerateId();
            FillGrid();

            
        }
        private void FillGrid()
        {

            try
            {
                SqlConnection con = new SqlConnection(c);
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblAddVehicles", con);
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
                SqlDataAdapter da = new SqlDataAdapter("Select Max(VehicleId) as MaxId from TblAddVehicles", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxAddVehicles = 0;
                if (dt.Rows[0]["MaxId"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxAddVehicles = Convert.ToInt32(dt.Rows[0]["MaxId"]);
                }
                MaxAddVehicles = MaxAddVehicles + 1;
                txtVehicleId.Text = MaxAddVehicles.ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validator())
            {

                try
                {
                    SqlConnection con = new SqlConnection(c);
                    SqlCommand cmd = new SqlCommand("update TblAddVehicles set CustomerCode=@i2,VehicleNo=@i3 where VehicleId=@i1 ", con);
                    cmd.Parameters.AddWithValue("@i1", txtVehicleId.Text);
                    cmd.Parameters.AddWithValue("@i2", txtCustomerCode.Text);
                    cmd.Parameters.AddWithValue("@i3", txtVehicleNo.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Vehicle details are successfully updated ");
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
                SqlCommand cmd = new SqlCommand("delete from TblAddVehicles where VehicleId=@i1", con);
                cmd.Parameters.AddWithValue("@i1", txtVehicleId.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Vehicle details are successfully deleted ");
                ClearAll();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex>=0)
                {
                    txtVehicleId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtCustomerCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtVehicleNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

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
