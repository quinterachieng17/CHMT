namespace KERICHO_CHMT
{
    partial class Transfers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfers));
            this.dgvSpecificSearch = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReasonForReferral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseReceiving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverIncharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurseOnTransit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPatientNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSpecificSearch
            // 
            this.dgvSpecificSearch.AllowUserToAddRows = false;
            this.dgvSpecificSearch.AllowUserToDeleteRows = false;
            this.dgvSpecificSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSpecificSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSpecificSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSpecificSearch.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvSpecificSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecificSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.PatientNo,
            this.ReasonForReferral,
            this.Facility,
            this.NurseReceiving,
            this.RegNo,
            this.DriverIncharge,
            this.NurseOnTransit,
            this.DriverNo});
            this.dgvSpecificSearch.Location = new System.Drawing.Point(32, 222);
            this.dgvSpecificSearch.Name = "dgvSpecificSearch";
            this.dgvSpecificSearch.ReadOnly = true;
            this.dgvSpecificSearch.Size = new System.Drawing.Size(1444, 411);
            this.dgvSpecificSearch.TabIndex = 12;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Visible = false;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // PatientNo
            // 
            this.PatientNo.DataPropertyName = "PatientNo";
            this.PatientNo.HeaderText = "Patient Number";
            this.PatientNo.Name = "PatientNo";
            this.PatientNo.ReadOnly = true;
            // 
            // ReasonForReferral
            // 
            this.ReasonForReferral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReasonForReferral.DataPropertyName = "ReasonForReferral";
            this.ReasonForReferral.HeaderText = "Reason For Referral";
            this.ReasonForReferral.Name = "ReasonForReferral";
            this.ReasonForReferral.ReadOnly = true;
            // 
            // Facility
            // 
            this.Facility.DataPropertyName = "Facility";
            this.Facility.HeaderText = "Facility From/To";
            this.Facility.Name = "Facility";
            this.Facility.ReadOnly = true;
            // 
            // NurseReceiving
            // 
            this.NurseReceiving.DataPropertyName = "NurseReceiving";
            this.NurseReceiving.HeaderText = "Receiving Nurse";
            this.NurseReceiving.Name = "NurseReceiving";
            this.NurseReceiving.ReadOnly = true;
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "Reg Number";
            this.RegNo.Name = "RegNo";
            this.RegNo.ReadOnly = true;
            // 
            // DriverIncharge
            // 
            this.DriverIncharge.DataPropertyName = "DriverIncharge";
            this.DriverIncharge.HeaderText = "Driver In Charge";
            this.DriverIncharge.Name = "DriverIncharge";
            this.DriverIncharge.ReadOnly = true;
            // 
            // NurseOnTransit
            // 
            this.NurseOnTransit.DataPropertyName = "NurseOnTransit";
            this.NurseOnTransit.HeaderText = "Nurse On Transit";
            this.NurseOnTransit.Name = "NurseOnTransit";
            this.NurseOnTransit.ReadOnly = true;
            // 
            // DriverNo
            // 
            this.DriverNo.DataPropertyName = "DriverNo";
            this.DriverNo.HeaderText = "Driver\'s Number";
            this.DriverNo.Name = "DriverNo";
            this.DriverNo.ReadOnly = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.SystemColors.Menu;
            this.btnOK.Location = new System.Drawing.Point(1257, 669);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "Print";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1361, 669);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Patient Records";
            // 
            // txtPatientNo
            // 
            this.txtPatientNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPatientNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientNo.Location = new System.Drawing.Point(672, 182);
            this.txtPatientNo.Name = "txtPatientNo";
            this.txtPatientNo.Size = new System.Drawing.Size(196, 25);
            this.txtPatientNo.TabIndex = 8;
            this.txtPatientNo.TextChanged += new System.EventHandler(this.txtPatientNo_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Patient No:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(293, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Outgoing Patient Records";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(494, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(665, 36);
            this.label5.TabIndex = 67;
            this.label5.Text = "KERICHO COUNTY REFERRAL HOSPITAL";
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 698);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1508, 15);
            this.button2.TabIndex = 69;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Location = new System.Drawing.Point(0, 713);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1508, 15);
            this.button6.TabIndex = 70;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "label3";
            // 
            // Transfers
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1508, 728);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSpecificSearch);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPatientNo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transfers";
            this.Text = "Outgoing Referrals";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transfers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecificSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSpecificSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReasonForReferral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facility;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseReceiving;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverIncharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseOnTransit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverNo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPatientNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
    }
}