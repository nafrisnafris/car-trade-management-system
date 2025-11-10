namespace Car_Traders
{
    partial class frmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomername = new System.Windows.Forms.Label();
            this.regCustomername = new System.Windows.Forms.TextBox();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.regPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.regShowPass = new System.Windows.Forms.CheckBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.regLogin = new System.Windows.Forms.Label();
            this.regClose = new System.Windows.Forms.Label();
            this.regNic = new System.Windows.Forms.TextBox();
            this.txtNic = new System.Windows.Forms.Label();
            this.regContact = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.Label();
            this.regAddress = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.regiClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(152, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER REGISTER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustomername
            // 
            this.txtCustomername.AutoSize = true;
            this.txtCustomername.Location = new System.Drawing.Point(33, 125);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(107, 17);
            this.txtCustomername.TabIndex = 1;
            this.txtCustomername.Text = "Customer Name\r\n";
            // 
            // regCustomername
            // 
            this.regCustomername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regCustomername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regCustomername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCustomername.Location = new System.Drawing.Point(36, 145);
            this.regCustomername.Multiline = true;
            this.regCustomername.Name = "regCustomername";
            this.regCustomername.Size = new System.Drawing.Size(216, 28);
            this.regCustomername.TabIndex = 2;
            // 
            // regUsername
            // 
            this.regUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regUsername.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regUsername.Location = new System.Drawing.Point(36, 279);
            this.regUsername.Multiline = true;
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(216, 28);
            this.regUsername.TabIndex = 4;
            this.regUsername.TextChanged += new System.EventHandler(this.regUsername_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(33, 259);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(69, 17);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.label3_Click);
            // 
            // regPassword
            // 
            this.regPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPassword.Location = new System.Drawing.Point(358, 279);
            this.regPassword.Multiline = true;
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '*';
            this.regPassword.Size = new System.Drawing.Size(216, 28);
            this.regPassword.TabIndex = 6;
            this.regPassword.TextChanged += new System.EventHandler(this.regPassword_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Location = new System.Drawing.Point(355, 259);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(66, 17);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.label4_Click);
            // 
            // regShowPass
            // 
            this.regShowPass.AutoSize = true;
            this.regShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regShowPass.Location = new System.Drawing.Point(455, 329);
            this.regShowPass.Name = "regShowPass";
            this.regShowPass.Size = new System.Drawing.Size(119, 21);
            this.regShowPass.TabIndex = 7;
            this.regShowPass.Text = "Show Password";
            this.regShowPass.UseVisualStyleBackColor = true;
            this.regShowPass.CheckedChanged += new System.EventHandler(this.checkbxShowPass_CheckedChanged);
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.regBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.ForeColor = System.Drawing.Color.White;
            this.regBtn.Location = new System.Drawing.Point(205, 364);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(216, 35);
            this.regBtn.TabIndex = 8;
            this.regBtn.Text = "REGISTER";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already Have an Account";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // regLogin
            // 
            this.regLogin.AutoSize = true;
            this.regLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.regLogin.Location = new System.Drawing.Point(253, 454);
            this.regLogin.Name = "regLogin";
            this.regLogin.Size = new System.Drawing.Size(97, 17);
            this.regLogin.TabIndex = 11;
            this.regLogin.Text = "Back to LOGIN";
            this.regLogin.Click += new System.EventHandler(this.label6_Click);
            // 
            // regClose
            // 
            this.regClose.AutoSize = true;
            this.regClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regClose.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regClose.Location = new System.Drawing.Point(798, 9);
            this.regClose.Name = "regClose";
            this.regClose.Size = new System.Drawing.Size(19, 20);
            this.regClose.TabIndex = 13;
            this.regClose.Text = "X";
            this.regClose.Click += new System.EventHandler(this.regClose_Click);
            // 
            // regNic
            // 
            this.regNic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regNic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regNic.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNic.Location = new System.Drawing.Point(358, 145);
            this.regNic.Multiline = true;
            this.regNic.Name = "regNic";
            this.regNic.Size = new System.Drawing.Size(216, 28);
            this.regNic.TabIndex = 15;
            // 
            // txtNic
            // 
            this.txtNic.AutoSize = true;
            this.txtNic.Location = new System.Drawing.Point(355, 125);
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(52, 34);
            this.txtNic.TabIndex = 14;
            this.txtNic.Text = "NIC No\r\n\r\n";
            // 
            // regContact
            // 
            this.regContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regContact.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regContact.Location = new System.Drawing.Point(36, 216);
            this.regContact.Multiline = true;
            this.regContact.Name = "regContact";
            this.regContact.Size = new System.Drawing.Size(216, 28);
            this.regContact.TabIndex = 17;
            // 
            // txtContact
            // 
            this.txtContact.AutoSize = true;
            this.txtContact.Location = new System.Drawing.Point(33, 196);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(109, 17);
            this.txtContact.TabIndex = 16;
            this.txtContact.Text = "Contact Number\r\n";
            // 
            // regAddress
            // 
            this.regAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.regAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regAddress.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regAddress.Location = new System.Drawing.Point(358, 216);
            this.regAddress.Multiline = true;
            this.regAddress.Name = "regAddress";
            this.regAddress.Size = new System.Drawing.Size(216, 28);
            this.regAddress.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(355, 196);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(57, 17);
            this.txtAddress.TabIndex = 18;
            this.txtAddress.Text = "Address";
            // 
            // regiClose
            // 
            this.regiClose.AutoSize = true;
            this.regiClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regiClose.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regiClose.Location = new System.Drawing.Point(577, 9);
            this.regiClose.Name = "regiClose";
            this.regiClose.Size = new System.Drawing.Size(19, 20);
            this.regiClose.TabIndex = 21;
            this.regiClose.Text = "X";
            this.regiClose.Click += new System.EventHandler(this.regiClose_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 500);
            this.Controls.Add(this.regiClose);
            this.Controls.Add(this.regAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.regContact);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.regNic);
            this.Controls.Add(this.txtNic);
            this.Controls.Add(this.regClose);
            this.Controls.Add(this.regLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.regShowPass);
            this.Controls.Add(this.regPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.regCustomername);
            this.Controls.Add(this.txtCustomername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(164)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustLog_Reg";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtCustomername;
        private System.Windows.Forms.TextBox regCustomername;
        private System.Windows.Forms.TextBox regUsername;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.TextBox regPassword;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.CheckBox regShowPass;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label regLogin;
        private System.Windows.Forms.Label regClose;
        private System.Windows.Forms.TextBox regNic;
        private System.Windows.Forms.Label txtNic;
        private System.Windows.Forms.TextBox regContact;
        private System.Windows.Forms.Label txtContact;
        private System.Windows.Forms.TextBox regAddress;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Label regiClose;
    }
}