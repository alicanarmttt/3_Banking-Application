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

namespace BankaDenemesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        public static string AdSoyad = "";
        public static int mID=0;
        public static float mBakiye= 0.0f;
       


        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıTcNo = textBox1.Text;
            string parola = textBox2.Text;
            bool sonuc = false;
            

            if (radioButton2.Checked)
            {
                
                if(kullanıcıTcNo =="admin" &&  parola =="123")
                {
                    FrmYetkiliIslem yi = new FrmYetkiliIslem();
                    yi.Show();
                    this.Hide();


                }
                
            }
            else
            {
                baglanti.Open();
                SqlCommand kmt1 = new SqlCommand("Select * from TblMusteriler where TcNo=@p1 and sifre=@p2 and durum=1 ", baglanti);
                kmt1.Parameters.AddWithValue("@p1",kullanıcıTcNo);
                kmt1.Parameters.AddWithValue("@p2", parola);
                

                SqlDataReader dr = kmt1.ExecuteReader();
                while (dr.Read())
                {
                    try
                    {
                        AdSoyad = dr["AdSoyad"].ToString();
                        mID = int.Parse(dr["ID"].ToString());
                        mBakiye = float.Parse(dr["bakiye"].ToString());
                        
                        sonuc = true;
                    }

                    catch { MessageBox.Show("Bilgiler alınamadı"); }
                    //Kişi müşteri ise ve kullanıcı bilgileri doğruysa Durumu kontrol et. Durum=0 ise "hesabınız aktif değil" uyarısı versin.
                }
                baglanti.Close();


                if (sonuc)
                {
                    sonuc = false;
                    FrmMusterIslem yi = new FrmMusterIslem();
                    yi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş denemesi.");
                }
                textBox1.Text = "";
                textBox2.Text = "";

            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifeUnuttum sf = new FrmSifeUnuttum();
            sf.Show();
        }
    }
}
