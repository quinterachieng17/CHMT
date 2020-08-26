namespace KERICHO_CHMT
{
    partial class UpdateVehicleDetails
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
            this.dgvVehicleUpdate = new System.Windows.Forms.DataGridView();
            this.txtVehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtChasisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEngineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPlateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleUpdate)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVehicleUpdate
            // 
            this.dgvVehicleUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicleUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicleUpdate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVehicleUpdate.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvVehicleUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtVehicleID,
            this.txtRegNo,
            this.txtMake,
            this.txtModel,
            this.txtChasisNo,
            this.txtEngineNo,
            this.txtPlateNo,
            this.txtDate});
            this.dgvVehicleUpdate.Location = new System.Drawing.Point(67, 120);
            this.dgvVehicleUpdate.Name = "dgvVehicleUpdate";
            this.dgvVehicleUpdate.Size = new System.Drawing.Size(1168, 382);
            this.dgvVehicleUpdate.TabIndex = 0;
            this.dgvVehicleUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleUpdate_CellContentClick);
            this.dgvVehicleUpdate.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleUpdate_CellValueChanged);
            this.dgvVehicleUpdate.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvVehicleUpdate_EditingControlShowing);
            this.dgvVehicleUpdate.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvVehicleUpdate_UserDeletingRow);
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.DataPropertyName = "VehicleID";
            this.txtVehicleID.HeaderText = "Vehicle ID";
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Visible = false;
            // 
            // txtRegNo
            // 
            this.txtRegNo.DataPropertyName = "RegNo";
            this.txtRegNo.HeaderText = "Registration Number";
            this.txtRegNo.Name = "txtRegNo";
            // 
            // txtMake
            // 
            this.txtMake.DataPropertyName = "Make";
            this.txtMake.HeaderText = "Make";
            this.txtMake.Name = "txtMake";
            // 
            // txtModel
            // 
            this.txtModel.DataPropertyName = "Model";
            this.txtModel.HeaderText = "Model";
            this.txtModel.Name = "txtModel";
            // 
            // txtChasisNo
            // 
            this.txtChasisNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtChasisNo.DataPropertyName = "ChasisNo";
            this.txtChasisNo.HeaderText = "Chasis Number";
            this.txtChasisNo.Name = "txtChasisNo";
            // 
            // txtEngineNo
            // 
            this.txtEngineNo.DataPropertyName = "EngineNo";
            this.txtEngineNo.HeaderText = "Engine Number";
            this.txtEngineNo.Name = "txtEngineNo";
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.DataPropertyName = "PlateNo";
            this.txtPlateNo.HeaderText = "Plate Number";
            this.txtPlateNo.Name = "txtPlateNo";
            // 
            // txtDate
            // 
            this.txtDate.DataPropertyName = "Date";
            this.txtDate.HeaderText = "Date Registered";
            this.txtDate.Name = "txtDate";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Location = new System.Drawing.Point(1160, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "KERICHO COUNTY REFERRAL HOSPITAL";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Update Motor Vehicle Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(277, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 84);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(477, 89);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 2);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // UpdateVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1303, 552);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVehicleUpdate);
            this.Name = "UpdateVehicleDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Vehicle Details";
            this.Load += new System.EventHandler(this.UpdateVehicleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleUpdate)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicleUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtChasisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEngineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPlateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}