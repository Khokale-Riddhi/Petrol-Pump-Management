namespace PetrolPumpManagement
{
    partial class frmRptCredit
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
            this.TblCreditSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PetrolPumpDbDataSet28 = new PetrolPumpManagement.PetrolPumpDbDataSet28();
            this.grpCreditShow = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grpCreditSearch = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.TodateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.FromdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.TblCreditSaleTableAdapter = new PetrolPumpManagement.PetrolPumpDbDataSet28TableAdapters.TblCreditSaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TblCreditSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet28)).BeginInit();
            this.grpCreditShow.SuspendLayout();
            this.grpCreditSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblCreditSaleBindingSource
            // 
            this.TblCreditSaleBindingSource.DataMember = "TblCreditSale";
            this.TblCreditSaleBindingSource.DataSource = this.PetrolPumpDbDataSet28;
            // 
            // PetrolPumpDbDataSet28
            // 
            this.PetrolPumpDbDataSet28.DataSetName = "PetrolPumpDbDataSet28";
            this.PetrolPumpDbDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpCreditShow
            // 
            this.grpCreditShow.Controls.Add(this.reportViewer1);
            this.grpCreditShow.Location = new System.Drawing.Point(28, 202);
            this.grpCreditShow.Name = "grpCreditShow";
            this.grpCreditShow.Size = new System.Drawing.Size(1869, 734);
            this.grpCreditShow.TabIndex = 0;
            this.grpCreditShow.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblCreditSaleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PetrolPumpManagement.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1863, 709);
            this.reportViewer1.TabIndex = 0;
            // 
            // grpCreditSearch
            // 
            this.grpCreditSearch.Controls.Add(this.btnShow);
            this.grpCreditSearch.Controls.Add(this.TodateTimePicker2);
            this.grpCreditSearch.Controls.Add(this.lblToDate);
            this.grpCreditSearch.Controls.Add(this.FromdateTimePicker);
            this.grpCreditSearch.Controls.Add(this.lblFromDate);
            this.grpCreditSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCreditSearch.ForeColor = System.Drawing.Color.White;
            this.grpCreditSearch.Location = new System.Drawing.Point(375, 53);
            this.grpCreditSearch.Name = "grpCreditSearch";
            this.grpCreditSearch.Size = new System.Drawing.Size(1175, 143);
            this.grpCreditSearch.TabIndex = 1;
            this.grpCreditSearch.TabStop = false;
            this.grpCreditSearch.Text = "Show Credit Details";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Teal;
            this.btnShow.Location = new System.Drawing.Point(977, 47);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(141, 49);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // TodateTimePicker2
            // 
            this.TodateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TodateTimePicker2.Location = new System.Drawing.Point(658, 56);
            this.TodateTimePicker2.Name = "TodateTimePicker2";
            this.TodateTimePicker2.Size = new System.Drawing.Size(249, 32);
            this.TodateTimePicker2.TabIndex = 5;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.ForeColor = System.Drawing.Color.White;
            this.lblToDate.Location = new System.Drawing.Point(531, 58);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(95, 26);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "To Date";
            // 
            // FromdateTimePicker
            // 
            this.FromdateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromdateTimePicker.Location = new System.Drawing.Point(212, 56);
            this.FromdateTimePicker.Name = "FromdateTimePicker";
            this.FromdateTimePicker.Size = new System.Drawing.Size(264, 32);
            this.FromdateTimePicker.TabIndex = 2;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.ForeColor = System.Drawing.Color.White;
            this.lblFromDate.Location = new System.Drawing.Point(56, 58);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(124, 26);
            this.lblFromDate.TabIndex = 1;
            this.lblFromDate.Text = "From Date";
            // 
            // TblCreditSaleTableAdapter
            // 
            this.TblCreditSaleTableAdapter.ClearBeforeFill = true;
            // 
            // frmRptCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.grpCreditSearch);
            this.Controls.Add(this.grpCreditShow);
            this.Name = "frmRptCredit";
            this.Text = "RptCredit";
            this.Load += new System.EventHandler(this.frmRptCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TblCreditSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PetrolPumpDbDataSet28)).EndInit();
            this.grpCreditShow.ResumeLayout(false);
            this.grpCreditSearch.ResumeLayout(false);
            this.grpCreditSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCreditShow;
        private System.Windows.Forms.GroupBox grpCreditSearch;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblCreditSaleBindingSource;
        private PetrolPumpDbDataSet28 PetrolPumpDbDataSet28;
        private PetrolPumpDbDataSet28TableAdapters.TblCreditSaleTableAdapter TblCreditSaleTableAdapter;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker FromdateTimePicker;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker TodateTimePicker2;
        private System.Windows.Forms.Button btnShow;
    }
}