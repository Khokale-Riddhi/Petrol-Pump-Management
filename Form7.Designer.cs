namespace PetrolPumpManagement
{
    partial class frmAddVehicles
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
            this.grpVehicleEntry = new System.Windows.Forms.GroupBox();
            this.txtCustomerCode = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.txtVehicleId = new System.Windows.Forms.TextBox();
            this.lblVehicleNo = new System.Windows.Forms.Label();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.grpVehicleDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAddVehiclesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet21 = new PetrolPumpManagement.PetrolPumpDbDataSet21();
            this.tblAddVehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet3 = new PetrolPumpManagement.PetrolPumpDbDataSet3();
            this.tblAddVehiclesTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet3TableAdapters.TblAddVehiclesTableAdapter();
            this.tblAddVehiclesTableAdapter1 = new PetrolPumpManagement.PetrolPumpDbDataSet21TableAdapters.TblAddVehiclesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.grpVehicleEntry.SuspendLayout();
            this.grpVehicleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddVehiclesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddVehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVehicleEntry
            // 
            this.grpVehicleEntry.BackColor = System.Drawing.Color.White;
            this.grpVehicleEntry.Controls.Add(this.txtCustomerCode);
            this.grpVehicleEntry.Controls.Add(this.btnClear);
            this.grpVehicleEntry.Controls.Add(this.btnDelete);
            this.grpVehicleEntry.Controls.Add(this.btnUpdate);
            this.grpVehicleEntry.Controls.Add(this.btnSave);
            this.grpVehicleEntry.Controls.Add(this.txtVehicleNo);
            this.grpVehicleEntry.Controls.Add(this.txtVehicleId);
            this.grpVehicleEntry.Controls.Add(this.lblVehicleNo);
            this.grpVehicleEntry.Controls.Add(this.lblVehicleId);
            this.grpVehicleEntry.Controls.Add(this.lblCustomerCode);
            this.grpVehicleEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVehicleEntry.Location = new System.Drawing.Point(16, 115);
            this.grpVehicleEntry.Name = "grpVehicleEntry";
            this.grpVehicleEntry.Size = new System.Drawing.Size(612, 765);
            this.grpVehicleEntry.TabIndex = 0;
            this.grpVehicleEntry.TabStop = false;
            this.grpVehicleEntry.Text = "Vehicle Entry";
            // 
            // txtCustomerCode
            // 
            this.txtCustomerCode.Location = new System.Drawing.Point(223, 286);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.Size = new System.Drawing.Size(276, 30);
            this.txtCustomerCode.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(448, 571);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 66);
            this.btnClear.TabIndex = 17;
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
            this.btnDelete.Location = new System.Drawing.Point(310, 571);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 66);
            this.btnDelete.TabIndex = 16;
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
            this.btnUpdate.Location = new System.Drawing.Point(172, 571);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 66);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(34, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 66);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(223, 414);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(276, 30);
            this.txtVehicleNo.TabIndex = 13;
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Enabled = false;
            this.txtVehicleId.Location = new System.Drawing.Point(223, 158);
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.ReadOnly = true;
            this.txtVehicleId.Size = new System.Drawing.Size(276, 30);
            this.txtVehicleId.TabIndex = 11;
            // 
            // lblVehicleNo
            // 
            this.lblVehicleNo.AutoSize = true;
            this.lblVehicleNo.Location = new System.Drawing.Point(37, 419);
            this.lblVehicleNo.Name = "lblVehicleNo";
            this.lblVehicleNo.Size = new System.Drawing.Size(107, 25);
            this.lblVehicleNo.TabIndex = 2;
            this.lblVehicleNo.Text = "Vehicle No";
            // 
            // lblVehicleId
            // 
            this.lblVehicleId.AutoSize = true;
            this.lblVehicleId.Location = new System.Drawing.Point(37, 163);
            this.lblVehicleId.Name = "lblVehicleId";
            this.lblVehicleId.Size = new System.Drawing.Size(98, 25);
            this.lblVehicleId.TabIndex = 1;
            this.lblVehicleId.Text = "Vehicle Id";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Location = new System.Drawing.Point(37, 291);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(150, 25);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "Customer Code";
            // 
            // grpVehicleDetails
            // 
            this.grpVehicleDetails.BackColor = System.Drawing.Color.White;
            this.grpVehicleDetails.Controls.Add(this.dataGridView1);
            this.grpVehicleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVehicleDetails.Location = new System.Drawing.Point(634, 115);
            this.grpVehicleDetails.Name = "grpVehicleDetails";
            this.grpVehicleDetails.Size = new System.Drawing.Size(1274, 765);
            this.grpVehicleDetails.TabIndex = 1;
            this.grpVehicleDetails.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIdDataGridViewTextBoxColumn,
            this.customerCodeDataGridViewTextBoxColumn,
            this.vehicleNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAddVehiclesBindingSource1;
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
            // vehicleIdDataGridViewTextBoxColumn
            // 
            this.vehicleIdDataGridViewTextBoxColumn.DataPropertyName = "VehicleId";
            this.vehicleIdDataGridViewTextBoxColumn.HeaderText = "Vehicle Id";
            this.vehicleIdDataGridViewTextBoxColumn.Name = "vehicleIdDataGridViewTextBoxColumn";
            this.vehicleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleIdDataGridViewTextBoxColumn.Width = 265;
            // 
            // customerCodeDataGridViewTextBoxColumn
            // 
            this.customerCodeDataGridViewTextBoxColumn.DataPropertyName = "CustomerCode";
            this.customerCodeDataGridViewTextBoxColumn.HeaderText = "Customer Code";
            this.customerCodeDataGridViewTextBoxColumn.Name = "customerCodeDataGridViewTextBoxColumn";
            this.customerCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerCodeDataGridViewTextBoxColumn.Width = 265;
            // 
            // vehicleNoDataGridViewTextBoxColumn
            // 
            this.vehicleNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleNo";
            this.vehicleNoDataGridViewTextBoxColumn.HeaderText = "Vehicle No";
            this.vehicleNoDataGridViewTextBoxColumn.Name = "vehicleNoDataGridViewTextBoxColumn";
            this.vehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleNoDataGridViewTextBoxColumn.Width = 275;
            // 
            // tblAddVehiclesBindingSource1
            // 
            this.tblAddVehiclesBindingSource1.DataMember = "TblAddVehicles";
            this.tblAddVehiclesBindingSource1.DataSource = this.petrolPumpDbDataSet21;
            // 
            // petrolPumpDbDataSet21
            // 
            this.petrolPumpDbDataSet21.DataSetName = "PetrolPumpDbDataSet21";
            this.petrolPumpDbDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAddVehiclesBindingSource
            // 
            this.tblAddVehiclesBindingSource.DataMember = "TblAddVehicles";
            this.tblAddVehiclesBindingSource.DataSource = this.petrolPumpDbDataSet3;
            // 
            // petrolPumpDbDataSet3
            // 
            this.petrolPumpDbDataSet3.DataSetName = "PetrolPumpDbDataSet3";
            this.petrolPumpDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAddVehiclesTableAdapter
            // 
            this.tblAddVehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // tblAddVehiclesTableAdapter1
            // 
            this.tblAddVehiclesTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(723, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add vehicles with customers";
            // 
            // frmAddVehicles
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpVehicleDetails);
            this.Controls.Add(this.grpVehicleEntry);
            this.Name = "frmAddVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicles";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddVehicles_Load);
            this.grpVehicleEntry.ResumeLayout(false);
            this.grpVehicleEntry.PerformLayout();
            this.grpVehicleDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddVehiclesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddVehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVehicleEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.TextBox txtVehicleId;
        private System.Windows.Forms.Label lblVehicleNo;
        private System.Windows.Forms.Label lblVehicleId;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.GroupBox grpVehicleDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private PetrolPumpDbDataSet3 petrolPumpDbDataSet3;
        private System.Windows.Forms.BindingSource tblAddVehiclesBindingSource;
        private PetrolPumpDbDataSet3TableAdapters.TblAddVehiclesTableAdapter tblAddVehiclesTableAdapter;
        private PetrolPumpDbDataSet21 petrolPumpDbDataSet21;
        private System.Windows.Forms.BindingSource tblAddVehiclesBindingSource1;
        private PetrolPumpDbDataSet21TableAdapters.TblAddVehiclesTableAdapter tblAddVehiclesTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNoDataGridViewTextBoxColumn;
    }
}