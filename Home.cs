using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolPumpManagement
{
    public partial class Home : Form
    {
        private int childFormNumber = 0;
        public string CurrentUsername{
            set{lblwelcome.Text="Welcome : "+ value;}
        }

        public Home()
        {
            InitializeComponent();

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeMaster obj = new frmEmployeeMaster();
            obj.MdiParent = this;
            obj.Show();
        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerMaster obj = new frmCustomerMaster();
            obj.MdiParent = this;
            obj.Show();
        }

        private void nozzleMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNozzleMaster obj = new frmNozzleMaster();
            obj.MdiParent = this;
            obj.Show();
        }

        private void creditEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreditEntry obj = new frmCreditEntry();
            obj.MdiParent = this;
            obj.Show();
        }

        private void depositEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepositEntry obj = new frmDepositEntry();
            obj.MdiParent = this;
            obj.Show();
        }

        private void expenseEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpenseEntry obj = new frmExpenseEntry();
            obj.MdiParent = this;
            obj.Show();

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmChangePassword obj = new frmChangePassword();
            //obj.MdiParent = this;
            //obj.Show();
             frmChangePassword obj = new frmChangePassword(lblwelcome.Text.Replace("Welcome : ",""));
             obj.ShowDialog();
        }

        private void todaysRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTodaysRate obj = new frmTodaysRate();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVehicles obj = new frmAddVehicles();
            obj.MdiParent = this;
            obj.Show();
        }

        private void signUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSignUp obj = new frmSignUp();
            obj.MdiParent = this;
            obj.Show();
        }

        private void utilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void ShowDashboard()
        {
            //check if dashboard form is already open
            foreach (Form child in this.MdiChildren)
            {
                if (child is frmDashboard) //dashboard form is already open no need to open again
                    return;
            }
            //open dashboard form
            frmDashboard obj = new frmDashboard();
            obj.MdiParent = this;
            obj.Show();
        }



        private void Home_Load(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void depositToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRptDeposit obj = new frmRptDeposit();
            obj.MdiParent = this;
            obj.Show();
        }

        private void mastersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dateWiseCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptEmployeemaster obj = new frmRptEmployeemaster();
            obj.MdiParent = this;
            obj.Show();
        }

        private void depositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRptCredit obj = new frmRptCredit();
            obj.MdiParent = this;
            obj.Show();
        }

        private void dateWiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptCustomerMaster obj = new frmRptCustomerMaster();
            obj.MdiParent = this;
            obj.Show();
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRptExpense obj = new frmRptExpense();
            obj.MdiParent = this;
            obj.Show();
        }

        private void billRecieptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creditSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RptCreditSale obj = new RptCreditSale();
            obj.MdiParent = this;
            obj.Show();
        }

        /*    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }*/
    }
}
