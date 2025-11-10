namespace Car_Traders
{
    partial class serachCarPartsDetails
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataCPD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.carPartsDetailsClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPartsSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCPD)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(119, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 31);
            this.button3.TabIndex = 27;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(214, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 26;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataCPD
            // 
            this.dataCPD.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataCPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCPD.Location = new System.Drawing.Point(123, 146);
            this.dataCPD.Name = "dataCPD";
            this.dataCPD.Size = new System.Drawing.Size(544, 186);
            this.dataCPD.TabIndex = 25;
            this.dataCPD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCPD_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(191, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "SEARCH CAR PARTS DETAILS";
            // 
            // carPartsDetailsClose
            // 
            this.carPartsDetailsClose.AutoSize = true;
            this.carPartsDetailsClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carPartsDetailsClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carPartsDetailsClose.Location = new System.Drawing.Point(692, 9);
            this.carPartsDetailsClose.Name = "carPartsDetailsClose";
            this.carPartsDetailsClose.Size = new System.Drawing.Size(16, 16);
            this.carPartsDetailsClose.TabIndex = 31;
            this.carPartsDetailsClose.Text = "X";
            this.carPartsDetailsClose.Click += new System.EventHandler(this.carPartsDetailsClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Search";
            // 
            // txtPartsSearch
            // 
            this.txtPartsSearch.Location = new System.Drawing.Point(123, 95);
            this.txtPartsSearch.Name = "txtPartsSearch";
            this.txtPartsSearch.Size = new System.Drawing.Size(203, 20);
            this.txtPartsSearch.TabIndex = 33;
            this.txtPartsSearch.TextChanged += new System.EventHandler(this.txtPartsSearch_TextChanged);
            // 
            // serachCarPartsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 407);
            this.Controls.Add(this.txtPartsSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carPartsDetailsClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataCPD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "serachCarPartsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serachCarPartsDetails";
            this.Load += new System.EventHandler(this.serachCarPartsDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataCPD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label carPartsDetailsClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartsSearch;
    }
}