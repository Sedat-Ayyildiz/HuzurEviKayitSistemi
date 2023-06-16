namespace HuzurEviKayıtSistemi
{
    partial class FrmYasliListe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.huzureviOtomasyonuDataSet3 = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet3();
            this.yasliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yasliTableAdapter = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet3TableAdapters.YasliTableAdapter();
            this.yasliidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliBolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliSgkNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliVeliAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliVeliTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliVeliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzureviOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasliBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yasliidDataGridViewTextBoxColumn,
            this.yasliAdDataGridViewTextBoxColumn,
            this.yasliSoyadDataGridViewTextBoxColumn,
            this.yasliTCDataGridViewTextBoxColumn,
            this.yasliTelefonDataGridViewTextBoxColumn,
            this.yasliDogumDataGridViewTextBoxColumn,
            this.yasliBolumDataGridViewTextBoxColumn,
            this.yasliSgkNoDataGridViewTextBoxColumn,
            this.yasliOdaNoDataGridViewTextBoxColumn,
            this.yasliVeliAdSoyadDataGridViewTextBoxColumn,
            this.yasliVeliTelefonDataGridViewTextBoxColumn,
            this.yasliVeliAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yasliBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1070, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // huzureviOtomasyonuDataSet3
            // 
            this.huzureviOtomasyonuDataSet3.DataSetName = "HuzureviOtomasyonuDataSet3";
            this.huzureviOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yasliBindingSource
            // 
            this.yasliBindingSource.DataMember = "Yasli";
            this.yasliBindingSource.DataSource = this.huzureviOtomasyonuDataSet3;
            // 
            // yasliTableAdapter
            // 
            this.yasliTableAdapter.ClearBeforeFill = true;
            // 
            // yasliidDataGridViewTextBoxColumn
            // 
            this.yasliidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliidDataGridViewTextBoxColumn.DataPropertyName = "Yasliid";
            this.yasliidDataGridViewTextBoxColumn.FillWeight = 25F;
            this.yasliidDataGridViewTextBoxColumn.HeaderText = "Yasliid";
            this.yasliidDataGridViewTextBoxColumn.Name = "yasliidDataGridViewTextBoxColumn";
            this.yasliidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yasliAdDataGridViewTextBoxColumn
            // 
            this.yasliAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliAdDataGridViewTextBoxColumn.DataPropertyName = "YasliAd";
            this.yasliAdDataGridViewTextBoxColumn.FillWeight = 40F;
            this.yasliAdDataGridViewTextBoxColumn.HeaderText = "YasliAd";
            this.yasliAdDataGridViewTextBoxColumn.Name = "yasliAdDataGridViewTextBoxColumn";
            // 
            // yasliSoyadDataGridViewTextBoxColumn
            // 
            this.yasliSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliSoyadDataGridViewTextBoxColumn.DataPropertyName = "YasliSoyad";
            this.yasliSoyadDataGridViewTextBoxColumn.FillWeight = 40F;
            this.yasliSoyadDataGridViewTextBoxColumn.HeaderText = "YasliSoyad";
            this.yasliSoyadDataGridViewTextBoxColumn.Name = "yasliSoyadDataGridViewTextBoxColumn";
            // 
            // yasliTCDataGridViewTextBoxColumn
            // 
            this.yasliTCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliTCDataGridViewTextBoxColumn.DataPropertyName = "YasliTC";
            this.yasliTCDataGridViewTextBoxColumn.FillWeight = 45F;
            this.yasliTCDataGridViewTextBoxColumn.HeaderText = "YasliTC";
            this.yasliTCDataGridViewTextBoxColumn.Name = "yasliTCDataGridViewTextBoxColumn";
            // 
            // yasliTelefonDataGridViewTextBoxColumn
            // 
            this.yasliTelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliTelefonDataGridViewTextBoxColumn.DataPropertyName = "YasliTelefon";
            this.yasliTelefonDataGridViewTextBoxColumn.FillWeight = 45F;
            this.yasliTelefonDataGridViewTextBoxColumn.HeaderText = "YasliTelefon";
            this.yasliTelefonDataGridViewTextBoxColumn.Name = "yasliTelefonDataGridViewTextBoxColumn";
            // 
            // yasliDogumDataGridViewTextBoxColumn
            // 
            this.yasliDogumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliDogumDataGridViewTextBoxColumn.DataPropertyName = "YasliDogum";
            this.yasliDogumDataGridViewTextBoxColumn.FillWeight = 30F;
            this.yasliDogumDataGridViewTextBoxColumn.HeaderText = "YasliDogum";
            this.yasliDogumDataGridViewTextBoxColumn.Name = "yasliDogumDataGridViewTextBoxColumn";
            // 
            // yasliBolumDataGridViewTextBoxColumn
            // 
            this.yasliBolumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliBolumDataGridViewTextBoxColumn.DataPropertyName = "YasliBolum";
            this.yasliBolumDataGridViewTextBoxColumn.FillWeight = 45F;
            this.yasliBolumDataGridViewTextBoxColumn.HeaderText = "YasliBolum";
            this.yasliBolumDataGridViewTextBoxColumn.Name = "yasliBolumDataGridViewTextBoxColumn";
            // 
            // yasliSgkNoDataGridViewTextBoxColumn
            // 
            this.yasliSgkNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliSgkNoDataGridViewTextBoxColumn.DataPropertyName = "YasliSgkNo";
            this.yasliSgkNoDataGridViewTextBoxColumn.FillWeight = 50F;
            this.yasliSgkNoDataGridViewTextBoxColumn.HeaderText = "YasliSgkNo";
            this.yasliSgkNoDataGridViewTextBoxColumn.Name = "yasliSgkNoDataGridViewTextBoxColumn";
            // 
            // yasliOdaNoDataGridViewTextBoxColumn
            // 
            this.yasliOdaNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliOdaNoDataGridViewTextBoxColumn.DataPropertyName = "YasliOdaNo";
            this.yasliOdaNoDataGridViewTextBoxColumn.FillWeight = 20F;
            this.yasliOdaNoDataGridViewTextBoxColumn.HeaderText = "YasliOdaNo";
            this.yasliOdaNoDataGridViewTextBoxColumn.Name = "yasliOdaNoDataGridViewTextBoxColumn";
            // 
            // yasliVeliAdSoyadDataGridViewTextBoxColumn
            // 
            this.yasliVeliAdSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliVeliAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "YasliVeliAdSoyad";
            this.yasliVeliAdSoyadDataGridViewTextBoxColumn.FillWeight = 50F;
            this.yasliVeliAdSoyadDataGridViewTextBoxColumn.HeaderText = "YasliVeliAdSoyad";
            this.yasliVeliAdSoyadDataGridViewTextBoxColumn.Name = "yasliVeliAdSoyadDataGridViewTextBoxColumn";
            // 
            // yasliVeliTelefonDataGridViewTextBoxColumn
            // 
            this.yasliVeliTelefonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliVeliTelefonDataGridViewTextBoxColumn.DataPropertyName = "YasliVeliTelefon";
            this.yasliVeliTelefonDataGridViewTextBoxColumn.FillWeight = 50F;
            this.yasliVeliTelefonDataGridViewTextBoxColumn.HeaderText = "YasliVeliTelefon";
            this.yasliVeliTelefonDataGridViewTextBoxColumn.Name = "yasliVeliTelefonDataGridViewTextBoxColumn";
            // 
            // yasliVeliAdresDataGridViewTextBoxColumn
            // 
            this.yasliVeliAdresDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliVeliAdresDataGridViewTextBoxColumn.DataPropertyName = "YasliVeliAdres";
            this.yasliVeliAdresDataGridViewTextBoxColumn.HeaderText = "YasliVeliAdres";
            this.yasliVeliAdresDataGridViewTextBoxColumn.Name = "yasliVeliAdresDataGridViewTextBoxColumn";
            // 
            // FrmYasliListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 281);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmYasliListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yaşlıların Listesi";
            this.Load += new System.EventHandler(this.FrmYasliListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzureviOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasliBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HuzureviOtomasyonuDataSet3 huzureviOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource yasliBindingSource;
        private HuzureviOtomasyonuDataSet3TableAdapters.YasliTableAdapter yasliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliBolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliSgkNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliVeliAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliVeliTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliVeliAdresDataGridViewTextBoxColumn;
    }
}