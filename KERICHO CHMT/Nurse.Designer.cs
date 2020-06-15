namespace KERICHO_CHMT
{
    partial class Nurse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurse));
            this.lblHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReferralCases = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(150, -33);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(276, 25);
            this.lblHead.TabIndex = 15;
            this.lblHead.Text = "KERICHO COUNTY TIMS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(591, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Referral Casses and Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(24, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 192);
            this.button1.TabIndex = 26;
            this.button1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nView Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReferralCases
            // 
            this.btnReferralCases.BackColor = System.Drawing.Color.White;
            this.btnReferralCases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReferralCases.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferralCases.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnReferralCases.Image = ((System.Drawing.Image)(resources.GetObject("btnReferralCases.Image")));
            this.btnReferralCases.Location = new System.Drawing.Point(24, 233);
            this.btnReferralCases.Name = "btnReferralCases";
            this.btnReferralCases.Size = new System.Drawing.Size(215, 167);
            this.btnReferralCases.TabIndex = 33;
            this.btnReferralCases.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nSearch previous Case";
            this.btnReferralCases.UseVisualStyleBackColor = false;
            this.btnReferralCases.Click += new System.EventHandler(this.btnReferralCases_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(24, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 132);
            this.button5.TabIndex = 30;
            this.button5.Text = "\r\n\r\n\r\n\r\n\r\nRegister Patient Details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 541);
            this.dataGridView1.TabIndex = 34;
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 658);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReferralCases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHead);
            this.Name = "Nurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Nurse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReferralCases;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}