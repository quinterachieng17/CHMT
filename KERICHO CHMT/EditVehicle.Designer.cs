namespace KERICHO_CHMT
{
    partial class EditVehicle
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
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChasisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnRegisterStaff = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(367, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "KERICHO COUNTY TIMS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(787, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(969, 587);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Motor Vehicle Details";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(895, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegNo,
            this.Make,
            this.ChasisNo,
            this.EngineNo,
            this.PlateNo});
            this.dgvVehicle.Location = new System.Drawing.Point(461, 170);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.Size = new System.Drawing.Size(635, 411);
            this.dgvVehicle.TabIndex = 32;
            this.dgvVehicle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellContentClick);
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "Reg No.";
            this.RegNo.Name = "RegNo";
            // 
            // Make
            // 
            this.Make.DataPropertyName = "Make";
            this.Make.HeaderText = "Make";
            this.Make.Name = "Make";
            this.Make.Width = 130;
            // 
            // ChasisNo
            // 
            this.ChasisNo.DataPropertyName = "ChasisNo";
            this.ChasisNo.HeaderText = "Chasis No";
            this.ChasisNo.Name = "ChasisNo";
            this.ChasisNo.Width = 130;
            // 
            // EngineNo
            // 
            this.EngineNo.DataPropertyName = "EngineNo";
            this.EngineNo.HeaderText = "Engine No.";
            this.EngineNo.Name = "EngineNo";
            this.EngineNo.Width = 130;
            // 
            // PlateNo
            // 
            this.PlateNo.DataPropertyName = "PlateNo";
            this.PlateNo.HeaderText = "Plate No.";
            this.PlateNo.Name = "PlateNo";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(12, 200);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(356, 33);
            this.button5.TabIndex = 38;
            this.button5.Text = "Record Mileage";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(356, 33);
            this.button4.TabIndex = 37;
            this.button4.Text = "Edit Staff Details";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(356, 33);
            this.button3.TabIndex = 36;
            this.button3.Text = "Track Records";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(356, 33);
            this.button6.TabIndex = 35;
            this.button6.Text = "Edit Vehicle Details";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Menu;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 232);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(356, 33);
            this.button7.TabIndex = 34;
            this.button7.Text = "New Vehicle Registration";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnRegisterStaff
            // 
            this.btnRegisterStaff.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRegisterStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterStaff.Location = new System.Drawing.Point(12, 170);
            this.btnRegisterStaff.Name = "btnRegisterStaff";
            this.btnRegisterStaff.Size = new System.Drawing.Size(356, 33);
            this.btnRegisterStaff.TabIndex = 33;
            this.btnRegisterStaff.Text = "Register Staff";
            this.btnRegisterStaff.UseVisualStyleBackColor = false;
            this.btnRegisterStaff.Click += new System.EventHandler(this.btnRegisterStaff_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(844, 126);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(115, 27);
            this.button8.TabIndex = 39;
            this.button8.Text = "View Details";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button9.Location = new System.Drawing.Point(460, 137);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 27);
            this.button9.TabIndex = 40;
            this.button9.Text = "Export to pdf";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(980, 126);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(115, 27);
            this.button10.TabIndex = 41;
            this.button10.Text = "Update Details";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // EditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1129, 676);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnRegisterStaff);
            this.Controls.Add(this.dgvVehicle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Details";
            this.Load += new System.EventHandler(this.EditVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnRegisterStaff;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChasisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlateNo;
        private System.Windows.Forms.Button button10;
    }
}