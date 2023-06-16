namespace HuzurEviKayıtSistemi
{
    partial class FrmOdemeler
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
            this.TxtYasliid = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtOdenen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yasliidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yasliKalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.huzureviOtomasyonuDataSet2 = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet2();
            this.BtnOdemeAl = new System.Windows.Forms.Button();
            this.borclarTableAdapter = new HuzurEviKayıtSistemi.HuzureviOtomasyonuDataSet2TableAdapters.BorclarTableAdapter();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtOdenenAy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzureviOtomasyonuDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yaşlı id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ödenen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalan Borç:";
            // 
            // TxtYasliid
            // 
            this.TxtYasliid.Location = new System.Drawing.Point(81, 6);
            this.TxtYasliid.Name = "TxtYasliid";
            this.TxtYasliid.Size = new System.Drawing.Size(116, 20);
            this.TxtYasliid.TabIndex = 3;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(81, 63);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(116, 20);
            this.TxtSoyad.TabIndex = 4;
            // 
            // TxtOdenen
            // 
            this.TxtOdenen.Location = new System.Drawing.Point(81, 94);
            this.TxtOdenen.Name = "TxtOdenen";
            this.TxtOdenen.Size = new System.Drawing.Size(116, 20);
            this.TxtOdenen.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yasliidDataGridViewTextBoxColumn,
            this.yasliAdDataGridViewTextBoxColumn,
            this.yasliSoyadDataGridViewTextBoxColumn,
            this.yasliKalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(238, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 197);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yasliidDataGridViewTextBoxColumn
            // 
            this.yasliidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliidDataGridViewTextBoxColumn.DataPropertyName = "Yasliid";
            this.yasliidDataGridViewTextBoxColumn.FillWeight = 35F;
            this.yasliidDataGridViewTextBoxColumn.HeaderText = "Yasliid";
            this.yasliidDataGridViewTextBoxColumn.Name = "yasliidDataGridViewTextBoxColumn";
            // 
            // yasliAdDataGridViewTextBoxColumn
            // 
            this.yasliAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliAdDataGridViewTextBoxColumn.DataPropertyName = "YasliAd";
            this.yasliAdDataGridViewTextBoxColumn.FillWeight = 75F;
            this.yasliAdDataGridViewTextBoxColumn.HeaderText = "YasliAd";
            this.yasliAdDataGridViewTextBoxColumn.Name = "yasliAdDataGridViewTextBoxColumn";
            // 
            // yasliSoyadDataGridViewTextBoxColumn
            // 
            this.yasliSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliSoyadDataGridViewTextBoxColumn.DataPropertyName = "YasliSoyad";
            this.yasliSoyadDataGridViewTextBoxColumn.FillWeight = 75F;
            this.yasliSoyadDataGridViewTextBoxColumn.HeaderText = "YasliSoyad";
            this.yasliSoyadDataGridViewTextBoxColumn.Name = "yasliSoyadDataGridViewTextBoxColumn";
            // 
            // yasliKalanBorcDataGridViewTextBoxColumn
            // 
            this.yasliKalanBorcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yasliKalanBorcDataGridViewTextBoxColumn.DataPropertyName = "YasliKalanBorc";
            this.yasliKalanBorcDataGridViewTextBoxColumn.FillWeight = 50F;
            this.yasliKalanBorcDataGridViewTextBoxColumn.HeaderText = "YasliKalanBorc";
            this.yasliKalanBorcDataGridViewTextBoxColumn.Name = "yasliKalanBorcDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.huzureviOtomasyonuDataSet2;
            // 
            // huzureviOtomasyonuDataSet2
            // 
            this.huzureviOtomasyonuDataSet2.DataSetName = "HuzureviOtomasyonuDataSet2";
            this.huzureviOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnOdemeAl
            // 
            this.BtnOdemeAl.Location = new System.Drawing.Point(95, 172);
            this.BtnOdemeAl.Name = "BtnOdemeAl";
            this.BtnOdemeAl.Size = new System.Drawing.Size(75, 23);
            this.BtnOdemeAl.TabIndex = 7;
            this.BtnOdemeAl.Text = "Ödeme Al";
            this.BtnOdemeAl.UseVisualStyleBackColor = true;
            this.BtnOdemeAl.Click += new System.EventHandler(this.BtnOdemeAl_Click);
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // TxtKalan
            // 
            this.TxtKalan.Location = new System.Drawing.Point(81, 146);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(116, 20);
            this.TxtKalan.TabIndex = 11;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(81, 32);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(116, 20);
            this.TxtAd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(33, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyad:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label4.Location = new System.Drawing.Point(50, 35);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(25, 15);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Ad:";
            // 
            // TxtOdenenAy
            // 
            this.TxtOdenenAy.Location = new System.Drawing.Point(81, 120);
            this.TxtOdenenAy.Name = "TxtOdenenAy";
            this.TxtOdenenAy.Size = new System.Drawing.Size(116, 20);
            this.TxtOdenenAy.TabIndex = 13;
            this.TxtOdenenAy.Text = "Boş Bırakmayınız!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(11, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ödenen Ay:";
            // 
            // FrmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 201);
            this.Controls.Add(this.TxtOdenenAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtKalan);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.BtnOdemeAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxtOdenen);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtYasliid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOdemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odemeler";
            this.Load += new System.EventHandler(this.FrmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huzureviOtomasyonuDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtYasliid;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtOdenen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOdemeAl;
        private HuzureviOtomasyonuDataSet2 huzureviOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private HuzureviOtomasyonuDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yasliKalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox TxtKalan;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TxtOdenenAy;
        private System.Windows.Forms.Label label6;
    }
}