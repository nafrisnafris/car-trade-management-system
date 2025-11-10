namespace Car_Traders
{
    partial class frmLogin
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.loginShowPass = new System.Windows.Forms.CheckBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginUsename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(84, 305);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(216, 35);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginShowPass
            // 
            this.loginShowPass.AutoSize = true;
            this.loginShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginShowPass.Location = new System.Drawing.Point(178, 263);
            this.loginShowPass.Name = "loginShowPass";
            this.loginShowPass.Size = new System.Drawing.Size(119, 21);
            this.loginShowPass.TabIndex = 19;
            this.loginShowPass.Text = "Show Password";
            this.loginShowPass.UseVisualStyleBackColor = true;
            this.loginShowPass.CheckedChanged += new System.EventHandler(this.loginShowPass_CheckedChanged);
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(84, 215);
            this.loginPassword.Multiline = true;
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(216, 28);
            this.loginPassword.TabIndex = 16;
            this.loginPassword.TextChanged += new System.EventHandler(this.loginPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginUsename
            // 
            this.loginUsename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.loginUsename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUsename.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsename.Location = new System.Drawing.Point(84, 145);
            this.loginUsename.Multiline = true;
            this.loginUsename.Name = "loginUsename";
            this.loginUsename.Size = new System.Drawing.Size(216, 28);
            this.loginUsename.TabIndex = 14;
            this.loginUsename.TextChanged += new System.EventHandler(this.txtUsename_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginClose
            // 
            this.loginClose.AutoSize = true;
            this.loginClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginClose.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginClose.Location = new System.Drawing.Point(361, 9);
            this.loginClose.Name = "loginClose";
            this.loginClose.Size = new System.Drawing.Size(19, 20);
            this.loginClose.TabIndex = 25;
            this.loginClose.Text = "X";
            this.loginClose.Click += new System.EventHandler(this.loginClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "CUSTOMER LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Don\'t Have an Account";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // loginRegister
            // 
            this.loginRegister.AutoSize = true;
            this.loginRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.loginRegister.Location = new System.Drawing.Point(131, 402);
            this.loginRegister.Name = "loginRegister";
            this.loginRegister.Size = new System.Drawing.Size(120, 17);
            this.loginRegister.TabIndex = 23;
            this.loginRegister.Text = "Create an Account";
            this.loginRegister.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 448);
            this.Controls.Add(this.loginClose);
            this.Controls.Add(this.loginRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginShowPass);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginUsename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "custLogin";
            this.Load += new System.EventHandler(this.custLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox loginShowPass;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginUsename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label loginRegister;
    }
}