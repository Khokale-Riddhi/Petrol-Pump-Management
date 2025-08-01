namespace PetrolPumpManagement
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chartDeposit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartExpense = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCreditSale = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlCNG = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCNGRate = new System.Windows.Forms.Label();
            this.lblCNGTitle = new System.Windows.Forms.Label();
            this.pnlXtraPremium = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblXtraPrmiumRate = new System.Windows.Forms.Label();
            this.lblXtraPremiumTitle = new System.Windows.Forms.Label();
            this.pnlDiesel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDieselRate = new System.Windows.Forms.Label();
            this.lblDieselTitle = new System.Windows.Forms.Label();
            this.pnlPetrol = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPetrolRate = new System.Windows.Forms.Label();
            this.lblPetrolTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCreditSale)).BeginInit();
            this.pnlCNG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlXtraPremium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlDiesel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlPetrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Teal;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(775, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(375, 51);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Today\'s Fuel Rates";
            this.lblDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 104);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 104);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(556, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(812, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deposit, Expense and Fuel Sales Summary";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.06029F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.93971F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 531);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 519F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1924, 519);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chartDeposit);
            this.flowLayoutPanel1.Controls.Add(this.ChartExpense);
            this.flowLayoutPanel1.Controls.Add(this.chartCreditSale);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1924, 519);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // chartDeposit
            // 
            this.chartDeposit.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartDeposit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDeposit.Legends.Add(legend1);
            this.chartDeposit.Location = new System.Drawing.Point(52, 10);
            this.chartDeposit.Margin = new System.Windows.Forms.Padding(52, 10, 40, 40);
            this.chartDeposit.Name = "chartDeposit";
            this.chartDeposit.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chartDeposit.Series.Add(series1);
            this.chartDeposit.Size = new System.Drawing.Size(550, 400);
            this.chartDeposit.TabIndex = 1;
            this.chartDeposit.Text = "chart2";
            this.chartDeposit.Click += new System.EventHandler(this.chartDeposit_Click);
            // 
            // ChartExpense
            // 
            this.ChartExpense.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.ChartExpense.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartExpense.Legends.Add(legend2);
            this.ChartExpense.Location = new System.Drawing.Point(682, 10);
            this.ChartExpense.Margin = new System.Windows.Forms.Padding(40, 10, 40, 40);
            this.ChartExpense.Name = "ChartExpense";
            this.ChartExpense.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartExpense.Series.Add(series2);
            this.ChartExpense.Size = new System.Drawing.Size(550, 400);
            this.ChartExpense.TabIndex = 0;
            this.ChartExpense.Click += new System.EventHandler(this.Expense_Click);
            this.ChartExpense.MouseEnter += new System.EventHandler(this.ChartExpense_MouseEnter);
            // 
            // chartCreditSale
            // 
            this.chartCreditSale.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chartCreditSale.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCreditSale.Legends.Add(legend3);
            this.chartCreditSale.Location = new System.Drawing.Point(1312, 10);
            this.chartCreditSale.Margin = new System.Windows.Forms.Padding(40, 10, 40, 40);
            this.chartCreditSale.Name = "chartCreditSale";
            this.chartCreditSale.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartCreditSale.Series.Add(series3);
            this.chartCreditSale.Size = new System.Drawing.Size(550, 400);
            this.chartCreditSale.TabIndex = 2;
            this.chartCreditSale.Text = "chart3";
            // 
            // pnlCNG
            // 
            this.pnlCNG.BackColor = System.Drawing.Color.White;
            this.pnlCNG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCNG.Controls.Add(this.pictureBox3);
            this.pnlCNG.Controls.Add(this.lblCNGRate);
            this.pnlCNG.Controls.Add(this.lblCNGTitle);
            this.pnlCNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCNG.Location = new System.Drawing.Point(972, 5);
            this.pnlCNG.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.pnlCNG.Name = "pnlCNG";
            this.pnlCNG.Size = new System.Drawing.Size(461, 308);
            this.pnlCNG.TabIndex = 1;
            this.pnlCNG.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.pnlCNG.MouseEnter += new System.EventHandler(this.pnlCNG_MouseEnter);
            this.pnlCNG.MouseLeave += new System.EventHandler(this.pnlCNG_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(162, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblCNGRate
            // 
            this.lblCNGRate.AutoSize = true;
            this.lblCNGRate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNGRate.ForeColor = System.Drawing.Color.Teal;
            this.lblCNGRate.Location = new System.Drawing.Point(160, 223);
            this.lblCNGRate.Name = "lblCNGRate";
            this.lblCNGRate.Size = new System.Drawing.Size(137, 54);
            this.lblCNGRate.TabIndex = 3;
            this.lblCNGRate.Text = "label3";
            // 
            // lblCNGTitle
            // 
            this.lblCNGTitle.AutoSize = true;
            this.lblCNGTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNGTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblCNGTitle.Location = new System.Drawing.Point(175, 155);
            this.lblCNGTitle.Name = "lblCNGTitle";
            this.lblCNGTitle.Size = new System.Drawing.Size(106, 48);
            this.lblCNGTitle.TabIndex = 1;
            this.lblCNGTitle.Text = "CNG ";
            this.lblCNGTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCNGTitle.Click += new System.EventHandler(this.lblCNGTitle_Click);
            // 
            // pnlXtraPremium
            // 
            this.pnlXtraPremium.BackColor = System.Drawing.Color.White;
            this.pnlXtraPremium.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlXtraPremium.Controls.Add(this.pictureBox4);
            this.pnlXtraPremium.Controls.Add(this.lblXtraPrmiumRate);
            this.pnlXtraPremium.Controls.Add(this.lblXtraPremiumTitle);
            this.pnlXtraPremium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlXtraPremium.Location = new System.Drawing.Point(1453, 5);
            this.pnlXtraPremium.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.pnlXtraPremium.Name = "pnlXtraPremium";
            this.pnlXtraPremium.Size = new System.Drawing.Size(461, 308);
            this.pnlXtraPremium.TabIndex = 1;
            this.pnlXtraPremium.MouseEnter += new System.EventHandler(this.pnlXtraPremium_MouseEnter);
            this.pnlXtraPremium.MouseLeave += new System.EventHandler(this.pnlXtraPremium_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(162, 27);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // lblXtraPrmiumRate
            // 
            this.lblXtraPrmiumRate.AutoSize = true;
            this.lblXtraPrmiumRate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXtraPrmiumRate.ForeColor = System.Drawing.Color.Teal;
            this.lblXtraPrmiumRate.Location = new System.Drawing.Point(160, 223);
            this.lblXtraPrmiumRate.Name = "lblXtraPrmiumRate";
            this.lblXtraPrmiumRate.Size = new System.Drawing.Size(137, 54);
            this.lblXtraPrmiumRate.TabIndex = 3;
            this.lblXtraPrmiumRate.Text = "label4";
            this.lblXtraPrmiumRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblXtraPrmiumRate.Click += new System.EventHandler(this.lblXtraPrmiumRate_Click);
            // 
            // lblXtraPremiumTitle
            // 
            this.lblXtraPremiumTitle.AutoSize = true;
            this.lblXtraPremiumTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXtraPremiumTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblXtraPremiumTitle.Location = new System.Drawing.Point(96, 155);
            this.lblXtraPremiumTitle.Name = "lblXtraPremiumTitle";
            this.lblXtraPremiumTitle.Size = new System.Drawing.Size(264, 48);
            this.lblXtraPremiumTitle.TabIndex = 1;
            this.lblXtraPremiumTitle.Text = "Xtra Premium ";
            this.lblXtraPremiumTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDiesel
            // 
            this.pnlDiesel.BackColor = System.Drawing.Color.White;
            this.pnlDiesel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDiesel.Controls.Add(this.pictureBox2);
            this.pnlDiesel.Controls.Add(this.lblDieselRate);
            this.pnlDiesel.Controls.Add(this.lblDieselTitle);
            this.pnlDiesel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDiesel.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.pnlDiesel.Location = new System.Drawing.Point(491, 5);
            this.pnlDiesel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.pnlDiesel.Name = "pnlDiesel";
            this.pnlDiesel.Size = new System.Drawing.Size(461, 308);
            this.pnlDiesel.TabIndex = 1;
            this.pnlDiesel.MouseEnter += new System.EventHandler(this.pnlDiesel_MouseEnter);
            this.pnlDiesel.MouseLeave += new System.EventHandler(this.pnlDiesel_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // lblDieselRate
            // 
            this.lblDieselRate.AutoSize = true;
            this.lblDieselRate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieselRate.ForeColor = System.Drawing.Color.Teal;
            this.lblDieselRate.Location = new System.Drawing.Point(160, 223);
            this.lblDieselRate.Name = "lblDieselRate";
            this.lblDieselRate.Size = new System.Drawing.Size(137, 54);
            this.lblDieselRate.TabIndex = 3;
            this.lblDieselRate.Text = "label2";
            this.lblDieselRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDieselTitle
            // 
            this.lblDieselTitle.AutoSize = true;
            this.lblDieselTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDieselTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblDieselTitle.Location = new System.Drawing.Point(163, 155);
            this.lblDieselTitle.Name = "lblDieselTitle";
            this.lblDieselTitle.Size = new System.Drawing.Size(131, 48);
            this.lblDieselTitle.TabIndex = 0;
            this.lblDieselTitle.Text = "Diesel ";
            this.lblDieselTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDieselTitle.Click += new System.EventHandler(this.lblDieselTitle_Click);
            // 
            // pnlPetrol
            // 
            this.pnlPetrol.BackColor = System.Drawing.Color.White;
            this.pnlPetrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPetrol.Controls.Add(this.pictureBox1);
            this.pnlPetrol.Controls.Add(this.lblPetrolRate);
            this.pnlPetrol.Controls.Add(this.lblPetrolTitle);
            this.pnlPetrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPetrol.Location = new System.Drawing.Point(10, 5);
            this.pnlPetrol.Margin = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.pnlPetrol.Name = "pnlPetrol";
            this.pnlPetrol.Size = new System.Drawing.Size(461, 308);
            this.pnlPetrol.TabIndex = 0;
            this.pnlPetrol.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPetrol_MouseClick);
            this.pnlPetrol.MouseEnter += new System.EventHandler(this.pnlPetrol_MouseEnter);
            this.pnlPetrol.MouseLeave += new System.EventHandler(this.pnlPetrol_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblPetrolRate
            // 
            this.lblPetrolRate.AutoSize = true;
            this.lblPetrolRate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetrolRate.ForeColor = System.Drawing.Color.Teal;
            this.lblPetrolRate.Location = new System.Drawing.Point(160, 223);
            this.lblPetrolRate.Name = "lblPetrolRate";
            this.lblPetrolRate.Size = new System.Drawing.Size(137, 54);
            this.lblPetrolRate.TabIndex = 2;
            this.lblPetrolRate.Text = "label1";
            this.lblPetrolRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPetrolTitle
            // 
            this.lblPetrolTitle.AutoSize = true;
            this.lblPetrolTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetrolTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblPetrolTitle.Location = new System.Drawing.Point(161, 155);
            this.lblPetrolTitle.Name = "lblPetrolTitle";
            this.lblPetrolTitle.Size = new System.Drawing.Size(130, 48);
            this.lblPetrolTitle.TabIndex = 1;
            this.lblPetrolTitle.Text = "Petrol ";
            this.lblPetrolTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPetrol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDiesel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlXtraPremium, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCNG, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 323);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmDashboard_Activated);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCreditSale)).EndInit();
            this.pnlCNG.ResumeLayout(false);
            this.pnlCNG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlXtraPremium.ResumeLayout(false);
            this.pnlXtraPremium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlDiesel.ResumeLayout(false);
            this.pnlDiesel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlPetrol.ResumeLayout(false);
            this.pnlPetrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDeposit;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartExpense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCreditSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCNG;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCNGRate;
        private System.Windows.Forms.Label lblCNGTitle;
        private System.Windows.Forms.Panel pnlXtraPremium;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblXtraPrmiumRate;
        private System.Windows.Forms.Label lblXtraPremiumTitle;
        private System.Windows.Forms.Panel pnlDiesel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDieselRate;
        private System.Windows.Forms.Label lblDieselTitle;
        private System.Windows.Forms.Panel pnlPetrol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPetrolRate;
        private System.Windows.Forms.Label lblPetrolTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}