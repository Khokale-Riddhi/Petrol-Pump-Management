namespace PetrolPumpManagement
{
    partial class frmEmployeeMaster
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
            this.grpEmployeeMaster = new System.Windows.Forms.GroupBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMobileNo2 = new System.Windows.Forms.TextBox();
            this.txtMobileNo1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblMobileNo2 = new System.Windows.Forms.Label();
            this.lblMobileNo1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.grpEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEmployeeMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet1 = new PetrolPumpManagement.PetrolPumpDbDataSet1();
            this.tblEmployeeMasterTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet1TableAdapters.TblEmployeeMasterTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEmployeeMaster.SuspendLayout();
            this.grpEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEmployeeMaster
            // 
            this.grpEmployeeMaster.BackColor = System.Drawing.Color.White;
            this.grpEmployeeMaster.Controls.Add(this.cmbDesignation);
            this.grpEmployeeMaster.Controls.Add(this.btnClear);
            this.grpEmployeeMaster.Controls.Add(this.btnDelete);
            this.grpEmployeeMaster.Controls.Add(this.btnUpdate);
            this.grpEmployeeMaster.Controls.Add(this.btnSave);
            this.grpEmployeeMaster.Controls.Add(this.txtMobileNo2);
            this.grpEmployeeMaster.Controls.Add(this.txtMobileNo1);
            this.grpEmployeeMaster.Controls.Add(this.txtName);
            this.grpEmployeeMaster.Controls.Add(this.txtEmployeeCode);
            this.grpEmployeeMaster.Controls.Add(this.lblDesignation);
            this.grpEmployeeMaster.Controls.Add(this.lblMobileNo2);
            this.grpEmployeeMaster.Controls.Add(this.lblMobileNo1);
            this.grpEmployeeMaster.Controls.Add(this.lblName);
            this.grpEmployeeMaster.Controls.Add(this.lblEmployeeCode);
            this.grpEmployeeMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployeeMaster.Location = new System.Drawing.Point(16, 122);
            this.grpEmployeeMaster.Name = "grpEmployeeMaster";
            this.grpEmployeeMaster.Size = new System.Drawing.Size(612, 765);
            this.grpEmployeeMaster.TabIndex = 0;
            this.grpEmployeeMaster.TabStop = false;
            this.grpEmployeeMaster.Text = "Employee Entry";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.BackColor = System.Drawing.Color.White;
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Pump Manager",
            "Cashier",
            "Fuel Attendant",
            "Shift Supervior",
            "Technician",
            "Account Officer"});
            this.cmbDesignation.Location = new System.Drawing.Point(258, 519);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(276, 33);
            this.cmbDesignation.TabIndex = 9;
            this.cmbDesignation.SelectedIndexChanged += new System.EventHandler(this.cmbDesignation_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(463, 638);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 66);
            this.btnClear.TabIndex = 13;
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
            this.btnDelete.Location = new System.Drawing.Point(315, 638);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 66);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(167, 638);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 66);
            this.btnUpdate.TabIndex = 11;
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
            this.btnSave.Location = new System.Drawing.Point(19, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 66);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMobileNo2
            // 
            this.txtMobileNo2.Location = new System.Drawing.Point(258, 412);
            this.txtMobileNo2.Name = "txtMobileNo2";
            this.txtMobileNo2.Size = new System.Drawing.Size(276, 30);
            this.txtMobileNo2.TabIndex = 8;
            // 
            // txtMobileNo1
            // 
            this.txtMobileNo1.Location = new System.Drawing.Point(258, 305);
            this.txtMobileNo1.Name = "txtMobileNo1";
            this.txtMobileNo1.Size = new System.Drawing.Size(276, 30);
            this.txtMobileNo1.TabIndex = 7;
            this.txtMobileNo1.Leave += new System.EventHandler(this.txtMobileNo1_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(258, 198);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 30);
            this.txtName.TabIndex = 6;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Enabled = false;
            this.txtEmployeeCode.Location = new System.Drawing.Point(258, 91);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.ReadOnly = true;
            this.txtEmployeeCode.Size = new System.Drawing.Size(276, 30);
            this.txtEmployeeCode.TabIndex = 5;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(53, 524);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(115, 25);
            this.lblDesignation.TabIndex = 4;
            this.lblDesignation.Text = "Designation";
            // 
            // lblMobileNo2
            // 
            this.lblMobileNo2.AutoSize = true;
            this.lblMobileNo2.Location = new System.Drawing.Point(54, 417);
            this.lblMobileNo2.Name = "lblMobileNo2";
            this.lblMobileNo2.Size = new System.Drawing.Size(116, 25);
            this.lblMobileNo2.TabIndex = 3;
            this.lblMobileNo2.Text = "Mobile No 2";
            // 
            // lblMobileNo1
            // 
            this.lblMobileNo1.AutoSize = true;
            this.lblMobileNo1.Location = new System.Drawing.Point(54, 310);
            this.lblMobileNo1.Name = "lblMobileNo1";
            this.lblMobileNo1.Size = new System.Drawing.Size(116, 25);
            this.lblMobileNo1.TabIndex = 2;
            this.lblMobileNo1.Text = "Mobile No 1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 203);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Location = new System.Drawing.Point(53, 96);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(152, 25);
            this.lblEmployeeCode.TabIndex = 0;
            this.lblEmployeeCode.Text = "Employee Code";
            this.lblEmployeeCode.Click += new System.EventHandler(this.lblEmployeeCode_Click);
            // 
            // grpEmployeeDetails
            // 
            this.grpEmployeeDetails.BackColor = System.Drawing.Color.White;
            this.grpEmployeeDetails.Controls.Add(this.dataGridView1);
            this.grpEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmployeeDetails.Location = new System.Drawing.Point(634, 122);
            this.grpEmployeeDetails.Name = "grpEmployeeDetails";
            this.grpEmployeeDetails.Size = new System.Drawing.Size(1274, 765);
            this.grpEmployeeDetails.TabIndex = 1;
            this.grpEmployeeDetails.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNo1DataGridViewTextBoxColumn,
            this.mobileNo2DataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeeMasterBindingSource;
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
            // employeeCodeDataGridViewTextBoxColumn
            // 
            this.employeeCodeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCode";
            this.employeeCodeDataGridViewTextBoxColumn.HeaderText = "Employee Code";
            this.employeeCodeDataGridViewTextBoxColumn.Name = "employeeCodeDataGridViewTextBoxColumn";
            this.employeeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeCodeDataGridViewTextBoxColumn.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 210;
            // 
            // mobileNo1DataGridViewTextBoxColumn
            // 
            this.mobileNo1DataGridViewTextBoxColumn.DataPropertyName = "MobileNo1";
            this.mobileNo1DataGridViewTextBoxColumn.HeaderText = "Mobile No.1";
            this.mobileNo1DataGridViewTextBoxColumn.Name = "mobileNo1DataGridViewTextBoxColumn";
            this.mobileNo1DataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNo1DataGridViewTextBoxColumn.Width = 140;
            // 
            // mobileNo2DataGridViewTextBoxColumn
            // 
            this.mobileNo2DataGridViewTextBoxColumn.DataPropertyName = "MobileNo2";
            this.mobileNo2DataGridViewTextBoxColumn.HeaderText = "Mobile No.2";
            this.mobileNo2DataGridViewTextBoxColumn.Name = "mobileNo2DataGridViewTextBoxColumn";
            this.mobileNo2DataGridViewTextBoxColumn.ReadOnly = true;
            this.mobileNo2DataGridViewTextBoxColumn.Width = 140;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            this.designationDataGridViewTextBoxColumn.Width = 210;
            // 
            // tblEmployeeMasterBindingSource
            // 
            this.tblEmployeeMasterBindingSource.DataMember = "TblEmployeeMaster";
            this.tblEmployeeMasterBindingSource.DataSource = this.petrolPumpDbDataSet1;
            // 
            // petrolPumpDbDataSet1
            // 
            this.petrolPumpDbDataSet1.DataSetName = "PetrolPumpDbDataSet1";
            this.petrolPumpDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeMasterTableAdapter
            // 
            this.tblEmployeeMasterTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(673, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Store and manage employee details";
            // 
            // frmEmployeeMaster
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpEmployeeDetails);
            this.Controls.Add(this.grpEmployeeMaster);
            this.Name = "frmEmployeeMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEmployeeMaster_Load);
            this.Click += new System.EventHandler(this.frmEmployeeMaster_Click);
            this.grpEmployeeMaster.ResumeLayout(false);
            this.grpEmployeeMaster.PerformLayout();
            this.grpEmployeeDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployeeMaster;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMobileNo2;
        private System.Windows.Forms.TextBox txtMobileNo1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblMobileNo2;
        private System.Windows.Forms.Label lblMobileNo1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.GroupBox grpEmployeeDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PetrolPumpDbDataSet1 petrolPumpDbDataSet1;
        private System.Windows.Forms.BindingSource tblEmployeeMasterBindingSource;
        private PetrolPumpDbDataSet1TableAdapters.TblEmployeeMasterTableAdapter tblEmployeeMasterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}