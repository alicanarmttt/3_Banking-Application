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
using System.Windows.Forms.VisualStyles;

namespace BankaDenemesi
{
    public partial class FrmSifre : Form
    {
        public FrmSifre()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void FrmSifre_Load(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            
            if (txtEski.Text =="" || txtYeni.Text =="")
            {
                MessageBox.Show("Lütfen alanı doldurunuz.");
                
            }
            else
            {
                string eskiSifre = txtEski.Text;
                SqlCommand kmt1 = new SqlCommand("select sifre from TblMusteriler where ID=@p2", baglanti);
                kmt1.Parameters.AddWithValue("@p2", Form1.mID);
                baglanti.Open();
                SqlDataReader rd = kmt1.ExecuteReader();
                
                if (rd.Read())
                {
                    eskiSifre = rd["sifre"].ToString();
                }
                baglanti.Close();
                if (txtYeni.Text.Length>=3)
                {
                    if (eskiSifre == txtEski.Text)
                    {
                        SqlCommand kmt2 = new SqlCommand("update TblMusteriler set sifre=@p3 where ID=@p2", baglanti);
                        kmt2.Parameters.AddWithValue("@p3", txtYeni.Text);
                        kmt2.Parameters.AddWithValue("@p2", Form1.mID);
                        baglanti.Open();
                        int sonuc = kmt2.ExecuteNonQuery();
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Şifreniz değiştirildi.");
                            HareketKaydet.kaydet(Form1.mID,  "Şifre değiştirildi.");

                        }

                        else
                        {
                            MessageBox.Show("Şifreniz değiştirilemedi.");

                        }
                        baglanti.Close();
                    }

                    else
                    {
                        MessageBox.Show("Eski şifreniz hatalı");
                    }
                    baglanti.Close();
                }
                else if (txtYeni.Text.Length < 3)
                {
                    MessageBox.Show("Yeni şifre en az 3 karakterli olmalıdır.");
                    
                    txtYeni.Text = "";
                }
                baglanti.Close();

                
                
                
            }

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
