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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicleUpdate
            // 
            this.dgvVehicleUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleUpdate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtVehicleID,
            this.txtRegNo,
            this.txtMake,
            this.txtModel,
            this.txtChasisNo,
            this.txtEngineNo,
            this.txtPlateNo});
            this.dgvVehicleUpdate.Location = new System.Drawing.Point(12, 12);
            this.dgvVehicleUpdate.Name = "dgvVehicleUpdate";
            this.dgvVehicleUpdate.Size = new System.Drawing.Size(1279, 487);
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
            this.txtRegNo.Width = 200;
            // 
            // txtMake
            // 
            this.txtMake.DataPropertyName = "Make";
            this.txtMake.HeaderText = "Make";
            this.txtMake.Name = "txtMake";
            this.txtMake.Width = 200;
            // 
            // txtModel
            // 
            this.txtModel.DataPropertyName = "Model";
            this.txtModel.HeaderText = "Model";
            this.txtModel.Name = "txtModel";
            this.txtModel.Width = 200;
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
            this.txtEngineNo.Width = 200;
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.DataPropertyName = "PlateNo";
            this.txtPlateNo.HeaderText = "Plate Number";
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.Width = 200;
            // 
            // UpdateVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 552);
            this.Controls.Add(this.dgvVehicleUpdate);
            this.Name = "UpdateVehicleDetails";
            this.Text = "Update Vehicle Details";
            this.Load += new System.EventHandler(this.UpdateVehicleDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicleUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtVehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtChasisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEngineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPlateNo;
    }
}