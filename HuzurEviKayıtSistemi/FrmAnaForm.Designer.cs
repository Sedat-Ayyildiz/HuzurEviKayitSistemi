namespace HuzurEviKayıtSistemi
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yaşlılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaşlıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaşlıListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaşlıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimKolaylığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yasliidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.huzureviOtomasyonuDataSet1 = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet1();
            this.yasliTableAdapter = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet1TableAdapters.YasliTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.notEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaşlıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzureviOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaşlılarToolStripMenuItem,
            this.bölToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.giderlerToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.erişimKolaylığıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yaşlılarToolStripMenuItem
            // 
            this.yaşlılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaşlıEkleToolStripMenuItem,
            this.yaşlıListesiToolStripMenuItem,
            this.yaşlıDüzenleToolStripMenuItem});
            this.yaşlılarToolStripMenuItem.Name = "yaşlılarToolStripMenuItem";
            this.yaşlılarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yaşlılarToolStripMenuItem.Text = "Yaşlılar";
            // 
            // yaşlıEkleToolStripMenuItem
            // 
            this.yaşlıEkleToolStripMenuItem.Name = "yaşlıEkleToolStripMenuItem";
            this.yaşlıEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.yaşlıEkleToolStripMenuItem.Text = "Yaşlı Ekle";
            this.yaşlıEkleToolStripMenuItem.Click += new System.EventHandler(this.yaşlıEkleToolStripMenuItem_Click);
            // 
            // yaşlıListesiToolStripMenuItem
            // 
            this.yaşlıListesiToolStripMenuItem.Name = "yaşlıListesiToolStripMenuItem";
            this.yaşlıListesiToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.yaşlıListesiToolStripMenuItem.Text = "Yaşlı Listesi";
            this.yaşlıListesiToolStripMenuItem.Click += new System.EventHandler(this.yaşlıListesiToolStripMenuItem_Click);
            // 
            // yaşlıDüzenleToolStripMenuItem
            // 
            this.yaşlıDüzenleToolStripMenuItem.Name = "yaşlıDüzenleToolStripMenuItem";
            this.yaşlıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yaşlıDüzenleToolStripMenuItem.Text = "Yaşlı Sil";
            this.yaşlıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.yaşlıDüzenleToolStripMenuItem_Click);
            // 
            // bölToolStripMenuItem
            // 
            this.bölToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümDüzenleToolStripMenuItem});
            this.bölToolStripMenuItem.Name = "bölToolStripMenuItem";
            this.bölToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bölToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            this.bölümEkleToolStripMenuItem.Click += new System.EventHandler(this.bölümEkleToolStripMenuItem_Click);
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            this.bölümDüzenleToolStripMenuItem.Click += new System.EventHandler(this.bölümDüzenleToolStripMenuItem_Click);
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeAlToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            this.ödemeAlToolStripMenuItem.Click += new System.EventHandler(this.ödemeAlToolStripMenuItem_Click);
            // 
            // giderlerToolStripMenuItem
            // 
            this.giderlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderListesiToolStripMenuItem});
            this.giderlerToolStripMenuItem.Name = "giderlerToolStripMenuItem";
            this.giderlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.giderlerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            this.giderEkleToolStripMenuItem.Click += new System.EventHandler(this.giderEkleToolStripMenuItem_Click);
            // 
            // giderListesiToolStripMenuItem
            // 
            this.giderListesiToolStripMenuItem.Name = "giderListesiToolStripMenuItem";
            this.giderListesiToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.giderListesiToolStripMenuItem.Text = "Gider Listesi";
            this.giderListesiToolStripMenuItem.Click += new System.EventHandler(this.giderListesiToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistikleriToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // gelirİstatistikleriToolStripMenuItem
            // 
            this.gelirİstatistikleriToolStripMenuItem.Name = "gelirİstatistikleriToolStripMenuItem";
            this.gelirİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.gelirİstatistikleriToolStripMenuItem.Text = "Gelir İstatistikleri";
            this.gelirİstatistikleriToolStripMenuItem.Click += new System.EventHandler(this.gelirİstatistikleriToolStripMenuItem_Click);
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.personelDüzenleToolStripMenuItem,
            this.notEkleToolStripMenuItem,
            this.raporAlToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            this.şifreİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.şifreİşlemleriToolStripMenuItem_Click);
            // 
            // personelDüzenleToolStripMenuItem
            // 
            this.personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            this.personelDüzenleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.personelDüzenleToolStripMenuItem.Text = "Personel Düzenle";
            this.personelDüzenleToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenleToolStripMenuItem_Click);
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            this.erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.notlarToolStripMenuItem,
            this.radioToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            this.erişimKolaylığıToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // notlarToolStripMenuItem
            // 
            this.notlarToolStripMenuItem.Name = "notlarToolStripMenuItem";
            this.notlarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.notlarToolStripMenuItem.Text = "Word";
            this.notlarToolStripMenuItem.Click += new System.EventHandler(this.notlarToolStripMenuItem_Click);
            // 
            // radioToolStripMenuItem
            // 
            this.radioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radyo2ToolStripMenuItem});
            this.radioToolStripMenuItem.Name = "radioToolStripMenuItem";
            this.radioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.radioToolStripMenuItem.Text = "Radyo Kanalı";
            // 
            // radyo2ToolStripMenuItem
            // 
            this.radyo2ToolStripMenuItem.Name = "radyo2ToolStripMenuItem";
            this.radyo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.radyo2ToolStripMenuItem.Text = "Taksim Fm";
            this.radyo2ToolStripMenuItem.Click += new System.EventHandler(this.radyo2ToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yasliidDataGridViewTextBoxColumn,
            this.yasliAdDataGridViewTextBoxColumn,
            this.yasliSoyadDataGridViewTextBoxColumn,
            this.yasliOdaNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yasliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(556, 210);
            this.dataGridView1.TabIndex = 2;
            // 
            // yasliidDataGridViewTextBoxColumn
            // 
            this.yasliidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliidDataGridViewTextBoxColumn.DataPropertyName = "Yasliid";
            this.yasliidDataGridViewTextBoxColumn.FillWeight = 40F;
            this.yasliidDataGridViewTextBoxColumn.HeaderText = "Yasliid";
            this.yasliidDataGridViewTextBoxColumn.Name = "yasliidDataGridViewTextBoxColumn";
            this.yasliidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yasliAdDataGridViewTextBoxColumn
            // 
            this.yasliAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliAdDataGridViewTextBoxColumn.DataPropertyName = "YasliAd";
            this.yasliAdDataGridViewTextBoxColumn.FillWeight = 70F;
            this.yasliAdDataGridViewTextBoxColumn.HeaderText = "YasliAd";
            this.yasliAdDataGridViewTextBoxColumn.Name = "yasliAdDataGridViewTextBoxColumn";
            // 
            // yasliSoyadDataGridViewTextBoxColumn
            // 
            this.yasliSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliSoyadDataGridViewTextBoxColumn.DataPropertyName = "YasliSoyad";
            this.yasliSoyadDataGridViewTextBoxColumn.FillWeight = 70F;
            this.yasliSoyadDataGridViewTextBoxColumn.HeaderText = "YasliSoyad";
            this.yasliSoyadDataGridViewTextBoxColumn.Name = "yasliSoyadDataGridViewTextBoxColumn";
            // 
            // yasliOdaNoDataGridViewTextBoxColumn
            // 
            this.yasliOdaNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliOdaNoDataGridViewTextBoxColumn.DataPropertyName = "YasliOdaNo";
            this.yasliOdaNoDataGridViewTextBoxColumn.FillWeight = 35F;
            this.yasliOdaNoDataGridViewTextBoxColumn.HeaderText = "YasliOdaNo";
            this.yasliOdaNoDataGridViewTextBoxColumn.Name = "yasliOdaNoDataGridViewTextBoxColumn";
            // 
            // yasliBindingSource
            // 
            this.yasliBindingSource.DataMember = "Yasli";
            this.yasliBindingSource.DataSource = this.huzureviOtomasyonuDataSet1;
            // 
            // huzureviOtomasyonuDataSet1
            // 
            this.huzureviOtomasyonuDataSet1.DataSetName = "HuzureviOtomasyonuDataSet1";
            this.huzureviOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yasliTableAdapter
            // 
            this.yasliTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(575, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(633, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(562, 229);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(214, 64);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // notEkleToolStripMenuItem
            // 
            this.notEkleToolStripMenuItem.Name = "notEkleToolStripMenuItem";
            this.notEkleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.notEkleToolStripMenuItem.Text = "Not Ekle";
            this.notEkleToolStripMenuItem.Click += new System.EventHandler(this.notEkleToolStripMenuItem_Click);
            // 
            // raporAlToolStripMenuItem
            // 
            this.raporAlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yaşlıBilgileriToolStripMenuItem,
            this.gelirRaporlarıToolStripMenuItem});
            this.raporAlToolStripMenuItem.Name = "raporAlToolStripMenuItem";
            this.raporAlToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.raporAlToolStripMenuItem.Text = "Rapor Al";
            // 
            // yaşlıBilgileriToolStripMenuItem
            // 
            this.yaşlıBilgileriToolStripMenuItem.Name = "yaşlıBilgileriToolStripMenuItem";
            this.yaşlıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yaşlıBilgileriToolStripMenuItem.Text = "Yaşlı Bilgileri";
            this.yaşlıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.yaşlıBilgileriToolStripMenuItem_Click);
            // 
            // gelirRaporlarıToolStripMenuItem
            // 
            this.gelirRaporlarıToolStripMenuItem.Name = "gelirRaporlarıToolStripMenuItem";
            this.gelirRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gelirRaporlarıToolStripMenuItem.Text = "Gelir Raporları";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 293);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yasliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzureviOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yaşlılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaşlıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaşlıListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaşlıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HuzureviOtomasyonuDataSet1 huzureviOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource yasliBindingSource;
        private HuzureviOtomasyonuDataSet1TableAdapters.YasliTableAdapter yasliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ToolStripMenuItem notEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaşlıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirRaporlarıToolStripMenuItem;
    }
}