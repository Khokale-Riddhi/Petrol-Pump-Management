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
    public partial class frmNozzleMaster : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmNozzleMaster()
        {
            InitializeComponent();
        }

        private void frmNozzleMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet24.TblNozzleMaster' table. You can move, or remove it, as needed.
            this.tblNozzleMasterTableAdapter3.Fill(this.petrolPumpDbDataSet24.TblNozzleMaster);
          

            ClearAll();
        }
        private bool Validator()
        {
            if (txtNozzleCode.Text == "" || cmbSelectMPD.Text == "" || cmbSelectFuelType.Text == "" || txtNozzleName.Text == "" || txtOpeningReading.Text == "")
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
                    SqlCommand cmd = new SqlCommand("insert into TblNozzleMaster values(@i1,@i2,@i3,@i4,@i5)", con);
                    cmd.Parameters.AddWithValue("@i1", txtNozzleCode.Text);
                    cmd.Parameters.AddWithValue("@i2", cmbSelectMPD.Text);
                    cmd.Parameters.AddWithValue("@i3", cmbSelectFuelType.Text);
                    cmd.Parameters.AddWithValue("@i4", txtNozzleName.Text);
                    cmd.Parameters.AddWithValue("@i5", txtOpeningReading.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Nozzle details are successfully saved ");
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
                    SqlCommand cmd = new SqlCommand("update TblNozzleMaster set MPD=@i2,FuelType=@i3,NozzleName=@i4,OpeningReading=@i5 where NozzleCode=@i1 ", con);
                    cmd.Parameters.AddWithValue("@i1", txtNozzleCode.Text);
                    cmd.Parameters.AddWithValue("@i2", cmbSelectMPD.Text);
                    cmd.Parameters.AddWithValue("@i3", cmbSelectFuelType.Text);
                    cmd.Parameters.AddWithValue("@i4", txtNozzleName.Text);
                    cmd.Parameters.AddWithValue("@i5", txtOpeningReading.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Nozzle details are successfully updated ");
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
                SqlCommand cmd = new SqlCommand("delete from TblNozzleMaster where NozzleCode =@i1", con);
                cmd.Parameters.AddWithValue("@i1", txtNozzleCode.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Nozzle details are successfully deleted ");
                ClearAll();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ClearAll()
        {
            txtNozzleCode.Text = "";
            cmbSelectMPD.SelectedIndex = -1;
            cmbSelectFuelType.SelectedIndex = -1;
            txtNozzleName.Text = "";
            txtOpeningReading.Text ="";
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
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblNozzleMaster", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
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
                SqlDataAdapter da = new SqlDataAdapter("Select Max(NozzleCode) as MaxId from TblNozzleMaster", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxNozzleId = 0;
                if (dt.Rows[0]["MaxId"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxNozzleId = Convert.ToInt32(dt.Rows[0]["MaxId"]);
                }
                MaxNozzleId = MaxNozzleId + 1;
                txtNozzleCode.Text = MaxNozzleId.ToString();
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

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtNozzleCode.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmbSelectMPD.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    cmbSelectFuelType.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtNozzleName.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtOpeningReading.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();

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
