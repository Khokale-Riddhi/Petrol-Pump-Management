namespace PetrolPumpManagement
{
    partial class frmExpenseEntry
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
            this.grpExpenseEntry = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerExpense = new System.Windows.Forms.DateTimePicker();
            this.txtPaidTo = new System.Windows.Forms.TextBox();
            this.txtEntryCode = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaidTo = new System.Windows.Forms.Label();
            this.lblExpenseDate = new System.Windows.Forms.Label();
            this.lblEntryCode = new System.Windows.Forms.Label();
            this.grpExpenseDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.entryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblExpenseEntryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet23 = new PetrolPumpManagement.PetrolPumpDbDataSet23();
            this.tblExpenseEntryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet16 = new PetrolPumpManagement.PetrolPumpDbDataSet16();
            this.tblExpenseEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet = new PetrolPumpManagement.PetrolPumpDbDataSet();
            this.tblExpenseEntryTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSetTableAdapters.TblExpenseEntryTableAdapter();
            this.tblExpenseEntryTableAdapter1 = new PetrolPumpManagement.PetrolPumpDbDataSet16TableAdapters.TblExpenseEntryTableAdapter();
            this.tblExpenseEntryTableAdapter2 = new PetrolPumpManagement.PetrolPumpDbDataSet23TableAdapters.TblExpenseEntryTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tblAddVehiclesTableAdapter1 = new PetrolPumpManagement.PetrolPumpDbDataSet21TableAdapters.TblAddVehiclesTableAdapter();
            this.grpExpenseEntry.SuspendLayout();
            this.grpExpenseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseEntryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseEntryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpExpenseEntry
            // 
            this.grpExpenseEntry.BackColor = System.Drawing.Color.White;
            this.grpExpenseEntry.Controls.Add(this.btnClear);
            this.grpExpenseEntry.Controls.Add(this.btnDelete);
            this.grpExpenseEntry.Controls.Add(this.btnUpdate);
            this.grpExpenseEntry.Controls.Add(this.btnSave);
            this.grpExpenseEntry.Controls.Add(this.cmbPaymentMode);
            this.grpExpenseEntry.Controls.Add(this.txtRemark);
            this.grpExpenseEntry.Controls.Add(this.txtAmount);
            this.grpExpenseEntry.Controls.Add(this.dateTimePickerExpense);
            this.grpExpenseEntry.Controls.Add(this.txtPaidTo);
            this.grpExpenseEntry.Controls.Add(this.txtEntryCode);
            this.grpExpenseEntry.Controls.Add(this.lblRemark);
            this.grpExpenseEntry.Controls.Add(this.lblPaymentMode);
            this.grpExpenseEntry.Controls.Add(this.lblAmount);
            this.grpExpenseEntry.Controls.Add(this.lblPaidTo);
            this.grpExpenseEntry.Controls.Add(this.lblExpenseDate);
            this.grpExpenseEntry.Controls.Add(this.lblEntryCode);
            this.grpExpenseEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExpenseEntry.Location = new System.Drawing.Point(16, 104);
            this.grpExpenseEntry.Name = "grpExpenseEntry";
            this.grpExpenseEntry.Size = new System.Drawing.Size(612, 765);
            this.grpExpenseEntry.TabIndex = 0;
            this.grpExpenseEntry.TabStop = false;
            this.grpExpenseEntry.Text = "Expense Entry";
            this.grpExpenseEntry.Enter += new System.EventHandler(this.grpExpenseEntry_Enter);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(466, 655);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 66);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(312, 655);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 66);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(164, 655);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 66);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(16, 655);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 66);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Cash",
            "Online"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(268, 463);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(276, 33);
            this.cmbPaymentMode.TabIndex = 10;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(268, 560);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(276, 30);
            this.txtRemark.TabIndex = 11;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(268, 369);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(276, 30);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dateTimePickerExpense
            // 
            this.dateTimePickerExpense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerExpense.Location = new System.Drawing.Point(268, 181);
            this.dateTimePickerExpense.Name = "dateTimePickerExpense";
            this.dateTimePickerExpense.Size = new System.Drawing.Size(276, 30);
            this.dateTimePickerExpense.TabIndex = 7;
            // 
            // txtPaidTo
            // 
            this.txtPaidTo.Location = new System.Drawing.Point(268, 275);
            this.txtPaidTo.Name = "txtPaidTo";
            this.txtPaidTo.Size = new System.Drawing.Size(276, 30);
            this.txtPaidTo.TabIndex = 8;
            // 
            // txtEntryCode
            // 
            this.txtEntryCode.Enabled = false;
            this.txtEntryCode.Location = new System.Drawing.Point(268, 87);
            this.txtEntryCode.Name = "txtEntryCode";
            this.txtEntryCode.ReadOnly = true;
            this.txtEntryCode.Size = new System.Drawing.Size(276, 30);
            this.txtEntryCode.TabIndex = 6;
            this.txtEntryCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(59, 567);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(79, 25);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "Remark";
            this.lblRemark.Click += new System.EventHandler(this.lblRemark_Click);
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Location = new System.Drawing.Point(59, 472);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(144, 25);
            this.lblPaymentMode.TabIndex = 4;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(59, 377);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(80, 25);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblPaidTo
            // 
            this.lblPaidTo.AutoSize = true;
            this.lblPaidTo.Location = new System.Drawing.Point(59, 282);
            this.lblPaidTo.Name = "lblPaidTo";
            this.lblPaidTo.Size = new System.Drawing.Size(80, 25);
            this.lblPaidTo.TabIndex = 2;
            this.lblPaidTo.Text = "Paid To";
            // 
            // lblExpenseDate
            // 
            this.lblExpenseDate.AutoSize = true;
            this.lblExpenseDate.Location = new System.Drawing.Point(59, 187);
            this.lblExpenseDate.Name = "lblExpenseDate";
            this.lblExpenseDate.Size = new System.Drawing.Size(135, 25);
            this.lblExpenseDate.TabIndex = 1;
            this.lblExpenseDate.Text = "Expense Date";
            // 
            // lblEntryCode
            // 
            this.lblEntryCode.AutoSize = true;
            this.lblEntryCode.Location = new System.Drawing.Point(59, 92);
            this.lblEntryCode.Name = "lblEntryCode";
            this.lblEntryCode.Size = new System.Drawing.Size(110, 25);
            this.lblEntryCode.TabIndex = 0;
            this.lblEntryCode.Text = "Entry Code";
            // 
            // grpExpenseDetails
            // 
            this.grpExpenseDetails.BackColor = System.Drawing.Color.White;
            this.grpExpenseDetails.Controls.Add(this.dataGridView1);
            this.grpExpenseDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExpenseDetails.Location = new System.Drawing.Point(634, 104);
            this.grpExpenseDetails.Name = "grpExpenseDetails";
            this.grpExpenseDetails.Size = new System.Drawing.Size(1274, 765);
            this.grpExpenseDetails.TabIndex = 1;
            this.grpExpenseDetails.TabStop = false;
            this.grpExpenseDetails.Enter += new System.EventHandler(this.grpExpenseDetails_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryCodeDataGridViewTextBoxColumn,
            this.expenseDateDataGridViewTextBoxColumn,
            this.paidToDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentModeDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblExpenseEntryBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 736);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // entryCodeDataGridViewTextBoxColumn
            // 
            this.entryCodeDataGridViewTextBoxColumn.DataPropertyName = "EntryCode";
            this.entryCodeDataGridViewTextBoxColumn.HeaderText = "Entry Code";
            this.entryCodeDataGridViewTextBoxColumn.Name = "entryCodeDataGridViewTextBoxColumn";
            this.entryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryCodeDataGridViewTextBoxColumn.Width = 140;
            // 
            // expenseDateDataGridViewTextBoxColumn
            // 
            this.expenseDateDataGridViewTextBoxColumn.DataPropertyName = "ExpenseDate";
            this.expenseDateDataGridViewTextBoxColumn.HeaderText = "Expense Date";
            this.expenseDateDataGridViewTextBoxColumn.Name = "expenseDateDataGridViewTextBoxColumn";
            this.expenseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.expenseDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // paidToDataGridViewTextBoxColumn
            // 
            this.paidToDataGridViewTextBoxColumn.DataPropertyName = "PaidTo";
            this.paidToDataGridViewTextBoxColumn.HeaderText = "PaidTo";
            this.paidToDataGridViewTextBoxColumn.Name = "paidToDataGridViewTextBoxColumn";
            this.paidToDataGridViewTextBoxColumn.ReadOnly = true;
            this.paidToDataGridViewTextBoxColumn.Width = 150;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 130;
            // 
            // paymentModeDataGridViewTextBoxColumn
            // 
            this.paymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode";
            this.paymentModeDataGridViewTextBoxColumn.HeaderText = "Payment Mode";
            this.paymentModeDataGridViewTextBoxColumn.Name = "paymentModeDataGridViewTextBoxColumn";
            this.paymentModeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentModeDataGridViewTextBoxColumn.Width = 160;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "Remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.remarkDataGridViewTextBoxColumn.Width = 200;
            // 
            // tblExpenseEntryBindingSource2
            // 
            this.tblExpenseEntryBindingSource2.DataMember = "TblExpenseEntry";
            this.tblExpenseEntryBindingSource2.DataSource = this.petrolPumpDbDataSet23;
            // 
            // petrolPumpDbDataSet23
            // 
            this.petrolPumpDbDataSet23.DataSetName = "PetrolPumpDbDataSet23";
            this.petrolPumpDbDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblExpenseEntryBindingSource1
            // 
            this.tblExpenseEntryBindingSource1.DataMember = "TblExpenseEntry";
            this.tblExpenseEntryBindingSource1.DataSource = this.petrolPumpDbDataSet16;
            // 
            // petrolPumpDbDataSet16
            // 
            this.petrolPumpDbDataSet16.DataSetName = "PetrolPumpDbDataSet16";
            this.petrolPumpDbDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblExpenseEntryBindingSource
            // 
            this.tblExpenseEntryBindingSource.DataMember = "TblExpenseEntry";
            this.tblExpenseEntryBindingSource.DataSource = this.petrolPumpDbDataSet;
            // 
            // petrolPumpDbDataSet
            // 
            this.petrolPumpDbDataSet.DataSetName = "PetrolPumpDbDataSet";
            this.petrolPumpDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblExpenseEntryTableAdapter
            // 
            this.tblExpenseEntryTableAdapter.ClearBeforeFill = true;
            // 
            // tblExpenseEntryTableAdapter1
            // 
            this.tblExpenseEntryTableAdapter1.ClearBeforeFill = true;
            // 
            // tblExpenseEntryTableAdapter2
            // 
            this.tblExpenseEntryTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(774, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log daily expenses";
            // 
            // tblAddVehiclesTableAdapter1
            // 
            this.tblAddVehiclesTableAdapter1.ClearBeforeFill = true;
            // 
            // frmExpenseEntry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpExpenseDetails);
            this.Controls.Add(this.grpExpenseEntry);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmExpenseEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExpense_Load);
            this.grpExpenseEntry.ResumeLayout(false);
            this.grpExpenseEntry.PerformLayout();
            this.grpExpenseDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseEntryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseEntryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblExpenseEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExpenseEntry;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpense;
        private System.Windows.Forms.TextBox txtPaidTo;
        private System.Windows.Forms.TextBox txtEntryCode;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaidTo;
        private System.Windows.Forms.Label lblExpenseDate;
        private System.Windows.Forms.Label lblEntryCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpExpenseDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClear;
        private PetrolPumpDbDataSet petrolPumpDbDataSet;
        private System.Windows.Forms.BindingSource tblExpenseEntryBindingSource;
        private PetrolPumpDbDataSetTableAdapters.TblExpenseEntryTableAdapter tblExpenseEntryTableAdapter;
        private PetrolPumpDbDataSet16 petrolPumpDbDataSet16;
        private System.Windows.Forms.BindingSource tblExpenseEntryBindingSource1;
        private PetrolPumpDbDataSet16TableAdapters.TblExpenseEntryTableAdapter tblExpenseEntryTableAdapter1;
        private PetrolPumpDbDataSet23 petrolPumpDbDataSet23;
        private System.Windows.Forms.BindingSource tblExpenseEntryBindingSource2;
        private PetrolPumpDbDataSet23TableAdapters.TblExpenseEntryTableAdapter tblExpenseEntryTableAdapter2;
        private System.Windows.Forms.Label label1;
        private PetrolPumpDbDataSet21TableAdapters.TblAddVehiclesTableAdapter tblAddVehiclesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}