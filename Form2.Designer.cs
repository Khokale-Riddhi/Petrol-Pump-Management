namespace PetrolPumpManagement
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.grpSignUp = new System.Windows.Forms.GroupBox();
            this.Eyepass = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpSignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eyepass)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSignUp
            // 
            this.grpSignUp.BackColor = System.Drawing.Color.White;
            this.grpSignUp.Controls.Add(this.Eyepass);
            this.grpSignUp.Controls.Add(this.label2);
            this.grpSignUp.Controls.Add(this.txtPassword);
            this.grpSignUp.Controls.Add(this.txtEmail);
            this.grpSignUp.Controls.Add(this.txtMobileNo);
            this.grpSignUp.Controls.Add(this.txtLastName);
            this.grpSignUp.Controls.Add(this.txtFirstName);
            this.grpSignUp.Controls.Add(this.label1);
            this.grpSignUp.Controls.Add(this.lblConfirmPassword);
            this.grpSignUp.Controls.Add(this.btnSignUp);
            this.grpSignUp.Controls.Add(this.lblPassword);
            this.grpSignUp.Controls.Add(this.lblEmail);
            this.grpSignUp.Controls.Add(this.lblName);
            this.grpSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSignUp.Location = new System.Drawing.Point(667, 177);
            this.grpSignUp.Name = "grpSignUp";
            this.grpSignUp.Size = new System.Drawing.Size(591, 696);
            this.grpSignUp.TabIndex = 0;
            this.grpSignUp.TabStop = false;
            this.grpSignUp.Enter += new System.EventHandler(this.grpSignUp_Enter);
            // 
            // Eyepass
            // 
            this.Eyepass.Image = ((System.Drawing.Image)(resources.GetObject("Eyepass.Image")));
            this.Eyepass.Location = new System.Drawing.Point(482, 447);
            this.Eyepass.Name = "Eyepass";
            this.Eyepass.Size = new System.Drawing.Size(22, 22);
            this.Eyepass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Eyepass.TabIndex = 26;
            this.Eyepass.TabStop = false;
            this.Eyepass.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(199, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = " Sign Up ";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(255, 442);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(258, 30);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(255, 372);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(258, 30);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(255, 304);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(258, 30);
            this.txtMobileNo.TabIndex = 18;
            this.txtMobileNo.TextChanged += new System.EventHandler(this.txtMobileNo_TextChanged);
            this.txtMobileNo.Leave += new System.EventHandler(this.txtMobileNo_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(255, 234);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(258, 30);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(255, 166);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(258, 30);
            this.txtFirstName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(78, 377);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(60, 25);
            this.lblConfirmPassword.TabIndex = 7;
            this.lblConfirmPassword.Text = "Email";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Teal;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(161, 535);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(268, 55);
            this.btnSignUp.TabIndex = 23;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(78, 309);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mobile No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(78, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Last Name";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(106, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // frmSignUp
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.grpSignUp);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.grpSignUp.ResumeLayout(false);
            this.grpSignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Eyepass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSignUp;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Eyepass;
    }
}