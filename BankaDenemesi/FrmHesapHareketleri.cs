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
    public partial class FrmHesapHareketleri : Form
    {
        public FrmHesapHareketleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void FrmHesapHareketleri_Load(object sender, EventArgs e)
        {
            SqlCommand kmt = new SqlCommand("select * from TblHareketler where musteriID=@p1",baglanti);
            kmt.Parameters.AddWithValue("@p1", Form1.mID);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
