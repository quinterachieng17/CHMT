namespace KERICHO_CHMT
{
    partial class LPGStations
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lblStation = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbloginDataSet26 = new KERICHO_CHMT.cmbloginDataSet26();
            this.SearchAmbulanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchAmbulanceTableAdapter = new KERICHO_CHMT.cmbloginDataSet26TableAdapters.SearchAmbulanceTableAdapter();
            this.cmbloginDataSet16 = new KERICHO_CHMT.cmbloginDataSet16();
            this.AddByNursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddByNursesTableAdapter = new KERICHO_CHMT.cmbloginDataSet16TableAdapters.AddByNursesTableAdapter();
            this.cmbloginDataSet19 = new KERICHO_CHMT.cmbloginDataSet19();
            this.AddByFacilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddByFacilityTableAdapter = new KERICHO_CHMT.cmbloginDataSet19TableAdapters.AddByFacilityTableAdapter();
            this.reportViewerJumbo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbloginDataSet33 = new KERICHO_CHMT.cmbloginDataSet33();
            this.AddByRegNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddByRegNoTableAdapter = new KERICHO_CHMT.cmbloginDataSet33TableAdapters.AddByRegNoTableAdapter();
            this.reportViewerKipsigis = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerHomeline = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbloginDataSet34 = new KERICHO_CHMT.cmbloginDataSet34();
            this.AddByRegNoKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddByRegNoKTableAdapter = new KERICHO_CHMT.cmbloginDataSet34TableAdapters.AddByRegNoKTableAdapter();
            this.AddByRegNoHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddByRegNoHTableAdapter = new KERICHO_CHMT.cmbloginDataSet34TableAdapters.AddByRegNoHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAmbulanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByNursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByFacilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByRegNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByRegNoKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByRegNoHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStation
            // 
            this.lblStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(501, 29);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(99, 18);
            this.lblStation.TabIndex = 0;
            this.lblStation.Text = "LPG Station";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(1197, 493);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1096, 493);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(1000, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(1197, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbloginDataSet26
            // 
            this.cmbloginDataSet26.DataSetName = "cmbloginDataSet26";
            this.cmbloginDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchAmbulanceBindingSource
            // 
            this.SearchAmbulanceBindingSource.DataMember = "SearchAmbulance";
            this.SearchAmbulanceBindingSource.DataSource = this.cmbloginDataSet26;
            // 
            // SearchAmbulanceTableAdapter
            // 
            this.SearchAmbulanceTableAdapter.ClearBeforeFill = true;
            // 
            // cmbloginDataSet16
            // 
            this.cmbloginDataSet16.DataSetName = "cmbloginDataSet16";
            this.cmbloginDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddByNursesBindingSource
            // 
            this.AddByNursesBindingSource.DataMember = "AddByNurses";
            this.AddByNursesBindingSource.DataSource = this.cmbloginDataSet16;
            // 
            // AddByNursesTableAdapter
            // 
            this.AddByNursesTableAdapter.ClearBeforeFill = true;
            // 
            // cmbloginDataSet19
            // 
            this.cmbloginDataSet19.DataSetName = "cmbloginDataSet19";
            this.cmbloginDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddByFacilityBindingSource
            // 
            this.AddByFacilityBindingSource.DataMember = "AddByFacility";
            this.AddByFacilityBindingSource.DataSource = this.cmbloginDataSet19;
            // 
            // AddByFacilityTableAdapter
            // 
            this.AddByFacilityTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerJumbo
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AddByRegNoBindingSource;
            this.reportViewerJumbo.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerJumbo.LocalReport.ReportEmbeddedResource = "KERICHO_CHMT.ReportByRegNo.rdlc";
            this.reportViewerJumbo.Location = new System.Drawing.Point(320, 97);
            this.reportViewerJumbo.Name = "reportViewerJumbo";
            this.reportViewerJumbo.Size = new System.Drawing.Size(952, 324);
            this.reportViewerJumbo.TabIndex = 6;
            // 
            // cmbloginDataSet33
            // 
            this.cmbloginDataSet33.DataSetName = "cmbloginDataSet33";
            this.cmbloginDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddByRegNoBindingSource
            // 
            this.AddByRegNoBindingSource.DataMember = "AddByRegNo";
            this.AddByRegNoBindingSource.DataSource = this.cmbloginDataSet33;
            // 
            // AddByRegNoTableAdapter
            // 
            this.AddByRegNoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerKipsigis
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AddByRegNoKBindingSource;
            this.reportViewerKipsigis.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerKipsigis.LocalReport.ReportEmbeddedResource = "KERICHO_CHMT.ReportByRegNoK.rdlc";
            this.reportViewerKipsigis.Location = new System.Drawing.Point(320, 97);
            this.reportViewerKipsigis.Name = "reportViewerKipsigis";
            this.reportViewerKipsigis.Size = new System.Drawing.Size(952, 324);
            this.reportViewerKipsigis.TabIndex = 7;
            this.reportViewerKipsigis.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // reportViewerHomeline
            // 
            this.reportViewerHomeline.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.AddByRegNoHBindingSource;
            this.reportViewerHomeline.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerHomeline.LocalReport.ReportEmbeddedResource = "KERICHO_CHMT.ReportByRegNoH.rdlc";
            this.reportViewerHomeline.Location = new System.Drawing.Point(109, 97);
            this.reportViewerHomeline.Name = "reportViewerHomeline";
            this.reportViewerHomeline.Size = new System.Drawing.Size(1163, 324);
            this.reportViewerHomeline.TabIndex = 8;
            // 
            // cmbloginDataSet34
            // 
            this.cmbloginDataSet34.DataSetName = "cmbloginDataSet34";
            this.cmbloginDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddByRegNoKBindingSource
            // 
            this.AddByRegNoKBindingSource.DataMember = "AddByRegNoK";
            this.AddByRegNoKBindingSource.DataSource = this.cmbloginDataSet34;
            // 
            // AddByRegNoKTableAdapter
            // 
            this.AddByRegNoKTableAdapter.ClearBeforeFill = true;
            // 
            // AddByRegNoHBindingSource
            // 
            this.AddByRegNoHBindingSource.DataMember = "AddByRegNoH";
            this.AddByRegNoHBindingSource.DataSource = this.cmbloginDataSet34;
            // 
            // AddByRegNoHTableAdapter
            // 
            this.AddByRegNoHTableAdapter.ClearBeforeFill = true;
            // 
            // LPGStations
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1301, 553);
            this.Controls.Add(this.reportViewerHomeline);
            this.Controls.Add(this.reportViewerKipsigis);
            this.Controls.Add(this.reportViewerJumbo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblStation);
            this.Name = "LPGStations";
            this.Text = "LPGStations";
            this.Load += new System.EventHandler(this.LPGStations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchAmbulanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByNursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByFacilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByRegNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByRegNoKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddByRegNoHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource SearchAmbulanceBindingSource;
        private cmbloginDataSet26 cmbloginDataSet26;
        private cmbloginDataSet26TableAdapters.SearchAmbulanceTableAdapter SearchAmbulanceTableAdapter;
        private System.Windows.Forms.BindingSource AddByNursesBindingSource;
        private cmbloginDataSet16 cmbloginDataSet16;
        private cmbloginDataSet16TableAdapters.AddByNursesTableAdapter AddByNursesTableAdapter;
        private System.Windows.Forms.BindingSource AddByFacilityBindingSource;
        private cmbloginDataSet19 cmbloginDataSet19;
        private cmbloginDataSet19TableAdapters.AddByFacilityTableAdapter AddByFacilityTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerJumbo;
        private System.Windows.Forms.BindingSource AddByRegNoBindingSource;
        private cmbloginDataSet33 cmbloginDataSet33;
        private cmbloginDataSet33TableAdapters.AddByRegNoTableAdapter AddByRegNoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerKipsigis;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHomeline;
        private System.Windows.Forms.BindingSource AddByRegNoKBindingSource;
        private cmbloginDataSet34 cmbloginDataSet34;
        private cmbloginDataSet34TableAdapters.AddByRegNoKTableAdapter AddByRegNoKTableAdapter;
        private System.Windows.Forms.BindingSource AddByRegNoHBindingSource;
        private cmbloginDataSet34TableAdapters.AddByRegNoHTableAdapter AddByRegNoHTableAdapter;
    }
}