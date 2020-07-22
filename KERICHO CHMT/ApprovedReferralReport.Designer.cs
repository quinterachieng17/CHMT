namespace KERICHO_CHMT
{
    partial class ApprovedReferralReport
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
            this.patientRegisterApprovedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet6 = new KERICHO_CHMT.cmbloginDataSet6();
            this.patientRegisterApprovedTableAdapter = new KERICHO_CHMT.cmbloginDataSet6TableAdapters.PatientRegisterApprovedTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbloginDataSet9 = new KERICHO_CHMT.cmbloginDataSet9();
            this.patientRegisterApprovedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientRegisterApprovedTableAdapter1 = new KERICHO_CHMT.cmbloginDataSet9TableAdapters.PatientRegisterApprovedTableAdapter();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonForReferralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseReceivingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverInchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nurseOnTransitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfCallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approvalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDelaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterApprovedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet6)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterApprovedBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1274, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
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
            this.nurseReceivingDataGridViewTextBoxColumn,
            this.regNoDataGridViewTextBoxColumn,
            this.driverInchargeDataGridViewTextBoxColumn,
            this.nurseOnTransitDataGridViewTextBoxColumn,
            this.driverNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeOfCallDataGridViewTextBoxColumn,
            this.approvalStatusDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.commentsDelaysDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientRegisterApprovedBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1440, 325);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientRegisterApprovedBindingSource
            // 
            this.patientRegisterApprovedBindingSource.DataMember = "PatientRegisterApproved";
            this.patientRegisterApprovedBindingSource.DataSource = this.cmbloginDataSet6;
            // 
            // cmbloginDataSet6
            // 
            this.cmbloginDataSet6.DataSetName = "cmbloginDataSet6";
            this.cmbloginDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientRegisterApprovedTableAdapter
            // 
            this.patientRegisterApprovedTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALL REFERRAL CASES TO KERICHO COUNTY REFERRAL HOSPITAL";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(165, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 43);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1446, 331);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(71, 462);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1352, 28);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // cmbloginDataSet9
            // 
            this.cmbloginDataSet9.DataSetName = "cmbloginDataSet9";
            this.cmbloginDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientRegisterApprovedBindingSource1
            // 
            this.patientRegisterApprovedBindingSource1.DataMember = "PatientRegisterApproved";
            this.patientRegisterApprovedBindingSource1.DataSource = this.cmbloginDataSet9;
            // 
            // patientRegisterApprovedTableAdapter1
            // 
            this.patientRegisterApprovedTableAdapter1.ClearBeforeFill = true;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nurseReceivingDataGridViewTextBoxColumn
            // 
            this.nurseReceivingDataGridViewTextBoxColumn.DataPropertyName = "NurseReceiving";
            this.nurseReceivingDataGridViewTextBoxColumn.HeaderText = "NurseReceiving";
            this.nurseReceivingDataGridViewTextBoxColumn.Name = "nurseReceivingDataGridViewTextBoxColumn";
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
            // approvalStatusDataGridViewTextBoxColumn
            // 
            this.approvalStatusDataGridViewTextBoxColumn.DataPropertyName = "ApprovalStatus";
            this.approvalStatusDataGridViewTextBoxColumn.HeaderText = "ApprovalStatus";
            this.approvalStatusDataGridViewTextBoxColumn.Name = "approvalStatusDataGridViewTextBoxColumn";
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            // 
            // commentsDelaysDataGridViewTextBoxColumn
            // 
            this.commentsDelaysDataGridViewTextBoxColumn.DataPropertyName = "CommentsDelays";
            this.commentsDelaysDataGridViewTextBoxColumn.HeaderText = "CommentsDelays";
            this.commentsDelaysDataGridViewTextBoxColumn.Name = "commentsDelaysDataGridViewTextBoxColumn";
            // 
            // ApprovedReferralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 491);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ApprovedReferralReport";
            this.Text = "ApprovedReferralReport";
            this.Load += new System.EventHandler(this.ApprovedReferralReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterApprovedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet6)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterApprovedBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cmbloginDataSet6 cmbloginDataSet6;
        private System.Windows.Forms.BindingSource patientRegisterApprovedBindingSource;
        private cmbloginDataSet6TableAdapters.PatientRegisterApprovedTableAdapter patientRegisterApprovedTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private cmbloginDataSet9 cmbloginDataSet9;
        private System.Windows.Forms.BindingSource patientRegisterApprovedBindingSource1;
        private cmbloginDataSet9TableAdapters.PatientRegisterApprovedTableAdapter patientRegisterApprovedTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForReferralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseReceivingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverInchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nurseOnTransitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfCallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDelaysDataGridViewTextBoxColumn;
    }
}