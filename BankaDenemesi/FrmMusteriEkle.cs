using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaDenemesi
{
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }
        
        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand("insert into TblMusteriler (TcNo, AdSoyad, Adres, telefon, sifre, bakiye, durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            kmt1.Parameters.AddWithValue(@"p1", txtTcNo.Text);
            kmt1.Parameters.AddWithValue(@"p2", txtAdSoyad.Text);
            kmt1.Parameters.AddWithValue(@"p3", txtAdres.Text);
            kmt1.Parameters.AddWithValue(@"p4", txtTel.Text);
            kmt1.Parameters.AddWithValue(@"p5", txtTcNo.Text);
            kmt1.Parameters.AddWithValue(@"p6", txtBakiye.Text);
            kmt1.Parameters.AddWithValue(@"p7", 1);


            if (txtTcNo.Text == "" || txtAdSoyad.Text == "" || txtAdres.Text == "" || txtTel.Text == "" || txtBakiye.Text == "")
            {
                MessageBox.Show("Eksik alanları doldurunuz");
            }
            else
            {
                baglanti.Open();
                int sonuc = kmt1.ExecuteNonQuery();
                baglanti.Close();
                if (sonuc == 1)
                {
                    MessageBox.Show("Yeni müşteri kaydı tamamlandı.", "Müşteri Kaydı");
                }
                else { MessageBox.Show("Hata oldu"); }

            }

            txtTcNo.Text = "";
            txtAdSoyad.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            txtTcNo.Text = "";
            txtBakiye.Text = "";


        }
    }
}
