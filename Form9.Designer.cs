namespace PetrolPumpManagement
{
    partial class frmDepositEntry
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
            this.grpDepositEntry = new System.Windows.Forms.GroupBox();
            this.txtNetPaid = new System.Windows.Forms.TextBox();
            this.lblNetPaid = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDepositEntry = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtBalace = new System.Windows.Forms.TextBox();
            this.txtNowPayingAmount = new System.Windows.Forms.TextBox();
            this.txtNetBalance = new System.Windows.Forms.TextBox();
            this.txtNetCredit = new System.Windows.Forms.TextBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.txtEntryCode = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblNowPayingAmount = new System.Windows.Forms.Label();
            this.lblNetBalance = new System.Windows.Forms.Label();
            this.lblNetCredit = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEntryCode = new System.Windows.Forms.Label();
            this.grpDepositDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.entryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netBalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowPayingAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDepositEntryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet20 = new PetrolPumpManagement.PetrolPumpDbDataSet20();
            this.tblDepositEntryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet9 = new PetrolPumpManagement.PetrolPumpDbDataSet9();
            this.tblDepositEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet7 = new PetrolPumpManagement.PetrolPumpDbDataSet7();
            this.tblDepositEntryTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet7TableAdapters.TblDepositEntryTableAdapter();
            this.tblDepositEntryTableAdapter1 = new PetrolPumpManagement.PetrolPumpDbDataSet9TableAdapters.TblDepositEntryTableAdapter();
            this.tblDepositEntryTableAdapter2 = new PetrolPumpManagement.PetrolPumpDbDataSet20TableAdapters.TblDepositEntryTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDepositEntry.SuspendLayout();
            this.grpDepositDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositEntryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositEntryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDepositEntry
            // 
            this.grpDepositEntry.BackColor = System.Drawing.Color.White;
            this.grpDepositEntry.Controls.Add(this.txtNetPaid);
            this.grpDepositEntry.Controls.Add(this.lblNetPaid);
            this.grpDepositEntry.Controls.Add(this.btnUpdate);
            this.grpDepositEntry.Controls.Add(this.btnSave);
            this.grpDepositEntry.Controls.Add(this.btnClear);
            this.grpDepositEntry.Controls.Add(this.btnDelete);
            this.grpDepositEntry.Controls.Add(this.cmbPaymentMode);
            this.grpDepositEntry.Controls.Add(this.dateTimePickerDepositEntry);
            this.grpDepositEntry.Controls.Add(this.txtNote);
            this.grpDepositEntry.Controls.Add(this.txtBalace);
            this.grpDepositEntry.Controls.Add(this.txtNowPayingAmount);
            this.grpDepositEntry.Controls.Add(this.txtNetBalance);
            this.grpDepositEntry.Controls.Add(this.txtNetCredit);
            this.grpDepositEntry.Controls.Add(this.txtCustomerCode);
            this.grpDepositEntry.Controls.Add(this.txtContactPerson);
            this.grpDepositEntry.Controls.Add(this.txtEntryCode);
            this.grpDepositEntry.Controls.Add(this.lblNote);
            this.grpDepositEntry.Controls.Add(this.lblPaymentMode);
            this.grpDepositEntry.Controls.Add(this.lblBalance);
            this.grpDepositEntry.Controls.Add(this.lblNowPayingAmount);
            this.grpDepositEntry.Controls.Add(this.lblNetBalance);
            this.grpDepositEntry.Controls.Add(this.lblNetCredit);
            this.grpDepositEntry.Controls.Add(this.lblCustomerCode);
            this.grpDepositEntry.Controls.Add(this.lblContactPerson);
            this.grpDepositEntry.Controls.Add(this.lblDate);
            this.grpDepositEntry.Controls.Add(this.lblEntryCode);
            this.grpDepositEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepositEntry.Location = new System.Drawing.Point(12, 118);
            this.grpDepositEntry.Name = "grpDepositEntry";
            this.grpDepositEntry.Size = new System.Drawing.Size(612, 765);
            this.grpDepositEntry.TabIndex = 0;
            this.grpDepositEntry.TabStop = false;
            this.grpDepositEntry.Text = "DepositEntry";
            this.grpDepositEntry.Enter += new System.EventHandler(this.grpDepositEntry_Enter);
            // 
            // txtNetPaid
            // 
            this.txtNetPaid.Location = new System.Drawing.Point(271, 440);
            this.txtNetPaid.Name = "txtNetPaid";
            this.txtNetPaid.ReadOnly = true;
            this.txtNetPaid.Size = new System.Drawing.Size(276, 30);
            this.txtNetPaid.TabIndex = 18;
            this.txtNetPaid.TabStop = false;
            // 
            // lblNetPaid
            // 
            this.lblNetPaid.AutoSize = true;
            this.lblNetPaid.Location = new System.Drawing.Point(68, 450);
            this.lblNetPaid.Name = "lblNetPaid";
            this.lblNetPaid.Size = new System.Drawing.Size(86, 25);
            this.lblNetPaid.TabIndex = 26;
            this.lblNetPaid.Text = "Net Paid";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(164, 666);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 66);
            this.btnUpdate.TabIndex = 23;
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
            this.btnSave.Location = new System.Drawing.Point(18, 666);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 66);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(456, 666);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 66);
            this.btnClear.TabIndex = 25;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(310, 666);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 66);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Cash",
            "Online"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(271, 546);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(276, 33);
            this.cmbPaymentMode.TabIndex = 20;
            // 
            // dateTimePickerDepositEntry
            // 
            this.dateTimePickerDepositEntry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDepositEntry.Location = new System.Drawing.Point(271, 114);
            this.dateTimePickerDepositEntry.Name = "dateTimePickerDepositEntry";
            this.dateTimePickerDepositEntry.Size = new System.Drawing.Size(276, 30);
            this.dateTimePickerDepositEntry.TabIndex = 12;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(271, 603);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(276, 30);
            this.txtNote.TabIndex = 21;
            // 
            // txtBalace
            // 
            this.txtBalace.Location = new System.Drawing.Point(271, 492);
            this.txtBalace.Name = "txtBalace";
            this.txtBalace.ReadOnly = true;
            this.txtBalace.Size = new System.Drawing.Size(276, 30);
            this.txtBalace.TabIndex = 19;
            this.txtBalace.TabStop = false;
            // 
            // txtNowPayingAmount
            // 
            this.txtNowPayingAmount.Location = new System.Drawing.Point(271, 332);
            this.txtNowPayingAmount.Name = "txtNowPayingAmount";
            this.txtNowPayingAmount.Size = new System.Drawing.Size(276, 30);
            this.txtNowPayingAmount.TabIndex = 16;
            this.txtNowPayingAmount.TextChanged += new System.EventHandler(this.txtNowPayingAmount_TextChanged);
            this.txtNowPayingAmount.Leave += new System.EventHandler(this.txtNowPayingAmount_Leave);
            // 
            // txtNetBalance
            // 
            this.txtNetBalance.Location = new System.Drawing.Point(271, 384);
            this.txtNetBalance.Name = "txtNetBalance";
            this.txtNetBalance.ReadOnly = true;
            this.txtNetBalance.Size = new System.Drawing.Size(276, 30);
            this.txtNetBalance.TabIndex = 17;
            this.txtNetBalance.TabStop = false;
            // 
            // txtNetCredit
            // 
            this.txtNetCredit.Location = new System.Drawing.Point(271, 276);
            this.txtNetCredit.Name = "txtNetCredit";
            this.txtNetCredit.ReadOnly = true;
            this.txtNetCredit.Size = new System.Drawing.Size(276, 30);
            this.txtNetCredit.TabIndex = 15;
            this.txtNetCredit.TabStop = false;
            this.txtNetCredit.Leave += new System.EventHandler(this.txtNetCredit_Leave);
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(271, 222);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(276, 30);
            this.txtCustomerCode.TabIndex = 14;
            this.txtCustomerCode.TabStop = false;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(271, 168);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(276, 30);
            this.txtContactPerson.TabIndex = 13;
            this.txtContactPerson.Leave += new System.EventHandler(this.txtContactPerson_Leave);
            // 
            // txtEntryCode
            // 
            this.txtEntryCode.Enabled = false;
            this.txtEntryCode.Location = new System.Drawing.Point(271, 60);
            this.txtEntryCode.Name = "txtEntryCode";
            this.txtEntryCode.ReadOnly = true;
            this.txtEntryCode.Size = new System.Drawing.Size(276, 30);
            this.txtEntryCode.TabIndex = 11;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(68, 615);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(53, 25);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "Note";
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Location = new System.Drawing.Point(66, 560);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(144, 25);
            this.lblPaymentMode.TabIndex = 8;
            this.lblPaymentMode.Text = "Payment Mode";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(66, 505);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(83, 25);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Balance";
            // 
            // lblNowPayingAmount
            // 
            this.lblNowPayingAmount.AutoSize = true;
            this.lblNowPayingAmount.Location = new System.Drawing.Point(68, 337);
            this.lblNowPayingAmount.Name = "lblNowPayingAmount";
            this.lblNowPayingAmount.Size = new System.Drawing.Size(189, 25);
            this.lblNowPayingAmount.TabIndex = 6;
            this.lblNowPayingAmount.Text = "Now Paying Amount";
            // 
            // lblNetBalance
            // 
            this.lblNetBalance.AutoSize = true;
            this.lblNetBalance.Location = new System.Drawing.Point(68, 395);
            this.lblNetBalance.Name = "lblNetBalance";
            this.lblNetBalance.Size = new System.Drawing.Size(118, 25);
            this.lblNetBalance.TabIndex = 5;
            this.lblNetBalance.Text = "Net Balance";
            // 
            // lblNetCredit
            // 
            this.lblNetCredit.AutoSize = true;
            this.lblNetCredit.Location = new System.Drawing.Point(68, 285);
            this.lblNetCredit.Name = "lblNetCredit";
            this.lblNetCredit.Size = new System.Drawing.Size(99, 25);
            this.lblNetCredit.TabIndex = 4;
            this.lblNetCredit.Text = "Net Credit";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(68, 230);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(150, 25);
            this.lblCustomerCode.TabIndex = 3;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(66, 175);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(147, 25);
            this.lblContactPerson.TabIndex = 2;
            this.lblContactPerson.Text = "Contact Person";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(66, 120);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblEntryCode
            // 
            this.lblEntryCode.AutoSize = true;
            this.lblEntryCode.Location = new System.Drawing.Point(66, 65);
            this.lblEntryCode.Name = "lblEntryCode";
            this.lblEntryCode.Size = new System.Drawing.Size(110, 25);
            this.lblEntryCode.TabIndex = 0;
            this.lblEntryCode.Text = "Entry Code";
            // 
            // grpDepositDetails
            // 
            this.grpDepositDetails.BackColor = System.Drawing.Color.White;
            this.grpDepositDetails.Controls.Add(this.dataGridView1);
            this.grpDepositDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepositDetails.Location = new System.Drawing.Point(630, 118);
            this.grpDepositDetails.Name = "grpDepositDetails";
            this.grpDepositDetails.Size = new System.Drawing.Size(1282, 765);
            this.grpDepositDetails.TabIndex = 1;
            this.grpDepositDetails.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryCodeDataGridViewTextBoxColumn,
            this.depositDateDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.customerCodeDataGridViewTextBoxColumn,
            this.netCreditDataGridViewTextBoxColumn,
            this.netPaidDataGridViewTextBoxColumn,
            this.netBalanceDataGridViewTextBoxColumn,
            this.nowPayingAmountDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.paymentModeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDepositEntryBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 736);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // entryCodeDataGridViewTextBoxColumn
            // 
            this.entryCodeDataGridViewTextBoxColumn.DataPropertyName = "EntryCode";
            this.entryCodeDataGridViewTextBoxColumn.HeaderText = "Entry Code";
            this.entryCodeDataGridViewTextBoxColumn.Name = "entryCodeDataGridViewTextBoxColumn";
            this.entryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.entryCodeDataGridViewTextBoxColumn.Width = 134;
            // 
            // depositDateDataGridViewTextBoxColumn
            // 
            this.depositDateDataGridViewTextBoxColumn.DataPropertyName = "DepositDate";
            this.depositDateDataGridViewTextBoxColumn.HeaderText = "Deposit Date";
            this.depositDateDataGridViewTextBoxColumn.Name = "depositDateDataGridViewTextBoxColumn";
            this.depositDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.depositDateDataGridViewTextBoxColumn.Width = 147;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "Contact Person";
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactPersonDataGridViewTextBoxColumn.Width = 168;
            // 
            // customerCodeDataGridViewTextBoxColumn
            // 
            this.customerCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerCode";
            this.customerCodeDataGridViewTextBoxColumn.HeaderText = "Customer Code";
            this.customerCodeDataGridViewTextBoxColumn.Name = "customerCodeDataGridViewTextBoxColumn";
            this.customerCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCodeDataGridViewTextBoxColumn.Width = 170;
            // 
            // netCreditDataGridViewTextBoxColumn
            // 
            this.netCreditDataGridViewTextBoxColumn.DataPropertyName = "NetCredit";
            this.netCreditDataGridViewTextBoxColumn.HeaderText = "Net Credit";
            this.netCreditDataGridViewTextBoxColumn.Name = "netCreditDataGridViewTextBoxColumn";
            this.netCreditDataGridViewTextBoxColumn.ReadOnly = true;
            this.netCreditDataGridViewTextBoxColumn.Width = 125;
            // 
            // netPaidDataGridViewTextBoxColumn
            // 
            this.netPaidDataGridViewTextBoxColumn.DataPropertyName = "NetPaid";
            this.netPaidDataGridViewTextBoxColumn.HeaderText = "Net Paid";
            this.netPaidDataGridViewTextBoxColumn.Name = "netPaidDataGridViewTextBoxColumn";
            this.netPaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.netPaidDataGridViewTextBoxColumn.Width = 113;
            // 
            // netBalanceDataGridViewTextBoxColumn
            // 
            this.netBalanceDataGridViewTextBoxColumn.DataPropertyName = "NetBalance";
            this.netBalanceDataGridViewTextBoxColumn.HeaderText = "Net Balance";
            this.netBalanceDataGridViewTextBoxColumn.Name = "netBalanceDataGridViewTextBoxColumn";
            this.netBalanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.netBalanceDataGridViewTextBoxColumn.Width = 142;
            // 
            // nowPayingAmountDataGridViewTextBoxColumn
            // 
            this.nowPayingAmountDataGridViewTextBoxColumn.DataPropertyName = "NowPayingAmount";
            this.nowPayingAmountDataGridViewTextBoxColumn.HeaderText = "PayingAmount";
            this.nowPayingAmountDataGridViewTextBoxColumn.Name = "nowPayingAmountDataGridViewTextBoxColumn";
            this.nowPayingAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.nowPayingAmountDataGridViewTextBoxColumn.Width = 176;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.balanceDataGridViewTextBoxColumn.Width = 119;
            // 
            // paymentModeDataGridViewTextBoxColumn
            // 
            this.paymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode";
            this.paymentModeDataGridViewTextBoxColumn.HeaderText = "Payment Mode";
            this.paymentModeDataGridViewTextBoxColumn.Name = "paymentModeDataGridViewTextBoxColumn";
            this.paymentModeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentModeDataGridViewTextBoxColumn.Width = 165;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 89;
            // 
            // tblDepositEntryBindingSource2
            // 
            this.tblDepositEntryBindingSource2.DataMember = "TblDepositEntry";
            this.tblDepositEntryBindingSource2.DataSource = this.petrolPumpDbDataSet20;
            // 
            // petrolPumpDbDataSet20
            // 
            this.petrolPumpDbDataSet20.DataSetName = "PetrolPumpDbDataSet20";
            this.petrolPumpDbDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepositEntryBindingSource1
            // 
            this.tblDepositEntryBindingSource1.DataMember = "TblDepositEntry";
            this.tblDepositEntryBindingSource1.DataSource = this.petrolPumpDbDataSet9;
            // 
            // petrolPumpDbDataSet9
            // 
            this.petrolPumpDbDataSet9.DataSetName = "PetrolPumpDbDataSet9";
            this.petrolPumpDbDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepositEntryBindingSource
            // 
            this.tblDepositEntryBindingSource.DataMember = "TblDepositEntry";
            this.tblDepositEntryBindingSource.DataSource = this.petrolPumpDbDataSet7;
            // 
            // petrolPumpDbDataSet7
            // 
            this.petrolPumpDbDataSet7.DataSetName = "PetrolPumpDbDataSet7";
            this.petrolPumpDbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepositEntryTableAdapter
            // 
            this.tblDepositEntryTableAdapter.ClearBeforeFill = true;
            // 
            // tblDepositEntryTableAdapter1
            // 
            this.tblDepositEntryTableAdapter1.ClearBeforeFill = true;
            // 
            // tblDepositEntryTableAdapter2
            // 
            this.tblDepositEntryTableAdapter2.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(664, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deposit details of customer payment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmDepositEntry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpDepositDetails);
            this.Controls.Add(this.grpDepositEntry);
            this.Name = "frmDepositEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDepositEntry_Load);
            this.grpDepositEntry.ResumeLayout(false);
            this.grpDepositEntry.PerformLayout();
            this.grpDepositDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositEntryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositEntryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepositEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDepositEntry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepositEntry;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtBalace;
        private System.Windows.Forms.TextBox txtNowPayingAmount;
        private System.Windows.Forms.TextBox txtNetBalance;
        private System.Windows.Forms.TextBox txtNetCredit;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.TextBox txtEntryCode;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblNowPayingAmount;
        private System.Windows.Forms.Label lblNetBalance;
        private System.Windows.Forms.Label lblNetCredit;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEntryCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpDepositDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PetrolPumpDbDataSet7 petrolPumpDbDataSet7;
        private System.Windows.Forms.BindingSource tblDepositEntryBindingSource;
        private PetrolPumpDbDataSet7TableAdapters.TblDepositEntryTableAdapter tblDepositEntryTableAdapter;
        private PetrolPumpDbDataSet9 petrolPumpDbDataSet9;
        private System.Windows.Forms.BindingSource tblDepositEntryBindingSource1;
        private PetrolPumpDbDataSet9TableAdapters.TblDepositEntryTableAdapter tblDepositEntryTableAdapter1;
        private PetrolPumpDbDataSet20 petrolPumpDbDataSet20;
        private System.Windows.Forms.BindingSource tblDepositEntryBindingSource2;
        private PetrolPumpDbDataSet20TableAdapters.TblDepositEntryTableAdapter tblDepositEntryTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netBalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowPayingAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNetPaid;
        private System.Windows.Forms.Label lblNetPaid;
    }
}