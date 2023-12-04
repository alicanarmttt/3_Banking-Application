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
    public partial class FrmMusteriAra : Form
    {
        public FrmMusteriAra()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void FrmMusteriAra_Load(object sender, EventArgs e)
        {

        }

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
    }
}
