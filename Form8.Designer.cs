namespace PetrolPumpManagement
{
    partial class frmNozzleMaster
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
            this.grpNozzleEntry = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtOpeningReading = new System.Windows.Forms.TextBox();
            this.txtNozzleName = new System.Windows.Forms.TextBox();
            this.cmbSelectFuelType = new System.Windows.Forms.ComboBox();
            this.cmbSelectMPD = new System.Windows.Forms.ComboBox();
            this.txtNozzleCode = new System.Windows.Forms.TextBox();
            this.lblOpeningReading = new System.Windows.Forms.Label();
            this.lblNozzleName = new System.Windows.Forms.Label();
            this.lblSelectFuelType = new System.Windows.Forms.Label();
            this.lblSelectMPD = new System.Windows.Forms.Label();
            this.lblNozzleCode = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpNozzleDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nozzleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mPDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nozzleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingReadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNozzleMasterBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet24 = new PetrolPumpManagement.PetrolPumpDbDataSet24();
            this.tblNozzleMasterBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet22 = new PetrolPumpManagement.PetrolPumpDbDataSet22();
            this.tblNozzleMasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet18 = new PetrolPumpManagement.PetrolPumpDbDataSet18();
            this.tblNozzleMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolPumpDbDataSet4 = new PetrolPumpManagement.PetrolPumpDbDataSet4();
            this.tblNozzleMasterTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet4TableAdapters.TblNozzleMasterTableAdapter();
            this.tblNozzleMasterTableAdapter1 = new PetrolPumpManagement.PetrolPumpDbDataSet18TableAdapters.TblNozzleMasterTableAdapter();
            this.tblNozzleMasterTableAdapter2 = new PetrolPumpManagement.PetrolPumpDbDataSet22TableAdapters.TblNozzleMasterTableAdapter();
            this.tblNozzleMasterTableAdapter3 = new PetrolPumpManagement.PetrolPumpDbDataSet24TableAdapters.TblNozzleMasterTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.grpNozzleEntry.SuspendLayout();
            this.grpNozzleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNozzleEntry
            // 
            this.grpNozzleEntry.BackColor = System.Drawing.Color.White;
            this.grpNozzleEntry.Controls.Add(this.btnClear);
            this.grpNozzleEntry.Controls.Add(this.btnDelete);
            this.grpNozzleEntry.Controls.Add(this.btnUpdate);
            this.grpNozzleEntry.Controls.Add(this.btnSave);
            this.grpNozzleEntry.Controls.Add(this.txtOpeningReading);
            this.grpNozzleEntry.Controls.Add(this.txtNozzleName);
            this.grpNozzleEntry.Controls.Add(this.cmbSelectFuelType);
            this.grpNozzleEntry.Controls.Add(this.cmbSelectMPD);
            this.grpNozzleEntry.Controls.Add(this.txtNozzleCode);
            this.grpNozzleEntry.Controls.Add(this.lblOpeningReading);
            this.grpNozzleEntry.Controls.Add(this.lblNozzleName);
            this.grpNozzleEntry.Controls.Add(this.lblSelectFuelType);
            this.grpNozzleEntry.Controls.Add(this.lblSelectMPD);
            this.grpNozzleEntry.Controls.Add(this.lblNozzleCode);
            this.grpNozzleEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNozzleEntry.Location = new System.Drawing.Point(16, 112);
            this.grpNozzleEntry.Name = "grpNozzleEntry";
            this.grpNozzleEntry.Size = new System.Drawing.Size(612, 765);
            this.grpNozzleEntry.TabIndex = 0;
            this.grpNozzleEntry.TabStop = false;
            this.grpNozzleEntry.Text = "Nozzle Entry";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Teal;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(468, 636);
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
            this.btnDelete.Location = new System.Drawing.Point(318, 636);
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
            this.btnUpdate.Location = new System.Drawing.Point(168, 636);
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
            this.btnSave.Location = new System.Drawing.Point(18, 636);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 66);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOpeningReading
            // 
            this.txtOpeningReading.Location = new System.Drawing.Point(276, 503);
            this.txtOpeningReading.Name = "txtOpeningReading";
            this.txtOpeningReading.Size = new System.Drawing.Size(276, 30);
            this.txtOpeningReading.TabIndex = 9;
            // 
            // txtNozzleName
            // 
            this.txtNozzleName.Location = new System.Drawing.Point(276, 402);
            this.txtNozzleName.Name = "txtNozzleName";
            this.txtNozzleName.Size = new System.Drawing.Size(276, 30);
            this.txtNozzleName.TabIndex = 8;
            // 
            // cmbSelectFuelType
            // 
            this.cmbSelectFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectFuelType.FormattingEnabled = true;
            this.cmbSelectFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "CNG",
            "XtraPremium"});
            this.cmbSelectFuelType.Location = new System.Drawing.Point(276, 298);
            this.cmbSelectFuelType.Name = "cmbSelectFuelType";
            this.cmbSelectFuelType.Size = new System.Drawing.Size(276, 33);
            this.cmbSelectFuelType.TabIndex = 7;
            // 
            // cmbSelectMPD
            // 
            this.cmbSelectMPD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectMPD.FormattingEnabled = true;
            this.cmbSelectMPD.Items.AddRange(new object[] {
            "MPD1",
            "MPD2",
            "MPD3",
            "MPD4",
            "MPD5"});
            this.cmbSelectMPD.Location = new System.Drawing.Point(276, 194);
            this.cmbSelectMPD.Name = "cmbSelectMPD";
            this.cmbSelectMPD.Size = new System.Drawing.Size(276, 33);
            this.cmbSelectMPD.TabIndex = 6;
            this.cmbSelectMPD.TabStop = false;
            // 
            // txtNozzleCode
            // 
            this.txtNozzleCode.Enabled = false;
            this.txtNozzleCode.Location = new System.Drawing.Point(276, 93);
            this.txtNozzleCode.Name = "txtNozzleCode";
            this.txtNozzleCode.ReadOnly = true;
            this.txtNozzleCode.Size = new System.Drawing.Size(276, 30);
            this.txtNozzleCode.TabIndex = 5;
            // 
            // lblOpeningReading
            // 
            this.lblOpeningReading.AutoSize = true;
            this.lblOpeningReading.Location = new System.Drawing.Point(24, 508);
            this.lblOpeningReading.Name = "lblOpeningReading";
            this.lblOpeningReading.Size = new System.Drawing.Size(164, 25);
            this.lblOpeningReading.TabIndex = 4;
            this.lblOpeningReading.Text = "Opening Reading";
            // 
            // lblNozzleName
            // 
            this.lblNozzleName.AutoSize = true;
            this.lblNozzleName.Location = new System.Drawing.Point(24, 407);
            this.lblNozzleName.Name = "lblNozzleName";
            this.lblNozzleName.Size = new System.Drawing.Size(129, 25);
            this.lblNozzleName.TabIndex = 3;
            this.lblNozzleName.Text = "Nozzle Name";
            // 
            // lblSelectFuelType
            // 
            this.lblSelectFuelType.AutoSize = true;
            this.lblSelectFuelType.Location = new System.Drawing.Point(24, 301);
            this.lblSelectFuelType.Name = "lblSelectFuelType";
            this.lblSelectFuelType.Size = new System.Drawing.Size(160, 25);
            this.lblSelectFuelType.TabIndex = 2;
            this.lblSelectFuelType.Text = "Select Fuel Type";
            // 
            // lblSelectMPD
            // 
            this.lblSelectMPD.AutoSize = true;
            this.lblSelectMPD.Location = new System.Drawing.Point(24, 202);
            this.lblSelectMPD.Name = "lblSelectMPD";
            this.lblSelectMPD.Size = new System.Drawing.Size(116, 25);
            this.lblSelectMPD.TabIndex = 1;
            this.lblSelectMPD.Text = "Select MPD";
            // 
            // lblNozzleCode
            // 
            this.lblNozzleCode.AutoSize = true;
            this.lblNozzleCode.Location = new System.Drawing.Point(24, 98);
            this.lblNozzleCode.Name = "lblNozzleCode";
            this.lblNozzleCode.Size = new System.Drawing.Size(125, 25);
            this.lblNozzleCode.TabIndex = 0;
            this.lblNozzleCode.Text = "Nozzle Code";
            // 
            // grpNozzleDetails
            // 
            this.grpNozzleDetails.BackColor = System.Drawing.Color.White;
            this.grpNozzleDetails.Controls.Add(this.dataGridView2);
            this.grpNozzleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNozzleDetails.Location = new System.Drawing.Point(634, 112);
            this.grpNozzleDetails.Name = "grpNozzleDetails";
            this.grpNozzleDetails.Size = new System.Drawing.Size(1275, 765);
            this.grpNozzleDetails.TabIndex = 1;
            this.grpNozzleDetails.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nozzleCodeDataGridViewTextBoxColumn,
            this.mPDDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.nozzleNameDataGridViewTextBoxColumn,
            this.openingReadingDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tblNozzleMasterBindingSource3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1269, 736);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // nozzleCodeDataGridViewTextBoxColumn
            // 
            this.nozzleCodeDataGridViewTextBoxColumn.DataPropertyName = "NozzleCode";
            this.nozzleCodeDataGridViewTextBoxColumn.HeaderText = "NozzleCode";
            this.nozzleCodeDataGridViewTextBoxColumn.Name = "nozzleCodeDataGridViewTextBoxColumn";
            this.nozzleCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nozzleCodeDataGridViewTextBoxColumn.Width = 140;
            // 
            // mPDDataGridViewTextBoxColumn
            // 
            this.mPDDataGridViewTextBoxColumn.DataPropertyName = "MPD";
            this.mPDDataGridViewTextBoxColumn.HeaderText = "MPD";
            this.mPDDataGridViewTextBoxColumn.Name = "mPDDataGridViewTextBoxColumn";
            this.mPDDataGridViewTextBoxColumn.ReadOnly = true;
            this.mPDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.fuelTypeDataGridViewTextBoxColumn.Width = 170;
            // 
            // nozzleNameDataGridViewTextBoxColumn
            // 
            this.nozzleNameDataGridViewTextBoxColumn.DataPropertyName = "NozzleName";
            this.nozzleNameDataGridViewTextBoxColumn.HeaderText = "NozzleName";
            this.nozzleNameDataGridViewTextBoxColumn.Name = "nozzleNameDataGridViewTextBoxColumn";
            this.nozzleNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nozzleNameDataGridViewTextBoxColumn.Width = 180;
            // 
            // openingReadingDataGridViewTextBoxColumn
            // 
            this.openingReadingDataGridViewTextBoxColumn.DataPropertyName = "OpeningReading";
            this.openingReadingDataGridViewTextBoxColumn.HeaderText = "OpeningReading";
            this.openingReadingDataGridViewTextBoxColumn.Name = "openingReadingDataGridViewTextBoxColumn";
            this.openingReadingDataGridViewTextBoxColumn.ReadOnly = true;
            this.openingReadingDataGridViewTextBoxColumn.Width = 190;
            // 
            // tblNozzleMasterBindingSource3
            // 
            this.tblNozzleMasterBindingSource3.DataMember = "TblNozzleMaster";
            this.tblNozzleMasterBindingSource3.DataSource = this.petrolPumpDbDataSet24;
            // 
            // petrolPumpDbDataSet24
            // 
            this.petrolPumpDbDataSet24.DataSetName = "PetrolPumpDbDataSet24";
            this.petrolPumpDbDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNozzleMasterBindingSource2
            // 
            this.tblNozzleMasterBindingSource2.DataMember = "TblNozzleMaster";
            this.tblNozzleMasterBindingSource2.DataSource = this.petrolPumpDbDataSet22;
            // 
            // petrolPumpDbDataSet22
            // 
            this.petrolPumpDbDataSet22.DataSetName = "PetrolPumpDbDataSet22";
            this.petrolPumpDbDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNozzleMasterBindingSource1
            // 
            this.tblNozzleMasterBindingSource1.DataMember = "TblNozzleMaster";
            this.tblNozzleMasterBindingSource1.DataSource = this.petrolPumpDbDataSet18;
            // 
            // petrolPumpDbDataSet18
            // 
            this.petrolPumpDbDataSet18.DataSetName = "PetrolPumpDbDataSet18";
            this.petrolPumpDbDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNozzleMasterBindingSource
            // 
            this.tblNozzleMasterBindingSource.DataMember = "TblNozzleMaster";
            this.tblNozzleMasterBindingSource.DataSource = this.petrolPumpDbDataSet4;
            // 
            // petrolPumpDbDataSet4
            // 
            this.petrolPumpDbDataSet4.DataSetName = "PetrolPumpDbDataSet4";
            this.petrolPumpDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNozzleMasterTableAdapter
            // 
            this.tblNozzleMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tblNozzleMasterTableAdapter1
            // 
            this.tblNozzleMasterTableAdapter1.ClearBeforeFill = true;
            // 
            // tblNozzleMasterTableAdapter2
            // 
            this.tblNozzleMasterTableAdapter2.ClearBeforeFill = true;
            // 
            // tblNozzleMasterTableAdapter3
            // 
            this.tblNozzleMasterTableAdapter3.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(687, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fuel nozzles and opening reading";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmNozzleMaster
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpNozzleDetails);
            this.Controls.Add(this.grpNozzleEntry);
            this.Name = "frmNozzleMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NozzleMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNozzleMaster_Load);
            this.grpNozzleEntry.ResumeLayout(false);
            this.grpNozzleEntry.PerformLayout();
            this.grpNozzleDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNozzleMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolPumpDbDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNozzleEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtOpeningReading;
        private System.Windows.Forms.TextBox txtNozzleName;
        private System.Windows.Forms.ComboBox cmbSelectFuelType;
        private System.Windows.Forms.ComboBox cmbSelectMPD;
        private System.Windows.Forms.TextBox txtNozzleCode;
        private System.Windows.Forms.Label lblOpeningReading;
        private System.Windows.Forms.Label lblNozzleName;
        private System.Windows.Forms.Label lblSelectFuelType;
        private System.Windows.Forms.Label lblSelectMPD;
        private System.Windows.Forms.Label lblNozzleCode;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpNozzleDetails;
        private PetrolPumpDbDataSet4 petrolPumpDbDataSet4;
        private System.Windows.Forms.BindingSource tblNozzleMasterBindingSource;
        private PetrolPumpDbDataSet4TableAdapters.TblNozzleMasterTableAdapter tblNozzleMasterTableAdapter;
        private PetrolPumpDbDataSet18 petrolPumpDbDataSet18;
        private System.Windows.Forms.BindingSource tblNozzleMasterBindingSource1;
        private PetrolPumpDbDataSet18TableAdapters.TblNozzleMasterTableAdapter tblNozzleMasterTableAdapter1;
        private PetrolPumpDbDataSet22 petrolPumpDbDataSet22;
        private System.Windows.Forms.BindingSource tblNozzleMasterBindingSource2;
        private PetrolPumpDbDataSet22TableAdapters.TblNozzleMasterTableAdapter tblNozzleMasterTableAdapter2;
        private PetrolPumpDbDataSet24 petrolPumpDbDataSet24;
        private System.Windows.Forms.BindingSource tblNozzleMasterBindingSource3;
        private PetrolPumpDbDataSet24TableAdapters.TblNozzleMasterTableAdapter tblNozzleMasterTableAdapter3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nozzleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nozzleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingReadingDataGridViewTextBoxColumn;
    }
}