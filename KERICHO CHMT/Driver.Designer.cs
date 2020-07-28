namespace KERICHO_CHMT
{
    partial class Driver
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
            this.DriverID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.lblMileageReading = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOilDrawn = new System.Windows.Forms.TextBox();
            this.txtFuelDrawn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDriverNo = new System.Windows.Forms.ComboBox();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.cmbloginDataSet20 = new KERICHO_CHMT.cmbloginDataSet20();
            this.userRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRegisterTableAdapter = new KERICHO_CHMT.cmbloginDataSet20TableAdapters.UserRegisterTableAdapter();
            this.cmbloginDataSet21 = new KERICHO_CHMT.cmbloginDataSet21();
            this.vehicleRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleRegistrationTableAdapter = new KERICHO_CHMT.cmbloginDataSet21TableAdapters.VehicleRegistrationTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegistrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverID
            // 
            this.DriverID.AutoSize = true;
            this.DriverID.BackColor = System.Drawing.Color.Transparent;
            this.DriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverID.ForeColor = System.Drawing.Color.Black;
            this.DriverID.Location = new System.Drawing.Point(19, 98);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(86, 18);
            this.DriverID.TabIndex = 29;
            this.DriverID.Text = "Driver\'s  No";
            this.DriverID.Click += new System.EventHandler(this.DriverID_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(623, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(708, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(174, 156);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(200, 20);
            this.txtMileage.TabIndex = 22;
            this.txtMileage.TextChanged += new System.EventHandler(this.txtMileage_TextChanged);
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // lblMileageReading
            // 
            this.lblMileageReading.AutoSize = true;
            this.lblMileageReading.BackColor = System.Drawing.Color.Transparent;
            this.lblMileageReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileageReading.ForeColor = System.Drawing.Color.Black;
            this.lblMileageReading.Location = new System.Drawing.Point(19, 158);
            this.lblMileageReading.Name = "lblMileageReading";
            this.lblMileageReading.Size = new System.Drawing.Size(117, 18);
            this.lblMileageReading.TabIndex = 21;
            this.lblMileageReading.Text = "Mileage Reading";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.ForeColor = System.Drawing.Color.Black;
            this.lblRegNo.Location = new System.Drawing.Point(19, 129);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(118, 18);
            this.lblRegNo.TabIndex = 19;
            this.lblRegNo.Text = "Vehicle Reg. No.";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(218, 18);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(365, 32);
            this.lblHead.TabIndex = 16;
            this.lblHead.Text = "KERICHO COUNTY TIMS";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(654, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 29);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(543, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(491, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Oil Drawn";
            // 
            // txtOilDrawn
            // 
            this.txtOilDrawn.Location = new System.Drawing.Point(608, 127);
            this.txtOilDrawn.Name = "txtOilDrawn";
            this.txtOilDrawn.Size = new System.Drawing.Size(277, 20);
            this.txtOilDrawn.TabIndex = 34;
            this.txtOilDrawn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // txtFuelDrawn
            // 
            this.txtFuelDrawn.Location = new System.Drawing.Point(608, 158);
            this.txtFuelDrawn.Name = "txtFuelDrawn";
            this.txtFuelDrawn.Size = new System.Drawing.Size(277, 20);
            this.txtFuelDrawn.TabIndex = 36;
            this.txtFuelDrawn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(491, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fuel Drawn";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(174, 188);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(711, 60);
            this.txtDestination.TabIndex = 38;
            this.txtDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestination_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Destination Details";
            // 
            // cmbDriverNo
            // 
            this.cmbDriverNo.DataSource = this.userRegisterBindingSource;
            this.cmbDriverNo.DisplayMember = "IDNumber";
            this.cmbDriverNo.FormattingEnabled = true;
            this.cmbDriverNo.Location = new System.Drawing.Point(174, 95);
            this.cmbDriverNo.Name = "cmbDriverNo";
            this.cmbDriverNo.Size = new System.Drawing.Size(200, 21);
            this.cmbDriverNo.TabIndex = 39;
            this.cmbDriverNo.ValueMember = "IDNumber";
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.DataSource = this.vehicleRegistrationBindingSource;
            this.cmbRegNo.DisplayMember = "PlateNo";
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(174, 130);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(200, 21);
            this.cmbRegNo.TabIndex = 40;
            this.cmbRegNo.ValueMember = "PlateNo";
            // 
            // cmbloginDataSet20
            // 
            this.cmbloginDataSet20.DataSetName = "cmbloginDataSet20";
            this.cmbloginDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRegisterBindingSource
            // 
            this.userRegisterBindingSource.DataMember = "UserRegister";
            this.userRegisterBindingSource.DataSource = this.cmbloginDataSet20;
            // 
            // userRegisterTableAdapter
            // 
            this.userRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // cmbloginDataSet21
            // 
            this.cmbloginDataSet21.DataSetName = "cmbloginDataSet21";
            this.cmbloginDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleRegistrationBindingSource
            // 
            this.vehicleRegistrationBindingSource.DataMember = "VehicleRegistration";
            this.vehicleRegistrationBindingSource.DataSource = this.cmbloginDataSet21;
            // 
            // vehicleRegistrationTableAdapter
            // 
            this.vehicleRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(486, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "LPG Station";
            // 
            // cmbStation
            // 
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Items.AddRange(new object[] {
            "Jumbo",
            "Kipsigis",
            "Homelins"});
            this.cmbStation.Location = new System.Drawing.Point(608, 91);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(277, 21);
            this.cmbStation.TabIndex = 42;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 396);
            this.Controls.Add(this.cmbStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRegNo);
            this.Controls.Add(this.cmbDriverNo);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFuelDrawn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOilDrawn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.DriverID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.lblMileageReading);
            this.Controls.Add(this.lblRegNo);
            this.Controls.Add(this.lblHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegistrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DriverID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label lblMileageReading;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOilDrawn;
        private System.Windows.Forms.TextBox txtFuelDrawn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDriverNo;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private cmbloginDataSet20 cmbloginDataSet20;
        private System.Windows.Forms.BindingSource userRegisterBindingSource;
        private cmbloginDataSet20TableAdapters.UserRegisterTableAdapter userRegisterTableAdapter;
        private cmbloginDataSet21 cmbloginDataSet21;
        private System.Windows.Forms.BindingSource vehicleRegistrationBindingSource;
        private cmbloginDataSet21TableAdapters.VehicleRegistrationTableAdapter vehicleRegistrationTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStation;
    }
}