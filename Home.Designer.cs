namespace PetrolPumpManagement
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nozzleMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaysRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.expenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateWiseCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateWiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.billRecieptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeMasterToolStripMenuItem,
            this.customerMasterToolStripMenuItem,
            this.nozzleMasterToolStripMenuItem,
            this.addVehiclesToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.mastersToolStripMenuItem.Text = "Masters";
            this.mastersToolStripMenuItem.Click += new System.EventHandler(this.mastersToolStripMenuItem_Click);
            // 
            // employeeMasterToolStripMenuItem
            // 
            this.employeeMasterToolStripMenuItem.Name = "employeeMasterToolStripMenuItem";
            this.employeeMasterToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.employeeMasterToolStripMenuItem.Text = "Employee Master";
            this.employeeMasterToolStripMenuItem.Click += new System.EventHandler(this.employeeMasterToolStripMenuItem_Click);
            // 
            // customerMasterToolStripMenuItem
            // 
            this.customerMasterToolStripMenuItem.Name = "customerMasterToolStripMenuItem";
            this.customerMasterToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.customerMasterToolStripMenuItem.Text = "Customer Master";
            this.customerMasterToolStripMenuItem.Click += new System.EventHandler(this.customerMasterToolStripMenuItem_Click);
            // 
            // nozzleMasterToolStripMenuItem
            // 
            this.nozzleMasterToolStripMenuItem.Name = "nozzleMasterToolStripMenuItem";
            this.nozzleMasterToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.nozzleMasterToolStripMenuItem.Text = "Nozzle Master";
            this.nozzleMasterToolStripMenuItem.Click += new System.EventHandler(this.nozzleMasterToolStripMenuItem_Click);
            // 
            // addVehiclesToolStripMenuItem
            // 
            this.addVehiclesToolStripMenuItem.Name = "addVehiclesToolStripMenuItem";
            this.addVehiclesToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.addVehiclesToolStripMenuItem.Text = "Add Vehicles";
            this.addVehiclesToolStripMenuItem.Click += new System.EventHandler(this.addVehiclesToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditEntryToolStripMenuItem,
            this.depositEntryToolStripMenuItem,
            this.expenseEntryToolStripMenuItem,
            this.todaysRateToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(157, 36);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // creditEntryToolStripMenuItem
            // 
            this.creditEntryToolStripMenuItem.Name = "creditEntryToolStripMenuItem";
            this.creditEntryToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.creditEntryToolStripMenuItem.Text = "Credit Entry";
            this.creditEntryToolStripMenuItem.Click += new System.EventHandler(this.creditEntryToolStripMenuItem_Click);
            // 
            // depositEntryToolStripMenuItem
            // 
            this.depositEntryToolStripMenuItem.Name = "depositEntryToolStripMenuItem";
            this.depositEntryToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.depositEntryToolStripMenuItem.Text = "Deposit Entry";
            this.depositEntryToolStripMenuItem.Click += new System.EventHandler(this.depositEntryToolStripMenuItem_Click);
            // 
            // expenseEntryToolStripMenuItem
            // 
            this.expenseEntryToolStripMenuItem.Name = "expenseEntryToolStripMenuItem";
            this.expenseEntryToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.expenseEntryToolStripMenuItem.Text = "Expense entry";
            this.expenseEntryToolStripMenuItem.Click += new System.EventHandler(this.expenseEntryToolStripMenuItem_Click);
            // 
            // todaysRateToolStripMenuItem
            // 
            this.todaysRateToolStripMenuItem.Name = "todaysRateToolStripMenuItem";
            this.todaysRateToolStripMenuItem.Size = new System.Drawing.Size(251, 36);
            this.todaysRateToolStripMenuItem.Text = "Todays Rate";
            this.todaysRateToolStripMenuItem.Click += new System.EventHandler(this.todaysRateToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.dateWiseCreditToolStripMenuItem,
            this.dateWiseToolStripMenuItem,
            this.billRecieptToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem1,
            this.depositToolStripMenuItem2,
            this.expenseToolStripMenuItem});
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.depositToolStripMenuItem.Text = "Date Wise";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // depositToolStripMenuItem1
            // 
            this.depositToolStripMenuItem1.Name = "depositToolStripMenuItem1";
            this.depositToolStripMenuItem1.Size = new System.Drawing.Size(189, 36);
            this.depositToolStripMenuItem1.Text = "Credit";
            this.depositToolStripMenuItem1.Click += new System.EventHandler(this.depositToolStripMenuItem1_Click);
            // 
            // depositToolStripMenuItem2
            // 
            this.depositToolStripMenuItem2.Name = "depositToolStripMenuItem2";
            this.depositToolStripMenuItem2.Size = new System.Drawing.Size(189, 36);
            this.depositToolStripMenuItem2.Text = "Deposit";
            this.depositToolStripMenuItem2.Click += new System.EventHandler(this.depositToolStripMenuItem2_Click);
            // 
            // expenseToolStripMenuItem
            // 
            this.expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            this.expenseToolStripMenuItem.Size = new System.Drawing.Size(189, 36);
            this.expenseToolStripMenuItem.Text = "Expense";
            this.expenseToolStripMenuItem.Click += new System.EventHandler(this.expenseToolStripMenuItem_Click);
            // 
            // dateWiseCreditToolStripMenuItem
            // 
            this.dateWiseCreditToolStripMenuItem.Name = "dateWiseCreditToolStripMenuItem";
            this.dateWiseCreditToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.dateWiseCreditToolStripMenuItem.Text = "Employee Master";
            this.dateWiseCreditToolStripMenuItem.Click += new System.EventHandler(this.dateWiseCreditToolStripMenuItem_Click);
            // 
            // dateWiseToolStripMenuItem
            // 
            this.dateWiseToolStripMenuItem.Name = "dateWiseToolStripMenuItem";
            this.dateWiseToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.dateWiseToolStripMenuItem.Text = "Customer Master";
            this.dateWiseToolStripMenuItem.Click += new System.EventHandler(this.dateWiseToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpToolStripMenuItem1,
            this.signUpToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            this.utilitiesToolStripMenuItem.Click += new System.EventHandler(this.utilitiesToolStripMenuItem_Click);
            // 
            // signUpToolStripMenuItem1
            // 
            this.signUpToolStripMenuItem1.Name = "signUpToolStripMenuItem1";
            this.signUpToolStripMenuItem1.Size = new System.Drawing.Size(288, 36);
            this.signUpToolStripMenuItem1.Text = "Sign Up";
            this.signUpToolStripMenuItem1.Click += new System.EventHandler(this.signUpToolStripMenuItem1_Click);
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.signUpToolStripMenuItem.Text = "Change Password";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.White;
            this.lblwelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.ForeColor = System.Drawing.Color.Teal;
            this.lblwelcome.Location = new System.Drawing.Point(1649, 9);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(76, 26);
            this.lblwelcome.TabIndex = 6;
            this.lblwelcome.Text = "label1";
            // 
            // billRecieptToolStripMenuItem
            // 
            this.billRecieptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditSaleToolStripMenuItem});
            this.billRecieptToolStripMenuItem.Name = "billRecieptToolStripMenuItem";
            this.billRecieptToolStripMenuItem.Size = new System.Drawing.Size(287, 36);
            this.billRecieptToolStripMenuItem.Text = "Bill Reciept";
            this.billRecieptToolStripMenuItem.Click += new System.EventHandler(this.billRecieptToolStripMenuItem_Click);
            // 
            // creditSaleToolStripMenuItem
            // 
            this.creditSaleToolStripMenuItem.Name = "creditSaleToolStripMenuItem";
            this.creditSaleToolStripMenuItem.Size = new System.Drawing.Size(217, 36);
            this.creditSaleToolStripMenuItem.Text = "Credit Sale";
            this.creditSaleToolStripMenuItem.Click += new System.EventHandler(this.creditSaleToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nozzleMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expenseEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaysRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem1;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem expenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateWiseCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateWiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billRecieptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditSaleToolStripMenuItem;
    }
}



