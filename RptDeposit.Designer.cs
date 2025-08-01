namespace PetrolPumpManagement
{
    partial class frmRptDeposit
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
            this.TblDepositEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PetrolPumpDbDataSet26 = new PetrolPumpManagement.PetrolPumpDbDataSet26();
            this.grpRptDeposit = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblDepositEntryTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet26TableAdapters.TblDepositEntryTableAdapter();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.TodateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TblDepositEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet26)).BeginInit();
            this.grpRptDeposit.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblDepositEntryBindingSource
            // 
            this.TblDepositEntryBindingSource.DataMember = "TblDepositEntry";
            this.TblDepositEntryBindingSource.DataSource = this.PetrolPumpDbDataSet26;
            // 
            // PetrolPumpDbDataSet26
            // 
            this.PetrolPumpDbDataSet26.DataSetName = "PetrolPumpDbDataSet26";
            this.PetrolPumpDbDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpRptDeposit
            // 
            this.grpRptDeposit.Controls.Add(this.reportViewer1);
            this.grpRptDeposit.Location = new System.Drawing.Point(116, 208);
            this.grpRptDeposit.Name = "grpRptDeposit";
            this.grpRptDeposit.Size = new System.Drawing.Size(1693, 734);
            this.grpRptDeposit.TabIndex = 0;
            this.grpRptDeposit.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblDepositEntryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PetrolPumpManagement.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1687, 709);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblDepositEntryTableAdapter
            // 
            this.TblDepositEntryTableAdapter.ClearBeforeFill = true;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.TodateTimePicker2);
            this.grpSearch.Controls.Add(this.lblToDate);
            this.grpSearch.Controls.Add(this.btnShow);
            this.grpSearch.Controls.Add(this.FromdateTimePicker);
            this.grpSearch.Controls.Add(this.lblFromDate);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.White;
            this.grpSearch.Location = new System.Drawing.Point(375, 59);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1175, 143);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Show Deposit Details";
            // 
            // TodateTimePicker2
            // 
            this.TodateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TodateTimePicker2.Location = new System.Drawing.Point(658, 56);
            this.TodateTimePicker2.Name = "TodateTimePicker2";
            this.TodateTimePicker2.Size = new System.Drawing.Size(287, 32);
            this.TodateTimePicker2.TabIndex = 2;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(525, 58);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(95, 26);
            this.lblToDate.TabIndex = 3;
            this.lblToDate.Text = "To Date";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Teal;
            this.btnShow.Location = new System.Drawing.Point(990, 47);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 49);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromdateTimePicker.Location = new System.Drawing.Point(193, 56);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(287, 32);
            this.FromdateTimePicker.TabIndex = 1;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(33, 58);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(124, 26);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "From Date";
            // 
            // frmRptDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpRptDeposit);
            this.Name = "frmRptDeposit";
            this.Text = "RptDeposit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblDepositEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet26)).EndInit();
            this.grpRptDeposit.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRptDeposit;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblDepositEntryBindingSource;
        private PetrolPumpDbDataSet26 PetrolPumpDbDataSet26;
        private PetrolPumpDbDataSet26TableAdapters.TblDepositEntryTableAdapter TblDepositEntryTableAdapter;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DateTimePicker TodateTimePicker2;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.Label lblFromDate;
    }
}