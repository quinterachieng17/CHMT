namespace KERICHO_CHMT
{
    partial class UpdateStaffDetails
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDesignation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cbxRegion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtUserID,
            this.txtFirstName,
            this.txtLastName,
            this.txtIDNumber,
            this.txtPassword,
            this.txtUsername,
            this.cbxDesignation,
            this.cbxRegion});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(995, 374);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvEmployee.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellValueChanged);
            this.dgvEmployee.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEmployee_DataError);
            this.dgvEmployee.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvEmployee_EditingControlShowing);
            this.dgvEmployee.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmployee_UserDeletingRow);
            // 
            // txtUserID
            // 
            this.txtUserID.DataPropertyName = "UserID";
            this.txtUserID.HeaderText = "UserID";
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FirstName";
            this.txtFirstName.HeaderText = "First Name";
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Width = 150;
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LastName";
            this.txtLastName.HeaderText = "Last Name";
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Width = 150;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.DataPropertyName = "IDNumber";
            this.txtIDNumber.HeaderText = "ID Number";
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Width = 120;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPassword.DataPropertyName = "Password";
            this.txtPassword.HeaderText = "Password";
            this.txtPassword.Name = "txtPassword";
            // 
            // txtUsername
            // 
            this.txtUsername.DataPropertyName = "Username";
            this.txtUsername.HeaderText = "Username";
            this.txtUsername.Name = "txtUsername";
            // 
            // cbxDesignation
            // 
            this.cbxDesignation.DataPropertyName = "DesignationID";
            this.cbxDesignation.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbxDesignation.HeaderText = "DesignationID";
            this.cbxDesignation.Name = "cbxDesignation";
            this.cbxDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbxDesignation.Width = 130;
            // 
            // cbxRegion
            // 
            this.cbxRegion.DataPropertyName = "RegionID";
            this.cbxRegion.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbxRegion.HeaderText = "RegionID";
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbxRegion.Width = 150;
            // 
            // UpdateStaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 426);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "UpdateStaffDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Staff Details";
            this.Load += new System.EventHandler(this.UpdateStaffDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtUsername;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxDesignation;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxRegion;
    }
}