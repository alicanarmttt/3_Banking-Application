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
    public partial class FrmMusterıGuncelle : Form
    {
        public FrmMusterıGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
       

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand("select * from TblMusteriler where ID=@p1 or TcNo =@p2 ", baglanti);
            kmt1.Parameters.AddWithValue(@"p1", txtAra.Text);
            kmt1.Parameters.AddWithValue(@"p2", txtAra.Text);

            baglanti.Open();

            SqlDataReader rd = kmt1.ExecuteReader();
            if (rd.Read())
            {
                txtID.Text = rd["ID"].ToString();
                txtTcNo.Text = rd["TcNo"].ToString();
                txtAdSoyad.Text = rd["AdSoyad"].ToString();
                txtAdres.Text = rd["Adres"].ToString();
                txtTel.Text = rd["telefon"].ToString();
                txtBakiye.Text = rd["bakiye"].ToString();
            }
            else
            {
                MessageBox.Show(txtID.Text + "Numaralı kayıt bulunamadı!");
                txtID.Text = "";
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTel.Text = "";
                txtBakiye.Text = "";
            }

            baglanti.Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt2 = new SqlCommand("update TblMusteriler set AdSoyad=@p1, Adres=@p2, telefon=@p3, durum=@p6 where ID=@P4 or TcNo=@P5", baglanti);
            kmt2.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            kmt2.Parameters.AddWithValue("@p2", txtAdres.Text);
            kmt2.Parameters.AddWithValue("@p3", txtTel.Text);
            kmt2.Parameters.AddWithValue("@p4", txtID.Text);
            kmt2.Parameters.AddWithValue("@p5", txtTcNo.Text);
            kmt2.Parameters.AddWithValue("@p6", maskedTextBox1.Text);
            int sonuc = kmt2.ExecuteNonQuery();
            if(sonuc>=1)
            {
                MessageBox.Show("Güncelleme yapıldı.");
            }
            else
            {
                MessageBox.Show("Güncelleme yapılamadı.");
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTel.Text = "";
                txtTcNo.Text = "";
                txtBakiye.Text = "";
            }
            baglanti.Close();
            
        }

        private void FrmMusterıGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
