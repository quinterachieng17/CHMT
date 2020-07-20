namespace KERICHO_CHMT
{
    partial class ApprovedTransferReport
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.referralRegisterApprovedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet7 = new KERICHO_CHMT.cmbloginDataSet7();
            this.referralRegisterApprovedTableAdapter = new KERICHO_CHMT.cmbloginDataSet7TableAdapters.ReferralRegisterApprovedTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForReferralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseReferringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverInchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseOnTransitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfCallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsDelays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterApprovedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1366, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIDDataGridViewTextBoxColumn,
            this.patientNameDataGridViewTextBoxColumn,
            this.patientNoDataGridViewTextBoxColumn,
            this.reasonForReferralDataGridViewTextBoxColumn,
            this.facilityDataGridViewTextBoxColumn,
            this.nurseReferringDataGridViewTextBoxColumn,
            this.regNoDataGridViewTextBoxColumn,
            this.driverInchargeDataGridViewTextBoxColumn,
            this.nurseOnTransitDataGridViewTextBoxColumn,
            this.driverNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeOfCallDataGridViewTextBoxColumn,
            this.transferStatusDataGridViewTextBoxColumn,
            this.ArrivalTime,
            this.CommentsDelays});
            this.dataGridView1.DataSource = this.referralRegisterApprovedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1493, 435);
            this.dataGridView1.TabIndex = 1;
            // 
            // referralRegisterApprovedBindingSource
            // 
            this.referralRegisterApprovedBindingSource.DataMember = "ReferralRegisterApproved";
            this.referralRegisterApprovedBindingSource.DataSource = this.cmbloginDataSet7;
            // 
            // cmbloginDataSet7
            // 
            this.cmbloginDataSet7.DataSetName = "cmbloginDataSet7";
            this.cmbloginDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // referralRegisterApprovedTableAdapter
            // 
            this.referralRegisterApprovedTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transfer Cases Approved";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // patientNameDataGridViewTextBoxColumn
            // 
            this.patientNameDataGridViewTextBoxColumn.DataPropertyName = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "PatientName";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientNoDataGridViewTextBoxColumn
            // 
            this.patientNoDataGridViewTextBoxColumn.DataPropertyName = "PatientNo";
            this.patientNoDataGridViewTextBoxColumn.HeaderText = "PatientNo";
            this.patientNoDataGridViewTextBoxColumn.Name = "patientNoDataGridViewTextBoxColumn";
            // 
            // reasonForReferralDataGridViewTextBoxColumn
            // 
            this.reasonForReferralDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reasonForReferralDataGridViewTextBoxColumn.DataPropertyName = "ReasonForReferral";
            this.reasonForReferralDataGridViewTextBoxColumn.HeaderText = "ReasonForReferral";
            this.reasonForReferralDataGridViewTextBoxColumn.Name = "reasonForReferralDataGridViewTextBoxColumn";
            // 
            // facilityDataGridViewTextBoxColumn
            // 
            this.facilityDataGridViewTextBoxColumn.DataPropertyName = "Facility";
            this.facilityDataGridViewTextBoxColumn.HeaderText = "Facility";
            this.facilityDataGridViewTextBoxColumn.Name = "facilityDataGridViewTextBoxColumn";
            // 
            // nurseReferringDataGridViewTextBoxColumn
            // 
            this.nurseReferringDataGridViewTextBoxColumn.DataPropertyName = "NurseReferring";
            this.nurseReferringDataGridViewTextBoxColumn.HeaderText = "NurseReferring";
            this.nurseReferringDataGridViewTextBoxColumn.Name = "nurseReferringDataGridViewTextBoxColumn";
            // 
            // regNoDataGridViewTextBoxColumn
            // 
            this.regNoDataGridViewTextBoxColumn.DataPropertyName = "RegNo";
            this.regNoDataGridViewTextBoxColumn.HeaderText = "RegNo";
            this.regNoDataGridViewTextBoxColumn.Name = "regNoDataGridViewTextBoxColumn";
            // 
            // driverInchargeDataGridViewTextBoxColumn
            // 
            this.driverInchargeDataGridViewTextBoxColumn.DataPropertyName = "DriverIncharge";
            this.driverInchargeDataGridViewTextBoxColumn.HeaderText = "DriverIncharge";
            this.driverInchargeDataGridViewTextBoxColumn.Name = "driverInchargeDataGridViewTextBoxColumn";
            // 
            // nurseOnTransitDataGridViewTextBoxColumn
            // 
            this.nurseOnTransitDataGridViewTextBoxColumn.DataPropertyName = "NurseOnTransit";
            this.nurseOnTransitDataGridViewTextBoxColumn.HeaderText = "NurseOnTransit";
            this.nurseOnTransitDataGridViewTextBoxColumn.Name = "nurseOnTransitDataGridViewTextBoxColumn";
            // 
            // driverNoDataGridViewTextBoxColumn
            // 
            this.driverNoDataGridViewTextBoxColumn.DataPropertyName = "DriverNo";
            this.driverNoDataGridViewTextBoxColumn.HeaderText = "DriverNo";
            this.driverNoDataGridViewTextBoxColumn.Name = "driverNoDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeOfCallDataGridViewTextBoxColumn
            // 
            this.timeOfCallDataGridViewTextBoxColumn.DataPropertyName = "TimeOfCall";
            this.timeOfCallDataGridViewTextBoxColumn.HeaderText = "TimeOfCall";
            this.timeOfCallDataGridViewTextBoxColumn.Name = "timeOfCallDataGridViewTextBoxColumn";
            // 
            // transferStatusDataGridViewTextBoxColumn
            // 
            this.transferStatusDataGridViewTextBoxColumn.DataPropertyName = "TransferStatus";
            this.transferStatusDataGridViewTextBoxColumn.HeaderText = "TransferStatus";
            this.transferStatusDataGridViewTextBoxColumn.Name = "transferStatusDataGridViewTextBoxColumn";
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.HeaderText = "Arrival Time";
            this.ArrivalTime.Name = "ArrivalTime";
            // 
            // CommentsDelays
            // 
            this.CommentsDelays.HeaderText = "Comments/ Reasons for Delays";
            this.CommentsDelays.Name = "CommentsDelays";
            // 
            // ApprovedTransferReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ApprovedTransferReport";
            this.Text = "ApprovedTransferReport";
            this.Load += new System.EventHandler(this.ApprovedTransferReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterApprovedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cmbloginDataSet7 cmbloginDataSet7;
        private System.Windows.Forms.BindingSource referralRegisterApprovedBindingSource;
        private cmbloginDataSet7TableAdapters.ReferralRegisterApprovedTableAdapter referralRegisterApprovedTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForReferralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseReferringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverInchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseOnTransitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfCallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transferStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsDelays;
    }
}