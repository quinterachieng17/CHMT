namespace KERICHO_CHMT
{
    partial class ApproverReferrals
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvAllCasesApproved = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonForReferral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseAttending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseOnTransit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOfCall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApprovalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCasesApproved)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(407, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "ALL REFERRAL CASES AT KERICHO COUNTY REFERRAL HOSPITAL";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1334, 590);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 39);
            this.tableLayoutPanel2.TabIndex = 10;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(41, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(171, 13);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Approve";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvAllCasesApproved
            // 
            this.dgvAllCasesApproved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllCasesApproved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCasesApproved.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientNo,
            this.PatientName,
            this.ReasonForReferral,
            this.Facility,
            this.NurseAttending,
            this.NurseOnTransit,
            this.DriverIncharge,
            this.DriverNo,
            this.RegNo,
            this.Date,
            this.TimeOfCall,
            this.ApprovalStatus});
            this.dgvAllCasesApproved.Location = new System.Drawing.Point(7, 87);
            this.dgvAllCasesApproved.Name = "dgvAllCasesApproved";
            this.dgvAllCasesApproved.Size = new System.Drawing.Size(1566, 511);
            this.dgvAllCasesApproved.TabIndex = 9;
            this.dgvAllCasesApproved.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllCases_CellContentClick);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "Patient ID";
            this.PatientID.Name = "PatientID";
            this.PatientID.Visible = false;
            // 
            // PatientNo
            // 
            this.PatientNo.DataPropertyName = "PatientNo";
            this.PatientNo.HeaderText = "Patient Number";
            this.PatientNo.Name = "PatientNo";
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.Width = 150;
            // 
            // ReasonForReferral
            // 
            this.ReasonForReferral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReasonForReferral.DataPropertyName = "ReasonForReferral";
            this.ReasonForReferral.HeaderText = "Reason For Referral";
            this.ReasonForReferral.Name = "ReasonForReferral";
            // 
            // Facility
            // 
            this.Facility.DataPropertyName = "Facility";
            this.Facility.HeaderText = "From Facility";
            this.Facility.Name = "Facility";
            this.Facility.Width = 150;
            // 
            // NurseAttending
            // 
            this.NurseAttending.DataPropertyName = "NurseReceiving";
            this.NurseAttending.HeaderText = "Receiving Nurse";
            this.NurseAttending.Name = "NurseAttending";
            this.NurseAttending.Width = 150;
            // 
            // NurseOnTransit
            // 
            this.NurseOnTransit.DataPropertyName = "NurseOnTransit";
            this.NurseOnTransit.HeaderText = "Nurse On Transit";
            this.NurseOnTransit.Name = "NurseOnTransit";
            this.NurseOnTransit.Width = 150;
            // 
            // DriverIncharge
            // 
            this.DriverIncharge.DataPropertyName = "DriverIncharge";
            this.DriverIncharge.HeaderText = "Driver In Charge";
            this.DriverIncharge.Name = "DriverIncharge";
            this.DriverIncharge.Width = 150;
            // 
            // DriverNo
            // 
            this.DriverNo.DataPropertyName = "DriverNo";
            this.DriverNo.HeaderText = "Driver Number";
            this.DriverNo.Name = "DriverNo";
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "Reg. No.";
            this.RegNo.Name = "RegNo";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date Registered";
            this.Date.Name = "Date";
            // 
            // TimeOfCall
            // 
            this.TimeOfCall.DataPropertyName = "TimeOfCall";
            this.TimeOfCall.HeaderText = "Time of Call";
            this.TimeOfCall.Name = "TimeOfCall";
            this.TimeOfCall.Width = 70;
            // 
            // ApprovalStatus
            // 
            this.ApprovalStatus.HeaderText = "Status";
            this.ApprovalStatus.Name = "ApprovalStatus";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1429F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1524, 57);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // ApproverReferrals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.dgvAllCasesApproved);
            this.Name = "ApproverReferrals";
            this.Text = "ApproverReferrals";
            this.Load += new System.EventHandler(this.ApproverReferrals_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCasesApproved)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvAllCasesApproved;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonForReferral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facility;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseAttending;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseOnTransit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOfCall;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApprovalStatus;
    }
}