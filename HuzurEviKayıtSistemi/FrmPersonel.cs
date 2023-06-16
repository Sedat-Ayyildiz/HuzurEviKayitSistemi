using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HuzurEviKayıtSistemi
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'huzureviOtomasyonuDataSet7.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter1.Fill(this.huzureviOtomasyonuDataSet7.Personel);
            // TODO: This line of code loads data into the 'huzureviOtomasyonuDataSet6.Personel' table. You can move, or remove it, as needed.
            //this.personelTableAdapter.Fill(this.huzureviOtomasyonuDataSet6.Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personel (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtPersonelAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi.");
            this.personelTableAdapter1.Fill(this.huzureviOtomasyonuDataSet7.Personel);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personel where Personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");
            this.personelTableAdapter1.Fill(this.huzureviOtomasyonuDataSet7.Personel);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komutgun.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
            komutgun.Parameters.AddWithValue("@p2", TxtPersonelGorev.Text);
            komutgun.Parameters.AddWithValue("@p3", TxtPersonelid.Text);
            komutgun.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
            this.personelTableAdapter1.Fill(this.huzureviOtomasyonuDataSet7.Personel);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, gorev;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();            

            TxtPersonelid.Text = id;
            TxtPersonelAd.Text = ad;
            TxtPersonelGorev.Text = gorev;            
        }
    }
}
