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
    public partial class FrmSifeUnuttum : Form
    {
        public FrmSifeUnuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void FrmSifeUnuttum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "" || txtTel.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen boş alanı doldurunuz.");

            }
            else
            {
                string kontrolTc = txtTc.Text;
                string kontrolTel = txtTel.Text;
                

                if (txtSifre.Text.Length >= 3 && txtSifre.Text.Length < 6)
                {
                    MessageBox.Show("Yeni şifre en az 3 en fazla 5 karakterli olmalıdır.");

                    txtSifre.Text = "";
                }
                else 
                {
                    SqlCommand kmt2 = new SqlCommand("update TblMusteriler set sifre=@p3 where TcNo=@p1 and telefon=@p2", baglanti);
                    kmt2.Parameters.AddWithValue("@p3", txtSifre.Text);
                    kmt2.Parameters.AddWithValue("@p2", txtTc.Text);
                    kmt2.Parameters.AddWithValue("@p1", txtTel.Text);

                    baglanti.Open();
                    int sonuc = kmt2.ExecuteNonQuery();
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Şifreniz değiştirildi.");
                        //HareketKaydet.kaydet(Form1.mID, "Şifre değiştirildi.");

                    }

                    else 
                    {
                        MessageBox.Show("Şifreniz değiştirilemedi.");

                    }
                    baglanti.Close();  
                }
               
                
            }
        }
    }
}
