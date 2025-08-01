namespace PetrolPumpManagement
{
    partial class frmRptCustomerMaster
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TblCustomerMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PetrolPumpDbDataSet30 = new PetrolPumpManagement.PetrolPumpDbDataSet30();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblFirmName = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtFirmName = new System.Windows.Forms.TextBox();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.grpShow = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblCustomerMasterTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet30TableAdapters.TblCustomerMasterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblCustomerMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet30)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblCustomerMasterBindingSource
            // 
            this.TblCustomerMasterBindingSource.DataMember = "TblCustomerMaster";
            this.TblCustomerMasterBindingSource.DataSource = this.PetrolPumpDbDataSet30;
            // 
            // PetrolPumpDbDataSet30
            // 
            this.PetrolPumpDbDataSet30.DataSetName = "PetrolPumpDbDataSet30";
            this.PetrolPumpDbDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtOwnerName);
            this.grpSearch.Controls.Add(this.lblFirmName);
            this.grpSearch.Controls.Add(this.btnShow);
            this.grpSearch.Controls.Add(this.txtFirmName);
            this.grpSearch.Controls.Add(this.lblOwnerName);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.White;
            this.grpSearch.Location = new System.Drawing.Point(446, 106);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1032, 164);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Show Customer Details";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Location = new System.Drawing.Point(608, 66);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(238, 32);
            this.txtOwnerName.TabIndex = 6;
            this.txtOwnerName.TextChanged += new System.EventHandler(this.txtOwnerName_TextChanged);
            // 
            // lblFirmName
            // 
            this.lblFirmName.AutoSize = true;
            this.lblFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmName.ForeColor = System.Drawing.Color.White;
            this.lblFirmName.Location = new System.Drawing.Point(23, 69);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(130, 26);
            this.lblFirmName.TabIndex = 5;
            this.lblFirmName.Text = "Firm Name";
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
            // txtFirmName
            // 
            this.txtFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirmName.Location = new System.Drawing.Point(175, 66);
            this.txtFirmName.Name = "txtFirmName";
            this.txtFirmName.Size = new System.Drawing.Size(238, 32);
            this.txtFirmName.TabIndex = 2;
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerName.ForeColor = System.Drawing.Color.White;
            this.lblOwnerName.Location = new System.Drawing.Point(435, 69);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(151, 26);
            this.lblOwnerName.TabIndex = 1;
            this.lblOwnerName.Text = "Owner Name";
            // 
            // grpShow
            // 
            this.grpShow.Controls.Add(this.reportViewer1);
            this.grpShow.Location = new System.Drawing.Point(340, 276);
            this.grpShow.Name = "grpShow";
            this.grpShow.Size = new System.Drawing.Size(1245, 668);
            this.grpShow.TabIndex = 2;
            this.grpShow.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblCustomerMasterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PetrolPumpManagement.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1239, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblCustomerMasterTableAdapter
            // 
            this.TblCustomerMasterTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptCustomerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.grpShow);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmRptCustomerMaster";
            this.Text = "frmRptCustomerMaster";
            this.Load += new System.EventHandler(this.frmRptCustomerMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblCustomerMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet30)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblFirmName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtFirmName;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.GroupBox grpShow;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblCustomerMasterBindingSource;
        private PetrolPumpDbDataSet30 PetrolPumpDbDataSet30;
        private PetrolPumpDbDataSet30TableAdapters.TblCustomerMasterTableAdapter TblCustomerMasterTableAdapter;

    }
}