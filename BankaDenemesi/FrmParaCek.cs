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
    public partial class FrmParaCek : Form
    {
        public FrmParaCek()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void btnParaCek_Click(object sender, EventArgs e)
        {

            
            float sayi = float.Parse(txtParaMiktar.Text);
            if(sayi>Form1.mBakiye)
            {
                MessageBox.Show("Bakiyeniz yeterli değil.");
                txtParaMiktar.Text = "";
            }
            else
            {
                
                SqlCommand kmt1 = new SqlCommand("update TblMusteriler set bakiye=bakiye-@p1 where ID=@p2",baglanti);
                kmt1.Parameters.AddWithValue("@p1", sayi);
                kmt1.Parameters.AddWithValue("@p2", Form1.mID);
                baglanti.Open();
                kmt1.ExecuteNonQuery();
                MessageBox.Show("Para çekme işlemi yapıldı.");
                txtParaMiktar.Text = "";
                Form1.mBakiye -= sayi;
                HareketKaydet.kaydet(Form1.mID, (sayi + "Para Çekildi"));
            }


        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmParaCek_Load(object sender, EventArgs e)
        {

        }
    }
}
