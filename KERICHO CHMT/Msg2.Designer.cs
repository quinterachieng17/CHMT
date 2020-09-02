namespace KERICHO_CHMT
{
    partial class Msg2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Msg2));
            this.cmbPatientNo = new System.Windows.Forms.ComboBox();
            this.referralRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet10 = new KERICHO_CHMT.cmbloginDataSet10();
            this.patientRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet8 = new KERICHO_CHMT.cmbloginDataSet8();
            this.txtCommentsDelays = new System.Windows.Forms.TextBox();
            this.txtArrivalTime = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.patientRegisterTableAdapter = new KERICHO_CHMT.cmbloginDataSet8TableAdapters.PatientRegisterTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.referralRegisterTableAdapter = new KERICHO_CHMT.cmbloginDataSet10TableAdapters.ReferralRegisterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPatientNo
            // 
            this.cmbPatientNo.DataSource = this.referralRegisterBindingSource;
            this.cmbPatientNo.DisplayMember = "PatientNo";
            this.cmbPatientNo.FormattingEnabled = true;
            this.cmbPatientNo.Location = new System.Drawing.Point(270, 13);
            this.cmbPatientNo.Name = "cmbPatientNo";
            this.cmbPatientNo.Size = new System.Drawing.Size(271, 21);
            this.cmbPatientNo.TabIndex = 15;
            this.cmbPatientNo.ValueMember = "PatientNo";
            // 
            // referralRegisterBindingSource
            // 
            this.referralRegisterBindingSource.DataMember = "ReferralRegister";
            this.referralRegisterBindingSource.DataSource = this.cmbloginDataSet10;
            // 
            // cmbloginDataSet10
            // 
            this.cmbloginDataSet10.DataSetName = "cmbloginDataSet10";
            this.cmbloginDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientRegisterBindingSource
            // 
            this.patientRegisterBindingSource.DataMember = "PatientRegister";
            this.patientRegisterBindingSource.DataSource = this.cmbloginDataSet8;
            // 
            // cmbloginDataSet8
            // 
            this.cmbloginDataSet8.DataSetName = "cmbloginDataSet8";
            this.cmbloginDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCommentsDelays
            // 
            this.txtCommentsDelays.Location = new System.Drawing.Point(270, 114);
            this.txtCommentsDelays.Multiline = true;
            this.txtCommentsDelays.Name = "txtCommentsDelays";
            this.txtCommentsDelays.Size = new System.Drawing.Size(271, 76);
            this.txtCommentsDelays.TabIndex = 13;
            // 
            // txtArrivalTime
            // 
            this.txtArrivalTime.Location = new System.Drawing.Point(270, 66);
            this.txtArrivalTime.Name = "txtArrivalTime";
            this.txtArrivalTime.Size = new System.Drawing.Size(271, 20);
            this.txtArrivalTime.TabIndex = 12;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(476, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(346, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // patientRegisterTableAdapter
            // 
            this.patientRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Patient No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Comments/ Reasons for Delays";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Time of Arrival";
            // 
            // referralRegisterTableAdapter
            // 
            this.referralRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // Msg2
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(583, 261);
            this.Controls.Add(this.cmbPatientNo);
            this.Controls.Add(this.txtCommentsDelays);
            this.Controls.Add(this.txtArrivalTime);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Msg2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Msg2";
            this.Load += new System.EventHandler(this.Msg2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPatientNo;
        private System.Windows.Forms.BindingSource patientRegisterBindingSource;
        private cmbloginDataSet8 cmbloginDataSet8;
        private System.Windows.Forms.TextBox txtCommentsDelays;
        private System.Windows.Forms.TextBox txtArrivalTime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private cmbloginDataSet8TableAdapters.PatientRegisterTableAdapter patientRegisterTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private cmbloginDataSet10 cmbloginDataSet10;
        private System.Windows.Forms.BindingSource referralRegisterBindingSource;
        private cmbloginDataSet10TableAdapters.ReferralRegisterTableAdapter referralRegisterTableAdapter;
    }
}