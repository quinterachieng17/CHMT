namespace KERICHO_CHMT
{
    partial class Accounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLpoNo = new System.Windows.Forms.TextBox();
            this.txtPayments = new System.Windows.Forms.TextBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lpoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expenditure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOilDrawn = new System.Windows.Forms.TextBox();
            this.txtFuelDrawn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaintenance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.cmbVehicleNo = new System.Windows.Forms.ComboBox();
            this.cmbloginDataSet45 = new KERICHO_CHMT.cmbloginDataSet45();
            this.vehicleRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleRegistrationTableAdapter = new KERICHO_CHMT.cmbloginDataSet45TableAdapters.VehicleRegistrationTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegistrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "KERICHO COUNTY REFERRAL HOSPITAL";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Statement of Accounts.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Station";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vehicle No";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(599, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "L.P.O No";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(932, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment";
            // 
            // txtLpoNo
            // 
            this.txtLpoNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtLpoNo.Location = new System.Drawing.Point(674, 5);
            this.txtLpoNo.Name = "txtLpoNo";
            this.txtLpoNo.Size = new System.Drawing.Size(174, 20);
            this.txtLpoNo.TabIndex = 9;
            // 
            // txtPayments
            // 
            this.txtPayments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPayments.Location = new System.Drawing.Point(1002, 5);
            this.txtPayments.Name = "txtPayments";
            this.txtPayments.Size = new System.Drawing.Size(174, 20);
            this.txtPayments.TabIndex = 10;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.Date,
            this.Station,
            this.RegNo,
            this.lpoNo,
            this.Payments,
            this.Expenditure,
            this.Balance});
            this.dgvAccounts.Location = new System.Drawing.Point(121, 305);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.Size = new System.Drawing.Size(1216, 375);
            this.dgvAccounts.TabIndex = 11;
            // 
            // VehicleID
            // 
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.Visible = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Station
            // 
            this.Station.HeaderText = "Station";
            this.Station.Name = "Station";
            // 
            // RegNo
            // 
            this.RegNo.HeaderText = "Vehicle No";
            this.RegNo.Name = "RegNo";
            // 
            // lpoNo
            // 
            this.lpoNo.HeaderText = "L.P.O No";
            this.lpoNo.Name = "lpoNo";
            // 
            // Payments
            // 
            this.Payments.HeaderText = "Payments";
            this.Payments.Name = "Payments";
            // 
            // Expenditure
            // 
            this.Expenditure.HeaderText = "Expenditure";
            this.Expenditure.Name = "Expenditure";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(1262, 692);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(582, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Transport Office Department";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "To";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "From";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(295, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(508, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Preview";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.40876F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.Controls.Add(this.cmbVehicleNo, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtOthers, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbStation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOilDrawn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFuelDrawn, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMaintenance, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLpoNo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPayments, 7, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(122, 161);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1215, 63);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // txtOthers
            // 
            this.txtOthers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOthers.Location = new System.Drawing.Point(1002, 37);
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(174, 20);
            this.txtOthers.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(942, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "Others";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(631, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Fuel";
            // 
            // txtOilDrawn
            // 
            this.txtOilDrawn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOilDrawn.Location = new System.Drawing.Point(375, 37);
            this.txtOilDrawn.Name = "txtOilDrawn";
            this.txtOilDrawn.Size = new System.Drawing.Size(176, 20);
            this.txtOilDrawn.TabIndex = 8;
            // 
            // txtFuelDrawn
            // 
            this.txtFuelDrawn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFuelDrawn.Location = new System.Drawing.Point(674, 37);
            this.txtFuelDrawn.Name = "txtFuelDrawn";
            this.txtFuelDrawn.Size = new System.Drawing.Size(174, 20);
            this.txtFuelDrawn.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(341, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Oil";
            // 
            // txtMaintenance
            // 
            this.txtMaintenance.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaintenance.Location = new System.Drawing.Point(106, 37);
            this.txtMaintenance.Name = "txtMaintenance";
            this.txtMaintenance.Size = new System.Drawing.Size(165, 20);
            this.txtMaintenance.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Maintenance";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.8F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePicker2, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(439, 263);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(597, 30);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(633, 132);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(208, 2);
            this.tableLayoutPanel4.TabIndex = 23;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Location = new System.Drawing.Point(1125, 132);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(174, 22);
            this.dateTimePicker3.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1077, 137);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Date";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Location = new System.Drawing.Point(1155, 692);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Location = new System.Drawing.Point(0, 727);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1474, 15);
            this.button4.TabIndex = 54;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineItem;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.Location = new System.Drawing.Point(0, 742);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1474, 15);
            this.button6.TabIndex = 55;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // cmbStation
            // 
            this.cmbStation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Items.AddRange(new object[] {
            "Kipsigis",
            "Jumbo",
            "Omline"});
            this.cmbStation.Location = new System.Drawing.Point(106, 5);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(165, 21);
            this.cmbStation.TabIndex = 56;
            // 
            // cmbVehicleNo
            // 
            this.cmbVehicleNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbVehicleNo.DataSource = this.vehicleRegistrationBindingSource;
            this.cmbVehicleNo.DisplayMember = "RegNo";
            this.cmbVehicleNo.FormattingEnabled = true;
            this.cmbVehicleNo.Location = new System.Drawing.Point(375, 5);
            this.cmbVehicleNo.Name = "cmbVehicleNo";
            this.cmbVehicleNo.Size = new System.Drawing.Size(176, 21);
            this.cmbVehicleNo.TabIndex = 57;
            this.cmbVehicleNo.ValueMember = "RegNo";
            // 
            // cmbloginDataSet45
            // 
            this.cmbloginDataSet45.DataSetName = "cmbloginDataSet45";
            this.cmbloginDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleRegistrationBindingSource
            // 
            this.vehicleRegistrationBindingSource.DataMember = "VehicleRegistration";
            this.vehicleRegistrationBindingSource.DataSource = this.cmbloginDataSet45;
            // 
            // vehicleRegistrationTableAdapter
            // 
            this.vehicleRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1343, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 48);
            this.button5.TabIndex = 56;
            this.button5.Text = "Compute Balance";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1474, 757);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAccounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegistrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLpoNo;
        private System.Windows.Forms.TextBox txtPayments;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaintenance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOilDrawn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.TextBox txtFuelDrawn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expenditure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.ComboBox cmbVehicleNo;
        private cmbloginDataSet45 cmbloginDataSet45;
        private System.Windows.Forms.BindingSource vehicleRegistrationBindingSource;
        private cmbloginDataSet45TableAdapters.VehicleRegistrationTableAdapter vehicleRegistrationTableAdapter;
        private System.Windows.Forms.Button button5;
    }
}