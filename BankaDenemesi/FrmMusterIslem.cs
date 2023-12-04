using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaDenemesi
{
    public partial class FrmMusterIslem : Form
    {
        public FrmMusterIslem()
        {
            InitializeComponent();
        }

        private void FrmMusterIslem_Load(object sender, EventArgs e)
        {
            lblAdSoyad.Text = Form1.AdSoyad;
            lblHesap.Text = Form1.mID.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmParaCek pr = new FrmParaCek();
            pr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmParaYatır py = new FrmParaYatır();
            py.Show();
        }

        private void btnBakiye_Click(object sender, EventArgs e)
        {
            FrmBakiyeGor bk = new FrmBakiyeGor();
            bk.Show();
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            FrmHavale hv= new FrmHavale();
            hv.Show();
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            FrmSifre sf= new FrmSifre();
            sf.Show();  
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            FrmHesapHareketleri hh= new FrmHesapHareketleri();
            hh.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMusterIslem_Leave(object sender, EventArgs e)
        {

        }
    }
}
