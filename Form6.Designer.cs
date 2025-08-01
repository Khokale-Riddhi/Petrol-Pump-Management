namespace PetrolPumpManagement
{
    partial class frmCustomerMaster
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
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet2 = new PetrolPumpManagement.PetrolPumpDbDataSet2();
            this.tblCustomerMasterTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet2TableAdapters.TblCustomerMasterTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.lblFirmName = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMobileNo1 = new System.Windows.Forms.Label();
            this.lblMobileNo2 = new System.Windows.Forms.Label();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobileNo1 = new System.Windows.Forms.TextBox();
            this.txtMobileNo2 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpCustomerEntry = new System.Windows.Forms.GroupBox();
            this.grpCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet2)).BeginInit();
            this.grpCustomerEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.BackColor = System.Drawing.Color.White;
            this.grpCustomerDetails.Controls.Add(this.dataGridView1);
            this.grpCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerDetails.Location = new System.Drawing.Point(634, 125);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(1274, 765);
            this.grpCustomerDetails.TabIndex = 1;
            this.grpCustomerDetails.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerCodeDataGridViewTextBoxColumn,
            this.firmNameDataGridViewTextBoxColumn,
            this.ownerNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobileNo1DataGridViewTextBoxColumn,
            this.mobileNo2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCustomerMasterBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1268, 736);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // customerCodeDataGridViewTextBoxColumn
            // 
            this.customerCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerCode";
            this.customerCodeDataGridViewTextBoxColumn.HeaderText = "Customer Code";
            this.customerCodeDataGridViewTextBoxColumn.Name = "customerCodeDataGridViewTextBoxColumn";
            this.customerCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // firmNameDataGridViewTextBoxColumn
            // 
            this.firmNameDataGridViewTextBoxColumn.DataPropertyName = "FirmName";
            this.firmNameDataGridViewTextBoxColumn.HeaderText = "Firm Name";
            this.firmNameDataGridViewTextBoxColumn.Name = "firmNameDataGridViewTextBoxColumn";
            this.firmNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // ownerNameDataGridViewTextBoxColumn
            // 
            this.ownerNameDataGridViewTextBoxColumn.DataPropertyName = "OwnerName";
            this.ownerNameDataGridViewTextBoxColumn.HeaderText = "Owner Name";
            this.ownerNameDataGridViewTextBoxColumn.Name = "ownerNameDataGridViewTextBoxColumn";
            this.ownerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // mobileNo1DataGridViewTextBoxColumn
            // 
            this.mobileNo1DataGridViewTextBoxColumn.DataPropertyName = "MobileNo1";
            this.mobileNo1DataGridViewTextBoxColumn.HeaderText = "Mobile No.1";
            this.mobileNo1DataGridViewTextBoxColumn.Name = "mobileNo1DataGridViewTextBoxColumn";
            this.mobileNo1DataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNo1DataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileNo2DataGridViewTextBoxColumn
            // 
            this.mobileNo2DataGridViewTextBoxColumn.DataPropertyName = "MobileNo2";
            this.mobileNo2DataGridViewTextBoxColumn.HeaderText = "Mobile No.2";
            this.mobileNo2DataGridViewTextBoxColumn.Name = "mobileNo2DataGridViewTextBoxColumn";
            this.mobileNo2DataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNo2DataGridViewTextBoxColumn.Width = 150;
            // 
            // tblCustomerMasterBindingSource
            // 
            this.tblCustomerMasterBindingSource.DataMember = "TblCustomerMaster";
            this.tblCustomerMasterBindingSource.DataSource = this.petrolPumpDbDataSet2;
            // 
            // petrolPumpDbDataSet2
            // 
            this.petrolPumpDbDataSet2.DataSetName = "PetrolPumpDbDataSet2";
            this.petrolPumpDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerMasterTableAdapter
            // 
            this.tblCustomerMasterTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(775, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store customer information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(32, 115);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(150, 25);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // lblFirmName
            // 
            this.lblFirmName.AutoSize = true;
            this.lblFirmName.Location = new System.Drawing.Point(32, 182);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(107, 25);
            this.lblFirmName.TabIndex = 1;
            this.lblFirmName.Text = "Firm Name";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(32, 249);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(127, 25);
            this.lblOwnerName.TabIndex = 2;
            this.lblOwnerName.Text = "Owner Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(32, 311);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblMobileNo1
            // 
            this.lblMobileNo1.AutoSize = true;
            this.lblMobileNo1.Location = new System.Drawing.Point(32, 470);
            this.lblMobileNo1.Name = "lblMobileNo1";
            this.lblMobileNo1.Size = new System.Drawing.Size(116, 25);
            this.lblMobileNo1.TabIndex = 4;
            this.lblMobileNo1.Text = "Mobile No 1";
            // 
            // lblMobileNo2
            // 
            this.lblMobileNo2.AutoSize = true;
            this.lblMobileNo2.Location = new System.Drawing.Point(32, 537);
            this.lblMobileNo2.Name = "lblMobileNo2";
            this.lblMobileNo2.Size = new System.Drawing.Size(116, 25);
            this.lblMobileNo2.TabIndex = 5;
            this.lblMobileNo2.Text = "Mobile No 2";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Enabled = false;
            this.txtCustomerCode.Location = new System.Drawing.Point(253, 110);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(276, 30);
            this.txtCustomerCode.TabIndex = 6;
            this.txtCustomerCode.TextChanged += new System.EventHandler(this.txtCustomerCode_TextChanged);
            // 
            // txtFirmName
            // 
            this.txtFirmName.Location = new System.Drawing.Point(253, 167);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(276, 30);
            this.txtFirmName.TabIndex = 7;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(253, 235);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(276, 30);
            this.txtOwnerName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(253, 311);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(276, 114);
            this.txtAddress.TabIndex = 9;
            // 
            // txtMobileNo1
            // 
            this.txtMobileNo1.Location = new System.Drawing.Point(253, 456);
            this.txtMobileNo1.Name = "txtMobileNo1";
            this.txtMobileNo1.Size = new System.Drawing.Size(276, 30);
            this.txtMobileNo1.TabIndex = 10;
            this.txtMobileNo1.Leave += new System.EventHandler(this.txtMobileNo1_Leave);
            // 
            // txtMobileNo2
            // 
            this.txtMobileNo2.Location = new System.Drawing.Point(253, 532);
            this.txtMobileNo2.Name = "txtMobileNo2";
            this.txtMobileNo2.Size = new System.Drawing.Size(276, 30);
            this.txtMobileNo2.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(22, 637);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 66);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(168, 637);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 66);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(314, 637);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 66);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(460, 637);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 66);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpCustomerEntry
            // 
            this.grpCustomerEntry.BackColor = System.Drawing.Color.White;
            this.grpCustomerEntry.Controls.Add(this.btnClear);
            this.grpCustomerEntry.Controls.Add(this.btnDelete);
            this.grpCustomerEntry.Controls.Add(this.btnUpdate);
            this.grpCustomerEntry.Controls.Add(this.btnSave);
            this.grpCustomerEntry.Controls.Add(this.txtMobileNo2);
            this.grpCustomerEntry.Controls.Add(this.txtMobileNo1);
            this.grpCustomerEntry.Controls.Add(this.txtAddress);
            this.grpCustomerEntry.Controls.Add(this.txtOwnerName);
            this.grpCustomerEntry.Controls.Add(this.txtFirmName);
            this.grpCustomerEntry.Controls.Add(this.txtCustomerCode);
            this.grpCustomerEntry.Controls.Add(this.lblMobileNo2);
            this.grpCustomerEntry.Controls.Add(this.lblMobileNo1);
            this.grpCustomerEntry.Controls.Add(this.lblAddress);
            this.grpCustomerEntry.Controls.Add(this.lblOwnerName);
            this.grpCustomerEntry.Controls.Add(this.lblFirmName);
            this.grpCustomerEntry.Controls.Add(this.lblCustomerCode);
            this.grpCustomerEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerEntry.Location = new System.Drawing.Point(16, 125);
            this.grpCustomerEntry.Name = "grpCustomerEntry";
            this.grpCustomerEntry.Size = new System.Drawing.Size(612, 765);
            this.grpCustomerEntry.TabIndex = 0;
            this.grpCustomerEntry.TabStop = false;
            this.grpCustomerEntry.Text = "Customer Entry";
            this.grpCustomerEntry.Enter += new System.EventHandler(this.grpCustomerEntry_Enter);
            // 
            // frmCustomerMaster
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCustomerDetails);
            this.Controls.Add(this.grpCustomerEntry);
            this.Name = "frmCustomerMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerMaster_Load);
            this.grpCustomerDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet2)).EndInit();
            this.grpCustomerEntry.ResumeLayout(false);
            this.grpCustomerEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PetrolPumpDbDataSet2 petrolPumpDbDataSet2;
        private System.Windows.Forms.BindingSource tblCustomerMasterBindingSource;
        private PetrolPumpDbDataSet2TableAdapters.TblCustomerMasterTableAdapter tblCustomerMasterTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.Label lblFirmName;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMobileNo1;
        private System.Windows.Forms.Label lblMobileNo2;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobileNo1;
        private System.Windows.Forms.TextBox txtMobileNo2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpCustomerEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo2DataGridViewTextBoxColumn;
    }
}