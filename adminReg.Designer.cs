namespace Car_Traders
{
    partial class frmAdminReg
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
            this.adminClose = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regLogin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.regBtn = new System.Windows.Forms.Button();
            this.regShowPass = new System.Windows.Forms.CheckBox();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminClose
            // 
            this.adminClose.AutoSize = true;
            this.adminClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminClose.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminClose.Location = new System.Drawing.Point(254, 18);
            this.adminClose.Name = "adminClose";
            this.adminClose.Size = new System.Drawing.Size(19, 20);
            this.adminClose.TabIndex = 26;
            this.adminClose.Text = "X";
            this.adminClose.Click += new System.EventHandler(this.adminClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "For Admin....";
            // 
            // regLogin
            // 
            this.regLogin.AutoSize = true;
            this.regLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLogin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.regLogin.Location = new System.Drawing.Point(84, 469);
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(97, 17);
            this.regLogin.TabIndex = 24;
            this.regLogin.Text = "Back to LOGIN";
            this.regLogin.Click += new System.EventHandler(this.regLogin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(56, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Already Have an Account";
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.regBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.Location = new System.Drawing.Point(36, 379);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(216, 35);
            this.regBtn.TabIndex = 22;
            this.regBtn.Text = "REGISTER";
            this.regBtn.UseVisualStyleBackColor = false;
            // 
            // regShowPass
            // 
            this.regShowPass.AutoSize = true;
            this.regShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regShowPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.regShowPass.Location = new System.Drawing.Point(130, 337);
            this.regShowPass.Name = "regShowPass";
            this.regShowPass.Size = new System.Drawing.Size(119, 21);
            this.regShowPass.TabIndex = 21;
            this.regShowPass.Text = "Show Password";
            this.regShowPass.UseVisualStyleBackColor = true;
            // 
            // regPassword
            // 
            this.regPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(36, 291);
            this.regPassword.Multiline = true;
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '*';
            this.regPassword.Size = new System.Drawing.Size(216, 28);
            this.regPassword.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(33, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // regUsername
            // 
            this.regUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.Location = new System.Drawing.Point(36, 224);
            this.regUsername.Multiline = true;
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(216, 28);
            this.regUsername.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(33, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username";
            // 
            // regEmail
            // 
            this.regEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regEmail.Location = new System.Drawing.Point(36, 154);
            this.regEmail.Multiline = true;
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(216, 28);
            this.regEmail.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Get Started";
            // 
            // frmAdminReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 500);
            this.Controls.Add(this.adminClose);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.regLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.regShowPass);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminReg";
            this.Load += new System.EventHandler(this.adminReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label regLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.CheckBox regShowPass;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}