namespace KERICHO_CHMT
{
    partial class Facility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facility));
            this.dgvFacilityTo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFacilityFrom = new System.Windows.Forms.DataGridView();
            this.patientRegisterApprovedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterApprovedBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFacilityTo
            // 
            this.dgvFacilityTo.AllowUserToAddRows = false;
            this.dgvFacilityTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacilityTo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacilityTo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacilityTo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacilityTo.Location = new System.Drawing.Point(889, 107);
            this.dgvFacilityTo.Name = "dgvFacilityTo";
            this.dgvFacilityTo.Size = new System.Drawing.Size(525, 455);
            this.dgvFacilityTo.TabIndex = 0;
            this.dgvFacilityTo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facility List for Facilities Referring to KCRH";
            // 
            // dgvFacilityFrom
            // 
            this.dgvFacilityFrom.AllowUserToAddRows = false;
            this.dgvFacilityFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvFacilityFrom.AutoGenerateColumns = false;
            this.dgvFacilityFrom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacilityFrom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacilityFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacilityFrom.DataSource = this.patientRegisterApprovedBindingSource1;
            this.dgvFacilityFrom.Location = new System.Drawing.Point(67, 107);
            this.dgvFacilityFrom.Name = "dgvFacilityFrom";
            this.dgvFacilityFrom.Size = new System.Drawing.Size(552, 455);
            this.dgvFacilityFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1054, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Facility List for all Facilities KCRH referred to";
            // 
            // Facility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 608);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFacilityFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFacilityTo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facility";
            this.Text = "Facility";
            this.Load += new System.EventHandler(this.Facility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacilityFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientRegisterApprovedBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacilityTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFacilityFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource patientRegisterApprovedBindingSource1;
    }
}