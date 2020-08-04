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
            this.userRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet20 = new KERICHO_CHMT.cmbloginDataSet20();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.vehicleRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet21 = new KERICHO_CHMT.cmbloginDataSet21();
            this.userRegisterTableAdapter = new KERICHO_CHMT.cmbloginDataSet20TableAdapters.UserRegisterTableAdapter();
            this.vehicleRegistrationTableAdapter = new KERICHO_CHMT.cmbloginDataSet21TableAdapters.VehicleRegistrationTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet21)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriverID
            // 
            this.DriverID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DriverID.AutoSize = true;
            this.DriverID.BackColor = System.Drawing.Color.Transparent;
            this.DriverID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverID.ForeColor = System.Drawing.Color.Black;
            this.DriverID.Location = new System.Drawing.Point(3, 8);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(86, 18);
            this.DriverID.TabIndex = 29;
            this.DriverID.Text = "Driver\'s  No";
            this.DriverID.Click += new System.EventHandler(this.DriverID_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(53, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 18);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // txtMileage
            // 
            this.txtMileage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMileage.Location = new System.Drawing.Point(232, 75);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(200, 20);
            this.txtMileage.TabIndex = 22;
            this.txtMileage.TextChanged += new System.EventHandler(this.txtMileage_TextChanged);
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // lblMileageReading
            // 
            this.lblMileageReading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMileageReading.AutoSize = true;
            this.lblMileageReading.BackColor = System.Drawing.Color.Transparent;
            this.lblMileageReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileageReading.ForeColor = System.Drawing.Color.Black;
            this.lblMileageReading.Location = new System.Drawing.Point(3, 76);
            this.lblMileageReading.Name = "lblMileageReading";
            this.lblMileageReading.Size = new System.Drawing.Size(117, 18);
            this.lblMileageReading.TabIndex = 21;
            this.lblMileageReading.Text = "Mileage Reading";
            // 
            // lblRegNo
            // 
            this.lblRegNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.ForeColor = System.Drawing.Color.Black;
            this.lblRegNo.Location = new System.Drawing.Point(3, 42);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(118, 18);
            this.lblRegNo.TabIndex = 19;
            this.lblRegNo.Text = "Vehicle Reg. No.";
            // 
            // lblHead
            // 
            this.lblHead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(264, 4);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(386, 26);
            this.lblHead.TabIndex = 16;
            this.lblHead.Text = "RECORD INDIVIDUAL MILEAGE";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmit.Location = new System.Drawing.Point(166, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(44, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(461, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Oil Drawn";
            // 
            // txtOilDrawn
            // 
            this.txtOilDrawn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOilDrawn.Location = new System.Drawing.Point(690, 41);
            this.txtOilDrawn.Name = "txtOilDrawn";
            this.txtOilDrawn.Size = new System.Drawing.Size(225, 20);
            this.txtOilDrawn.TabIndex = 34;
            this.txtOilDrawn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // txtFuelDrawn
            // 
            this.txtFuelDrawn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFuelDrawn.Location = new System.Drawing.Point(690, 75);
            this.txtFuelDrawn.Name = "txtFuelDrawn";
            this.txtFuelDrawn.Size = new System.Drawing.Size(225, 20);
            this.txtFuelDrawn.TabIndex = 36;
            this.txtFuelDrawn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(461, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fuel Drawn";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(230, 3);
            this.txtDestination.Multiline = true;
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(683, 44);
            this.txtDestination.TabIndex = 38;
            this.txtDestination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestination_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Destination Details";
            // 
            // cmbDriverNo
            // 
            this.cmbDriverNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDriverNo.DataSource = this.userRegisterBindingSource;
            this.cmbDriverNo.DisplayMember = "IDNumber";
            this.cmbDriverNo.FormattingEnabled = true;
            this.cmbDriverNo.Location = new System.Drawing.Point(232, 6);
            this.cmbDriverNo.Name = "cmbDriverNo";
            this.cmbDriverNo.Size = new System.Drawing.Size(200, 21);
            this.cmbDriverNo.TabIndex = 39;
            this.cmbDriverNo.ValueMember = "IDNumber";
            // 
            // userRegisterBindingSource
            // 
            this.userRegisterBindingSource.DataMember = "UserRegister";
            this.userRegisterBindingSource.DataSource = this.cmbloginDataSet20;
            // 
            // cmbloginDataSet20
            // 
            this.cmbloginDataSet20.DataSetName = "cmbloginDataSet20";
            this.cmbloginDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbRegNo.DataSource = this.vehicleRegistrationBindingSource;
            this.cmbRegNo.DisplayMember = "PlateNo";
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(232, 40);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(200, 21);
            this.cmbRegNo.TabIndex = 40;
            this.cmbRegNo.ValueMember = "PlateNo";
            // 
            // vehicleRegistrationBindingSource
            // 
            this.vehicleRegistrationBindingSource.DataMember = "VehicleRegistration";
            this.vehicleRegistrationBindingSource.DataSource = this.cmbloginDataSet21;
            // 
            // cmbloginDataSet21
            // 
            this.cmbloginDataSet21.DataSetName = "cmbloginDataSet21";
            this.cmbloginDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userRegisterTableAdapter
            // 
            this.userRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleRegistrationTableAdapter
            // 
            this.vehicleRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(461, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "LPG Station";
            // 
            // cmbStation
            // 
            this.cmbStation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Items.AddRange(new object[] {
            "Jumbo",
            "Kipsigis",
            "Homeline"});
            this.cmbStation.Location = new System.Drawing.Point(690, 6);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(225, 21);
            this.cmbStation.TabIndex = 42;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.DriverID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbStation, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRegNo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFuelDrawn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOilDrawn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMileageReading, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbDriverNo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbRegNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMileage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 103);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblHead, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(24, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(915, 34);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.lblDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(625, 59);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(317, 32);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.8366F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.1634F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtDestination, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(24, 207);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(918, 50);
            this.tableLayoutPanel4.TabIndex = 46;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(698, 265);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(244, 32);
            this.tableLayoutPanel5.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "label5";
            // 
            // Driver
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(969, 316);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Driver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driver";
            this.Load += new System.EventHandler(this.Driver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet21)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
    }
}