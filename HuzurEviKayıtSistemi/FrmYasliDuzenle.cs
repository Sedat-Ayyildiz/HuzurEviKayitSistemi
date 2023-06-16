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
    public partial class FrmYasliDuzenle : Form
    {
        public FrmYasliDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        public string id,ad,soyad,TC,telefon,dogum,bolum;       

        public string sgkno, odano, veliad, velitel, adres;
        private void FrmYasliDuzenle_Load(object sender, EventArgs e)
        {
            TxtYasliid.Text = id;
            TxtYasliAd.Text = ad;
            TxtYasliSoyad.Text = soyad;
            MskTC.Text = TC;
            MskYasliTelefon.Text = telefon;
            MskDogum.Text = dogum;
            CmbBolum.Text = bolum;
            TxtSgkNo.Text = sgkno;
            CmbOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTelefon.Text = velitel;
            RchAdres.Text = adres;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Yasli set YasliAd=@p2,YasliSoyad=@p3,YasliTC=@p4,YasliTelefon=@p5,YasliDogum=@p6,YasliBolum=@p7,YasliSgkNo=@p8,YasliOdaNo=@p9,YasliVeliAdSoyad=@p10,YasliVeliTelefon=@p11,YasliVeliAdres=@p12 where Yasliid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtYasliid.Text);
                komut.Parameters.AddWithValue("@p2", TxtYasliAd.Text);
                komut.Parameters.AddWithValue("@p3", TxtYasliSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskYasliTelefon.Text);
                komut.Parameters.AddWithValue("@p5", MskYasliTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogum.Text);
                komut.Parameters.AddWithValue("@p7", CmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtSgkNo.Text);
                komut.Parameters.AddWithValue("@p9", CmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", RchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Yeniden Deneyin.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Yaşlı Silme
            SqlCommand komutsil = new SqlCommand("delete from Yasli where Yasliid=@k1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@k1",TxtYasliid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.");

            //Odanın Aktif Yaşlı Kalan Sayısını Azaltma
            SqlCommand komutoda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda", CmbOdaNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
