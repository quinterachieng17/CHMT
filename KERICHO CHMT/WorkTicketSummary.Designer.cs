namespace KERICHO_CHMT
{
    partial class WorkTicketSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtoilConsumed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtfuelConsumed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtlpgStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMileageReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFinalSpeedReading = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtjourneyKilometer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAuthorizingOfficerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAuthorizingOfficerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAuthorizingOfficerDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUserID,
            this.txtDate,
            this.txtDriverID,
            this.txtRegNo,
            this.txtDestination,
            this.txtoilConsumed,
            this.txtfuelConsumed,
            this.txtVoucherNo,
            this.txtlpgStation,
            this.txtMileageReading,
            this.txtFinalSpeedReading,
            this.txtjourneyKilometer,
            this.txtAuthorizingOfficerName,
            this.txtAuthorizingOfficerNo,
            this.txtAuthorizingOfficerDesignation});
            this.dgv2.Location = new System.Drawing.Point(36, 135);
            this.dgv2.Name = "dgv2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv2.RowHeadersWidth = 100;
            this.dgv2.Size = new System.Drawing.Size(1426, 454);
            this.dgv2.TabIndex = 0;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            this.dgv2.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellValueChanged);
            this.dgv2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv2_UserDeletingRow);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnView.Location = new System.Drawing.Point(119, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Homeline";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(1394, 597);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button10.Location = new System.Drawing.Point(36, 106);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 27);
            this.button10.TabIndex = 42;
            this.button10.Text = "Export to pdf";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.51295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.48705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.btnView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1186, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 33);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(203, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Kipsigis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Location = new System.Drawing.Point(35, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Jumbo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Work Ticket Summary";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1502, 31);
            this.tableLayoutPanel2.TabIndex = 45;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "label2";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, -6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1502, 52);
            this.tableLayoutPanel3.TabIndex = 47;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(521, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "KERICHO COUNTY REFERRAL HOSPITAL";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(678, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Select a Filling Station";
            // 
            // txtUserID
            // 
            this.txtUserID.DataPropertyName = "UserID";
            this.txtUserID.HeaderText = "UserID";
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Visible = false;
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "Date";
            this.txtDate.HeaderText = "Date";
            this.txtDate.Name = "txtDate";
            // 
            // txtDriverID
            // 
            this.txtDriverID.DataPropertyName = "DriverID";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriverID.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtDriverID.HeaderText = "Driver\'s  No";
            this.txtDriverID.Name = "txtDriverID";
            // 
            // txtRegNo
            // 
            this.txtRegNo.DataPropertyName = "RegNo";
            this.txtRegNo.HeaderText = "Reg No.";
            this.txtRegNo.Name = "txtRegNo";
            // 
            // txtDestination
            // 
            this.txtDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDestination.DataPropertyName = "Destination";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.txtDestination.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtDestination.HeaderText = "Details of Journey and Route in full";
            this.txtDestination.Name = "txtDestination";
            // 
            // txtoilConsumed
            // 
            this.txtoilConsumed.DataPropertyName = "OilDrawn";
            this.txtoilConsumed.HeaderText = "Oil Drawn(Litres)";
            this.txtoilConsumed.Name = "txtoilConsumed";
            // 
            // txtfuelConsumed
            // 
            this.txtfuelConsumed.DataPropertyName = "FuelDrawn";
            this.txtfuelConsumed.HeaderText = "Fuel Drawn(Litres)";
            this.txtfuelConsumed.Name = "txtfuelConsumed";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.DataPropertyName = "VoucherNo";
            this.txtVoucherNo.HeaderText = "P.O.L (S 15). Voucher No. or Cash Voucher No";
            this.txtVoucherNo.Name = "txtVoucherNo";
            // 
            // txtlpgStation
            // 
            this.txtlpgStation.DataPropertyName = "lpgStation";
            this.txtlpgStation.HeaderText = "Station";
            this.txtlpgStation.Name = "txtlpgStation";
            // 
            // txtMileageReading
            // 
            this.txtMileageReading.DataPropertyName = "MileageReading";
            this.txtMileageReading.HeaderText = "Initial Speed Reading";
            this.txtMileageReading.Name = "txtMileageReading";
            // 
            // txtFinalSpeedReading
            // 
            this.txtFinalSpeedReading.DataPropertyName = "FinalSpeedReading";
            this.txtFinalSpeedReading.HeaderText = "Speed Reading end of journey";
            this.txtFinalSpeedReading.Name = "txtFinalSpeedReading";
            // 
            // txtjourneyKilometer
            // 
            this.txtjourneyKilometer.DataPropertyName = "journeyKilometer";
            this.txtjourneyKilometer.HeaderText = "Kilometer of Journey";
            this.txtjourneyKilometer.Name = "txtjourneyKilometer";
            // 
            // txtAuthorizingOfficerName
            // 
            this.txtAuthorizingOfficerName.DataPropertyName = "AuthorizingOfficerName";
            this.txtAuthorizingOfficerName.HeaderText = "Name of Authorizing Officer";
            this.txtAuthorizingOfficerName.Name = "txtAuthorizingOfficerName";
            // 
            // txtAuthorizingOfficerNo
            // 
            this.txtAuthorizingOfficerNo.DataPropertyName = "AuthorizingOfficerNo";
            this.txtAuthorizingOfficerNo.HeaderText = "Number of Authorizing Officer";
            this.txtAuthorizingOfficerNo.Name = "txtAuthorizingOfficerNo";
            // 
            // txtAuthorizingOfficerDesignation
            // 
            this.txtAuthorizingOfficerDesignation.DataPropertyName = "AuthorizingOfficerDesignation";
            this.txtAuthorizingOfficerDesignation.HeaderText = "Designation of the Authorizing Officer";
            this.txtAuthorizingOfficerDesignation.Name = "txtAuthorizingOfficerDesignation";
            // 
            // WorkTicketSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1506, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.dgv2);
            this.Name = "WorkTicketSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Work  Ticket  Summary";
            this.Load += new System.EventHandler(this.WorkTicketSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtoilConsumed;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtfuelConsumed;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtlpgStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMileageReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFinalSpeedReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtjourneyKilometer;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAuthorizingOfficerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAuthorizingOfficerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAuthorizingOfficerDesignation;
    }
}