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
    public partial class FrmYetkiliIslem : Form
    {
        public FrmYetkiliIslem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            frm.Show();
            
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            FrmMusteriAra frm = new FrmMusteriAra();
            frm.Show();
        }

        private void BtnGunc_Click(object sender, EventArgs e)
        {
            FrmMusterıGuncelle frm = new FrmMusterıGuncelle();
            frm.Show(); 
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            FrmMusteriSil frm = new FrmMusteriSil();
            frm.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmMusteriListele frm = new FrmMusteriListele();
            frm.Show();
        }
    }
}
