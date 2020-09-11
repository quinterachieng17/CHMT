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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApprovedTransferReport));
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referralRegisterApprovedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet11 = new KERICHO_CHMT.cmbloginDataSet11();
            this.referralRegisterApprovedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet7 = new KERICHO_CHMT.cmbloginDataSet7();
            this.referralRegisterApprovedTableAdapter = new KERICHO_CHMT.cmbloginDataSet7TableAdapters.ReferralRegisterApprovedTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.referralRegisterApprovedTableAdapter1 = new KERICHO_CHMT.cmbloginDataSet11TableAdapters.ReferralRegisterApprovedTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterApprovedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterApprovedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet7)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(1395, 522);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
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
            this.timeDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.referralRegisterApprovedBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(94, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1321, 405);
            this.dataGridView1.TabIndex = 1;
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
            this.patientNameDataGridViewTextBoxColumn.HeaderText = "Patient Name";
            this.patientNameDataGridViewTextBoxColumn.Name = "patientNameDataGridViewTextBoxColumn";
            // 
            // patientNoDataGridViewTextBoxColumn
            // 
            this.patientNoDataGridViewTextBoxColumn.DataPropertyName = "PatientNo";
            this.patientNoDataGridViewTextBoxColumn.HeaderText = "Patient No";
            this.patientNoDataGridViewTextBoxColumn.Name = "patientNoDataGridViewTextBoxColumn";
            // 
            // reasonForReferralDataGridViewTextBoxColumn
            // 
            this.reasonForReferralDataGridViewTextBoxColumn.DataPropertyName = "ReasonForReferral";
            this.reasonForReferralDataGridViewTextBoxColumn.HeaderText = "Reason For Referral";
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
            this.nurseReferringDataGridViewTextBoxColumn.HeaderText = "Nurse Referring";
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
            this.driverInchargeDataGridViewTextBoxColumn.HeaderText = "Driver In Charge";
            this.driverInchargeDataGridViewTextBoxColumn.Name = "driverInchargeDataGridViewTextBoxColumn";
            // 
            // nurseOnTransitDataGridViewTextBoxColumn
            // 
            this.nurseOnTransitDataGridViewTextBoxColumn.DataPropertyName = "NurseOnTransit";
            this.nurseOnTransitDataGridViewTextBoxColumn.HeaderText = "Nurse On Transit";
            this.nurseOnTransitDataGridViewTextBoxColumn.Name = "nurseOnTransitDataGridViewTextBoxColumn";
            // 
            // driverNoDataGridViewTextBoxColumn
            // 
            this.driverNoDataGridViewTextBoxColumn.DataPropertyName = "DriverNo";
            this.driverNoDataGridViewTextBoxColumn.HeaderText = "Driver No";
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
            this.timeOfCallDataGridViewTextBoxColumn.HeaderText = "Time Of Call";
            this.timeOfCallDataGridViewTextBoxColumn.Name = "timeOfCallDataGridViewTextBoxColumn";
            // 
            // transferStatusDataGridViewTextBoxColumn
            // 
            this.transferStatusDataGridViewTextBoxColumn.DataPropertyName = "TransferStatus";
            this.transferStatusDataGridViewTextBoxColumn.HeaderText = "Transfer Status";
            this.transferStatusDataGridViewTextBoxColumn.Name = "transferStatusDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Arrival Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments/ Delays";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // referralRegisterApprovedBindingSource1
            // 
            this.referralRegisterApprovedBindingSource1.DataMember = "ReferralRegisterApproved";
            this.referralRegisterApprovedBindingSource1.DataSource = this.cmbloginDataSet11;
            // 
            // cmbloginDataSet11
            // 
            this.cmbloginDataSet11.DataSetName = "cmbloginDataSet11";
            this.cmbloginDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "KERICHO COUNTY REFERRAL HOSPITAL";
            // 
            // referralRegisterApprovedTableAdapter1
            // 
            this.referralRegisterApprovedTableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1514, 75);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transfer Cases Approved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 551);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1514, 15);
            this.button2.TabIndex = 64;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Location = new System.Drawing.Point(0, 566);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1514, 15);
            this.button6.TabIndex = 65;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1314, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ApprovedTransferReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(1514, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApprovedTransferReport";
            this.Text = "Approved Transfer Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ApprovedTransferReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterApprovedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterApprovedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet7)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private cmbloginDataSet7 cmbloginDataSet7;
        private System.Windows.Forms.BindingSource referralRegisterApprovedBindingSource;
        private cmbloginDataSet7TableAdapters.ReferralRegisterApprovedTableAdapter referralRegisterApprovedTableAdapter;
        private System.Windows.Forms.Label label1;
        private cmbloginDataSet11 cmbloginDataSet11;
        private System.Windows.Forms.BindingSource referralRegisterApprovedBindingSource1;
        private cmbloginDataSet11TableAdapters.ReferralRegisterApprovedTableAdapter referralRegisterApprovedTableAdapter1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
    }
}