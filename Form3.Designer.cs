namespace PetrolPumpManagement
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.grpChangePassword = new System.Windows.Forms.GroupBox();
            this.ShowNewPass = new System.Windows.Forms.PictureBox();
            this.ShowOldPass = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.grpChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowNewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChangePassword
            // 
            this.grpChangePassword.BackColor = System.Drawing.Color.White;
            this.grpChangePassword.Controls.Add(this.ShowNewPass);
            this.grpChangePassword.Controls.Add(this.ShowOldPass);
            this.grpChangePassword.Controls.Add(this.pictureBox1);
            this.grpChangePassword.Controls.Add(this.label1);
            this.grpChangePassword.Controls.Add(this.txtUsername);
            this.grpChangePassword.Controls.Add(this.lblUsername);
            this.grpChangePassword.Controls.Add(this.btnUpdate);
            this.grpChangePassword.Controls.Add(this.txtConfirmPassword);
            this.grpChangePassword.Controls.Add(this.txtNewPassword);
            this.grpChangePassword.Controls.Add(this.txtOldPassword);
            this.grpChangePassword.Controls.Add(this.lblConfirmPassword);
            this.grpChangePassword.Controls.Add(this.lblNewPassword);
            this.grpChangePassword.Controls.Add(this.lblOldPassword);
            this.grpChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChangePassword.Location = new System.Drawing.Point(680, 201);
            this.grpChangePassword.Name = "grpChangePassword";
            this.grpChangePassword.Size = new System.Drawing.Size(565, 648);
            this.grpChangePassword.TabIndex = 0;
            this.grpChangePassword.TabStop = false;
            // 
            // ShowNewPass
            // 
            this.ShowNewPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowNewPass.Image")));
            this.ShowNewPass.Location = new System.Drawing.Point(475, 348);
            this.ShowNewPass.Name = "ShowNewPass";
            this.ShowNewPass.Size = new System.Drawing.Size(27, 27);
            this.ShowNewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowNewPass.TabIndex = 11;
            this.ShowNewPass.TabStop = false;
            this.ShowNewPass.Click += new System.EventHandler(this.ShowNewPass_Click);
            // 
            // ShowOldPass
            // 
            this.ShowOldPass.Image = ((System.Drawing.Image)(resources.GetObject("ShowOldPass.Image")));
            this.ShowOldPass.Location = new System.Drawing.Point(475, 268);
            this.ShowOldPass.Name = "ShowOldPass";
            this.ShowOldPass.Size = new System.Drawing.Size(27, 27);
            this.ShowOldPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowOldPass.TabIndex = 10;
            this.ShowOldPass.TabStop = false;
            this.ShowOldPass.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(126, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Change Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(254, 195);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(258, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(53, 200);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(148, 519);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(273, 55);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(254, 426);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(258, 30);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(254, 345);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(258, 30);
            this.txtNewPassword.TabIndex = 4;
            this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.Location = new System.Drawing.Point(254, 265);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(258, 30);
            this.txtOldPassword.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(53, 431);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(171, 25);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(53, 350);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(133, 25);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Paaword";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(53, 270);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(134, 25);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old Password";
            // 
            // frmChangePassword
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.grpChangePassword);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.grpChangePassword.ResumeLayout(false);
            this.grpChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowNewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChangePassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ShowNewPass;
        private System.Windows.Forms.PictureBox ShowOldPass;
    }
}