namespace KERICHO_CHMT
{
    partial class ViewReports
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
            this.report = new KERICHO_CHMT.Report();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.referralRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reasonForReferralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.DataSetName = "Report";
            this.report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reasonForReferralDataGridViewTextBoxColumn,
            this.facilityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.referralRegisterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(282, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // referralRegisterBindingSource
            // 
            this.referralRegisterBindingSource.DataMember = "ReferralRegister";
            this.referralRegisterBindingSource.DataSource = this.report;
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
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ViewReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ViewReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referralRegisterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Report report;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonForReferralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource referralRegisterBindingSource;
    }
}