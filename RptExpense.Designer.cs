namespace PetrolPumpManagement
{
    partial class frmRptExpense
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
            this.TblExpenseEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PetrolPumpDbDataSet29 = new PetrolPumpManagement.PetrolPumpDbDataSet29();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.TodateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grpShow = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TblExpenseEntryTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet29TableAdapters.TblExpenseEntryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblExpenseEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet29)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblExpenseEntryBindingSource
            // 
            this.TblExpenseEntryBindingSource.DataMember = "TblExpenseEntry";
            this.TblExpenseEntryBindingSource.DataSource = this.PetrolPumpDbDataSet29;
            // 
            // PetrolPumpDbDataSet29
            // 
            this.PetrolPumpDbDataSet29.DataSetName = "PetrolPumpDbDataSet29";
            this.PetrolPumpDbDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblFromDate);
            this.grpSearch.Controls.Add(this.TodateTimePicker2);
            this.grpSearch.Controls.Add(this.lblToDate);
            this.grpSearch.Controls.Add(this.btnShow);
            this.grpSearch.Controls.Add(this.FromdateTimePicker);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.ForeColor = System.Drawing.Color.White;
            this.grpSearch.Location = new System.Drawing.Point(375, 84);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1175, 143);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Show Expense Details";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(43, 58);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(124, 26);
            this.lblFromDate.TabIndex = 9;
            this.lblFromDate.Text = "From Date";
            // 
            // TodateTimePicker2
            // 
            this.TodateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TodateTimePicker2.Location = new System.Drawing.Point(673, 56);
            this.TodateTimePicker2.Name = "TodateTimePicker2";
            this.TodateTimePicker2.Size = new System.Drawing.Size(259, 32);
            this.TodateTimePicker2.TabIndex = 8;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(520, 58);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(95, 26);
            this.lblToDate.TabIndex = 7;
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
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromdateTimePicker.Location = new System.Drawing.Point(196, 56);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(266, 32);
            this.FromdateTimePicker.TabIndex = 5;
            // 
            // grpShow
            // 
            this.grpShow.Controls.Add(this.reportViewer1);
            this.grpShow.Location = new System.Drawing.Point(274, 233);
            this.grpShow.Name = "grpShow";
            this.grpShow.Size = new System.Drawing.Size(1376, 734);
            this.grpShow.TabIndex = 1;
            this.grpShow.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblExpenseEntryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PetrolPumpManagement.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1370, 709);
            this.reportViewer1.TabIndex = 0;
            // 
            // TblExpenseEntryTableAdapter
            // 
            this.TblExpenseEntryTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.grpShow);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmRptExpense";
            this.Load += new System.EventHandler(this.frmRptExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblExpenseEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet29)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpShow;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblExpenseEntryBindingSource;
        private PetrolPumpDbDataSet29 PetrolPumpDbDataSet29;
        private PetrolPumpDbDataSet29TableAdapters.TblExpenseEntryTableAdapter TblExpenseEntryTableAdapter;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker TodateTimePicker2;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
    }
}