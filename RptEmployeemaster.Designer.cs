namespace PetrolPumpManagement
{
    partial class frmRptEmployeemaster
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TblEmployeeMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PetrolPumpDbDataSet27 = new PetrolPumpManagement.PetrolPumpDbDataSet27();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TblEmployeeMasterTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet27TableAdapters.TblEmployeeMasterTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TblEmployeeMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet27)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblEmployeeMasterBindingSource
            // 
            this.TblEmployeeMasterBindingSource.DataMember = "TblEmployeeMaster";
            this.TblEmployeeMasterBindingSource.DataSource = this.PetrolPumpDbDataSet27;
            // 
            // PetrolPumpDbDataSet27
            // 
            this.PetrolPumpDbDataSet27.DataSetName = "PetrolPumpDbDataSet27";
            this.PetrolPumpDbDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDesignation);
            this.groupBox1.Controls.Add(this.lblEmployeeCode);
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(446, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1032, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Employee Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "Pump Manager",
            "Cashier",
            "Fuel Attendant",
            "Shift Supervior",
            "Technician",
            "Account Officer"});
            this.cmbDesignation.Location = new System.Drawing.Point(588, 65);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(242, 34);
            this.cmbDesignation.TabIndex = 6;
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeCode.Location = new System.Drawing.Point(23, 69);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(75, 26);
            this.lblEmployeeCode.TabIndex = 5;
            this.lblEmployeeCode.Text = "Name";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Teal;
            this.btnShow.Location = new System.Drawing.Point(868, 58);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 49);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(136, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 32);
            this.txtName.TabIndex = 2;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.ForeColor = System.Drawing.Color.White;
            this.lblDesignation.Location = new System.Drawing.Point(412, 69);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(138, 26);
            this.lblDesignation.TabIndex = 1;
            this.lblDesignation.Text = "Designation";
            this.lblDesignation.Click += new System.EventHandler(this.lblDesignation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(375, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1175, 668);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TblEmployeeMasterTableAdapter
            // 
            this.TblEmployeeMasterTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.TblEmployeeMasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PetrolPumpManagement.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1169, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRptEmployeemaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRptEmployeemaster";
            this.Text = "RptEmployeemaster";
            this.Load += new System.EventHandler(this.RptEmployeemaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblEmployeeMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet27)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource TblEmployeeMasterBindingSource;
        private PetrolPumpDbDataSet27 PetrolPumpDbDataSet27;
        private PetrolPumpDbDataSet27TableAdapters.TblEmployeeMasterTableAdapter TblEmployeeMasterTableAdapter;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDesignation;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}