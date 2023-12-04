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
    public partial class FrmParaYatır : Form
    {
        public FrmParaYatır()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void FrmParaYatır_Load(object sender, EventArgs e)
        {

        }

        private void btnParaYatır_Click(object sender, EventArgs e)
        {

            float sayi = float.Parse(txtParaMiktar.Text);
            if ((int.Parse(txtParaMiktar.Text) <= 10) || string.IsNullOrEmpty(txtParaMiktar.Text))
            {
                MessageBox.Show("Hatalı giriş yaptınız. 10 TL ve üzeri bir miktar deneyin.");
                txtParaMiktar.Text = "";
            }
            else
            {

                SqlCommand kmt1 = new SqlCommand("update TblMusteriler set bakiye=bakiye+@p1 where ID=@p2", baglanti);
                kmt1.Parameters.AddWithValue("@p1", sayi);
                kmt1.Parameters.AddWithValue("@p2", Form1.mID);
                baglanti.Open();
                kmt1.ExecuteNonQuery();
                MessageBox.Show("Para yatırma işlemi yapıldı.");
                txtParaMiktar.Text = "";
                HareketKaydet.kaydet(Form1.mID, (sayi + "TL Para Yatırıldı."));
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
