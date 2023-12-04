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
    public partial class FrmHavale : Form
    {
        public FrmHavale()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void FrmHavale_Load(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(txtParaMiktar.Text);

            if (sayi < 10)
            {
                MessageBox.Show("Yetersiz bakiye.");

            }
            else
            {
                //Hesabından para çıkan kişi
                SqlCommand kmt = new SqlCommand("update TblMusteriler set bakiye=bakiye-@p1 where ID=@p2", baglanti);
                kmt.Parameters.AddWithValue("@p1", sayi);
                kmt.Parameters.AddWithValue("@p2", Form1.mID);
                //Hesabına para giren kişi
                SqlCommand kmt2 = new SqlCommand("update TblMusteriler set bakiye=bakiye+@p3 where ID=@p4", baglanti);
                kmt2.Parameters.AddWithValue("@p3", sayi);
                kmt2.Parameters.AddWithValue("@p4", txtHesapNo.Text);

                if (sayi < 10)
                {
                    MessageBox.Show("10 TL ve üzeri transferler yapılabilir.");
                }
                else
                {
                    baglanti.Open();
                    int sonuc = kmt2.ExecuteNonQuery();
                    baglanti.Close();

                    if (sonuc == 1)
                    {
                        baglanti.Open();
                        kmt.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Havale işlemleri gerçekleştirildi.");
                        Form1.mBakiye -= sayi;
                        HareketKaydet.kaydet(Form1.mID, (sayi + "TL Havale gönderildi."));
                        HareketKaydet.kaydet(Form1.mID, (sayi + "TL Havale gönderildi."));
                    }

                    else
                    {
                        MessageBox.Show("Alıcı Hesap No Hatalı!");
                    }
                }
                

            }
            txtParaMiktar.Text = "";
            txtHesapNo.Text = "";




        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtHesapNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtParaMiktar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
