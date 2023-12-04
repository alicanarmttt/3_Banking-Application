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
    public partial class FrmMusteriSil : Form
    {
        public FrmMusteriSil()
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
            
            SqlCommand kmt2 = new SqlCommand("update TblMusteriler set durum=0 where ID=@p1 or TcNo=@p2", baglanti);
            
            kmt2.Parameters.AddWithValue("@p1", txtID.Text);
            kmt2.Parameters.AddWithValue("@p2", txtTcNo.Text);

            DialogResult dr = MessageBox.Show("Müşteri kaydını silmek istediğinize emin misiniz?", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
                txtTcNo.Text = "";
                txtAdSoyad.Text = "";
                txtAdres.Text = "";
                txtTel.Text = "";
                txtTcNo.Text = "";
                txtBakiye.Text = "";
            }
            else
            {
                baglanti.Open();
                int sonuc = kmt2.ExecuteNonQuery();
                if (sonuc >= 1)
                {
                    MessageBox.Show("Silme işlemi yapıldı.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi yapılamadı.");
                    txtTcNo.Text = "";
                    txtAdSoyad.Text = "";
                    txtAdres.Text = "";
                    txtTel.Text = "";
                    txtTcNo.Text = "";
                    txtBakiye.Text = "";
                }
                baglanti.Close();
            }

            

        }

        private void FrmMusteriSil_Load(object sender, EventArgs e)
        {

        }
    }
}
