namespace HuzurEviKayıtSistemi
{
    partial class FrmYasliRapor
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
            this.YasliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HuzureviOtomasyonuDataSet8 = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.YasliTableAdapter = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet8TableAdapters.YasliTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.YasliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HuzureviOtomasyonuDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // YasliBindingSource
            // 
            this.YasliBindingSource.DataMember = "Yasli";
            this.YasliBindingSource.DataSource = this.HuzureviOtomasyonuDataSet8;
            // 
            // HuzureviOtomasyonuDataSet8
            // 
            this.HuzureviOtomasyonuDataSet8.DataSetName = "HuzureviOtomasyonuDataSet8";
            this.HuzureviOtomasyonuDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.YasliBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HuzurEviKayıtSistemi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1155, 371);
            this.reportViewer1.TabIndex = 0;
            // 
            // YasliTableAdapter
            // 
            this.YasliTableAdapter.ClearBeforeFill = true;
            // 
            // FrmYasliRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 373);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmYasliRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yaşlı Raporları";
            this.Load += new System.EventHandler(this.FrmYasliRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.YasliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HuzureviOtomasyonuDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource YasliBindingSource;
        private HuzureviOtomasyonuDataSet8 HuzureviOtomasyonuDataSet8;
        private HuzureviOtomasyonuDataSet8TableAdapters.YasliTableAdapter YasliTableAdapter;
    }
}