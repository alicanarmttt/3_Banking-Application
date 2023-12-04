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
    public partial class FrmBakiyeGor : Form
    {
        public FrmBakiyeGor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmBakiyeGor_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = Form1.mBakiye.ToString() + " TL";
            HareketKaydet.kaydet(Form1.mID,  "Bakiye sorgulandı.");
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
