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
    public partial class frmTodaysRate : Form
    {
        String c = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public frmTodaysRate()
        {
            InitializeComponent();
        }

        private void grpEnterTodaysRate_Enter(object sender, EventArgs e)
        {

        }

        private void frmTodaysRate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet17.TblTodaysRate' table. You can move, or remove it, as needed.
            this.tblTodaysRateTableAdapter4.Fill(this.petrolPumpDbDataSet17.TblTodaysRate);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet14.TblTodaysRate' table. You can move, or remove it, as needed.
            //  this.tblTodaysRateTableAdapter3.Fill(this.petrolPumpDbDataSet14.TblTodaysRate);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet13.TblTodaysRate' table. You can move, or remove it, as needed.
            //   this.tblTodaysRateTableAdapter2.Fill(this.petrolPumpDbDataSet13.TblTodaysRate);
            // TODO: This line of code loads data into the 'petrolPumpDbDataSet11.TblTodaysRate' table. You can move, or remove it, as needed.
            //   this.tblTodaysRateTableAdapter1.Fill(this.petrolPumpDbDataSet11.TblTodaysRate);

         
            
            ClearAll();

        }
        private bool Validator()
        {
            if (txtEntryCode.Text == "" || dateTimePickerTodaysRate.Text == "" || txtPetrol.Text == ""|| txtPetrol.Text== "" || txtXtraPremium.Text == "" || txtDiesel.Text==""|| txtCNG.Text=="")
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
                    SqlCommand cmd = new SqlCommand("insert into TblTodaysRate values(@i1,@i2,@i3,@i4,@i5,@i6)", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerTodaysRate.Value.Date);
                    cmd.Parameters.AddWithValue("@i3", txtPetrol.Text);
                    cmd.Parameters.AddWithValue("@i4", txtXtraPremium.Text);
                    cmd.Parameters.AddWithValue("@i5", txtDiesel.Text);
                    cmd.Parameters.AddWithValue("@i6", txtCNG.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Todays rate are successfully saved ");
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
                    SqlCommand cmd = new SqlCommand("update TblTodaysRate set Tdate=@i2,Petrol=@i3,XtraPremium=@i4,Diesel=@i5,CNG=@i6 where EntryCode=@i1", con);
                    cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                    cmd.Parameters.AddWithValue("@i2", dateTimePickerTodaysRate.Value.Date);
                    cmd.Parameters.AddWithValue("@i3", txtPetrol.Text);
                    cmd.Parameters.AddWithValue("@i4", txtXtraPremium.Text);
                    cmd.Parameters.AddWithValue("@i5", txtDiesel.Text);
                    cmd.Parameters.AddWithValue("@i6", txtCNG.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Today's rate are successfully updated ");
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
                SqlCommand cmd = new SqlCommand("delete from TblTodaysRate where EntryCode=@i1", con);
                cmd.Parameters.AddWithValue("@i1", txtEntryCode.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Today's rate are successfully deleted "); ClearAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void ClearAll()
        {
            txtEntryCode.Text = "";
            dateTimePickerTodaysRate.ResetText();
            txtPetrol.Text = "";
            txtXtraPremium.Text = "";
            txtDiesel.Text = "";
            txtCNG.Text = "";

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
                SqlDataAdapter da = new SqlDataAdapter("Select * from TblTodaysRate", con);
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
                SqlDataAdapter da = new SqlDataAdapter("Select Max(EntryCode) as MaxId from TblTodaysRate", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int MaxTodaysRate = 0;
                if (dt.Rows[0]["MaxId"] != null && dt.Rows[0]["MaxId"].ToString() != "")
                {
                    MaxTodaysRate = Convert.ToInt32(dt.Rows[0]["MaxId"]);
                }
                MaxTodaysRate = MaxTodaysRate + 1;
                txtEntryCode.Text = MaxTodaysRate.ToString();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    txtEntryCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dateTimePickerTodaysRate.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtPetrol.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtXtraPremium.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtDiesel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtCNG.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


