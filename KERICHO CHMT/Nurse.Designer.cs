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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblHead = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPatientDetails = new System.Windows.Forms.DataGridView();
            this.PatientNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonForReferral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseAttending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseOnTransit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncommingCase = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOutgoingCase = new System.Windows.Forms.Button();
            this.btnReferralCases = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chartReferrals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTransfers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReferrals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransfers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(154, -29);
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
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(564, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 31);
            this.label1.TabIndex = 31;
            this.label1.Text = "Referral Casses and Reports";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvPatientDetails
            // 
            this.dgvPatientDetails.AllowUserToAddRows = false;
            this.dgvPatientDetails.AllowUserToDeleteRows = false;
            this.dgvPatientDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPatientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientNo,
            this.PatientName,
            this.ReasonForReferral,
            this.NurseAttending,
            this.Facility,
            this.NurseOnTransit,
            this.DriverIncharge,
            this.DriverNo,
            this.RegNo});
            this.dgvPatientDetails.Location = new System.Drawing.Point(261, 133);
            this.dgvPatientDetails.Name = "dgvPatientDetails";
            this.dgvPatientDetails.ReadOnly = true;
            this.dgvPatientDetails.Size = new System.Drawing.Size(1208, 233);
            this.dgvPatientDetails.TabIndex = 34;
            this.dgvPatientDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientDetails_CellContentClick);
            this.dgvPatientDetails.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPatientDetails_MouseDoubleClick);
            // 
            // PatientNo
            // 
            this.PatientNo.DataPropertyName = "PatientNo";
            this.PatientNo.HeaderText = "Patient Number";
            this.PatientNo.Name = "PatientNo";
            this.PatientNo.ReadOnly = true;
            this.PatientNo.Width = 80;
            // 
            // PatientName
            // 
            this.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 120;
            // 
            // ReasonForReferral
            // 
            this.ReasonForReferral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReasonForReferral.DataPropertyName = "ReasonForReferral";
            this.ReasonForReferral.HeaderText = "Reason For Referral";
            this.ReasonForReferral.Name = "ReasonForReferral";
            this.ReasonForReferral.ReadOnly = true;
            // 
            // NurseAttending
            // 
            this.NurseAttending.DataPropertyName = "NurseAttending";
            this.NurseAttending.HeaderText = " Receiving/Referring Nurse";
            this.NurseAttending.Name = "NurseAttending";
            this.NurseAttending.ReadOnly = true;
            this.NurseAttending.Width = 150;
            // 
            // Facility
            // 
            this.Facility.DataPropertyName = "Facility";
            this.Facility.HeaderText = "From/To Facility";
            this.Facility.Name = "Facility";
            this.Facility.ReadOnly = true;
            // 
            // NurseOnTransit
            // 
            this.NurseOnTransit.DataPropertyName = "NurseOnTransit";
            this.NurseOnTransit.HeaderText = "Nurse On Transit";
            this.NurseOnTransit.Name = "NurseOnTransit";
            this.NurseOnTransit.ReadOnly = true;
            this.NurseOnTransit.Width = 150;
            // 
            // DriverIncharge
            // 
            this.DriverIncharge.DataPropertyName = "DriverIncharge";
            this.DriverIncharge.HeaderText = "Driver in Charge";
            this.DriverIncharge.Name = "DriverIncharge";
            this.DriverIncharge.ReadOnly = true;
            this.DriverIncharge.Width = 150;
            // 
            // DriverNo
            // 
            this.DriverNo.DataPropertyName = "DriverNo";
            this.DriverNo.HeaderText = "Driver Number";
            this.DriverNo.Name = "DriverNo";
            this.DriverNo.ReadOnly = true;
            this.DriverNo.Width = 120;
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "Vehicle Reg No";
            this.RegNo.Name = "RegNo";
            this.RegNo.ReadOnly = true;
            this.RegNo.Width = 80;
            // 
            // btnIncommingCase
            // 
            this.btnIncommingCase.Location = new System.Drawing.Point(1219, 104);
            this.btnIncommingCase.Name = "btnIncommingCase";
            this.btnIncommingCase.Size = new System.Drawing.Size(114, 23);
            this.btnIncommingCase.TabIndex = 35;
            this.btnIncommingCase.Text = "Incoming Referrals";
            this.btnIncommingCase.UseVisualStyleBackColor = true;
            this.btnIncommingCase.Click += new System.EventHandler(this.button2_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button10.Location = new System.Drawing.Point(263, 103);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 27);
            this.button10.TabIndex = 43;
            this.button10.Text = "Export to pdf";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(707, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Incoming Referral Cases";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOutgoingCase
            // 
            this.btnOutgoingCase.Location = new System.Drawing.Point(1357, 105);
            this.btnOutgoingCase.Name = "btnOutgoingCase";
            this.btnOutgoingCase.Size = new System.Drawing.Size(114, 23);
            this.btnOutgoingCase.TabIndex = 45;
            this.btnOutgoingCase.Text = "Outgoing Referrals";
            this.btnOutgoingCase.UseVisualStyleBackColor = true;
            this.btnOutgoingCase.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReferralCases
            // 
            this.btnReferralCases.BackColor = System.Drawing.Color.White;
            this.btnReferralCases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReferralCases.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferralCases.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnReferralCases.Image = ((System.Drawing.Image)(resources.GetObject("btnReferralCases.Image")));
            this.btnReferralCases.Location = new System.Drawing.Point(26, 289);
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
            this.button5.Location = new System.Drawing.Point(26, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(215, 132);
            this.button5.TabIndex = 30;
            this.button5.Text = "\r\n\r\n\r\n\r\n\r\nRegister Patient Details";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(26, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 192);
            this.button1.TabIndex = 26;
            this.button1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nView Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chartReferrals
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReferrals.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReferrals.Legends.Add(legend1);
            this.chartReferrals.Location = new System.Drawing.Point(263, 411);
            this.chartReferrals.Name = "chartReferrals";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "chartReferrals";
            this.chartReferrals.Series.Add(series1);
            this.chartReferrals.Size = new System.Drawing.Size(461, 256);
            this.chartReferrals.TabIndex = 46;
            this.chartReferrals.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Referrals";
            this.chartReferrals.Titles.Add(title1);
            // 
            // chartTransfers
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTransfers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTransfers.Legends.Add(legend2);
            this.chartTransfers.Location = new System.Drawing.Point(894, 411);
            this.chartTransfers.Name = "chartTransfers";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "ChartTransfers";
            this.chartTransfers.Series.Add(series2);
            this.chartTransfers.Size = new System.Drawing.Size(455, 240);
            this.chartTransfers.TabIndex = 47;
            this.chartTransfers.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Transfers";
            this.chartTransfers.Titles.Add(title2);
            this.chartTransfers.Click += new System.EventHandler(this.chartTransfers_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(4, 684);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1475, 15);
            this.button2.TabIndex = 48;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(4, 669);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1475, 15);
            this.button3.TabIndex = 49;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Nurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1483, 703);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chartTransfers);
            this.Controls.Add(this.chartReferrals);
            this.Controls.Add(this.btnOutgoingCase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnIncommingCase);
            this.Controls.Add(this.dgvPatientDetails);
            this.Controls.Add(this.btnReferralCases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHead);
            this.Name = "Nurse";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Nurse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartReferrals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTransfers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReferralCases;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvPatientDetails;
        private System.Windows.Forms.Button btnIncommingCase;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOutgoingCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonForReferral;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseAttending;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facility;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseOnTransit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReferrals;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransfers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}