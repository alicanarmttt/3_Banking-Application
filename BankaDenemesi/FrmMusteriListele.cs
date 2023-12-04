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
    public partial class FrmMusteriListele : Form
    {
        public FrmMusteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("server = D15\\SQLEXPRESS; initial catalog = Bankamatik; integrated security = sspi");
        private void FrmMusteriListele_Load(object sender, EventArgs e)
        {
            SqlCommand kmt1 = new SqlCommand("Select * from TblMusteriler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kmt1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand kmt2 = new SqlCommand("Select * from TblMusteriler where AdSoyad like '"+textBox1.Text+"%' ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kmt2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
