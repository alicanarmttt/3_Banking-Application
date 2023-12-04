namespace BankaDenemesi
{
    partial class FrmMusterIslem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnBakiye = new System.Windows.Forms.Button();
            this.btnParaYatır = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.btnHesap = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblHesap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCıkıs);
            this.groupBox1.Controls.Add(this.btnHavale);
            this.groupBox1.Controls.Add(this.btnHesap);
            this.groupBox1.Controls.Add(this.btnSifre);
            this.groupBox1.Controls.Add(this.btnParaYatır);
            this.groupBox1.Controls.Add(this.btnBakiye);
            this.groupBox1.Controls.Add(this.btnParaCek);
            this.groupBox1.Location = new System.Drawing.Point(74, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 559);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(114, 57);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(169, 46);
            this.btnParaCek.TabIndex = 0;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBakiye
            // 
            this.btnBakiye.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakiye.Location = new System.Drawing.Point(114, 191);
            this.btnBakiye.Name = "btnBakiye";
            this.btnBakiye.Size = new System.Drawing.Size(169, 46);
            this.btnBakiye.TabIndex = 1;
            this.btnBakiye.Text = "Bakiye Görüntüle";
            this.btnBakiye.UseVisualStyleBackColor = false;
            this.btnBakiye.Click += new System.EventHandler(this.btnBakiye_Click);
            // 
            // btnParaYatır
            // 
            this.btnParaYatır.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnParaYatır.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatır.Location = new System.Drawing.Point(114, 124);
            this.btnParaYatır.Name = "btnParaYatır";
            this.btnParaYatır.Size = new System.Drawing.Size(169, 46);
            this.btnParaYatır.TabIndex = 2;
            this.btnParaYatır.Text = "Para Yatır";
            this.btnParaYatır.UseVisualStyleBackColor = false;
            this.btnParaYatır.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSifre
            // 
            this.btnSifre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifre.Location = new System.Drawing.Point(114, 325);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(169, 46);
            this.btnSifre.TabIndex = 3;
            this.btnSifre.Text = "Şifre Değiştir";
            this.btnSifre.UseVisualStyleBackColor = false;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // btnHesap
            // 
            this.btnHesap.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesap.Location = new System.Drawing.Point(114, 392);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(169, 46);
            this.btnHesap.TabIndex = 4;
            this.btnHesap.Text = "Hesap Hareketleri";
            this.btnHesap.UseVisualStyleBackColor = false;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // btnHavale
            // 
            this.btnHavale.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.Location = new System.Drawing.Point(114, 258);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(169, 46);
            this.btnHavale.TabIndex = 5;
            this.btnHavale.Text = "Havale / EFT";
            this.btnHavale.UseVisualStyleBackColor = false;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Red;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.Location = new System.Drawing.Point(114, 497);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(169, 46);
            this.btnCıkıs.TabIndex = 6;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(66, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(94, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Ad Soyad:";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblAdSoyad.Location = new System.Drawing.Point(184, 23);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(14, 20);
            this.lblAdSoyad.TabIndex = 8;
            this.lblAdSoyad.Text = ".";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label3.ForeColor = System.Drawing.Color.Red;
            this.Label3.Location = new System.Drawing.Point(62, 58);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 20);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Hesap No:";
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesap.ForeColor = System.Drawing.Color.Red;
            this.lblHesap.Location = new System.Drawing.Point(184, 58);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(14, 20);
            this.lblHesap.TabIndex = 10;
            this.lblHesap.Text = ".";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Controls.Add(this.lblHesap);
            this.groupBox2.Controls.Add(this.Label1);
            this.groupBox2.Controls.Add(this.lblAdSoyad);
            this.groupBox2.Location = new System.Drawing.Point(134, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // FrmMusterIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 679);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmMusterIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.Load += new System.EventHandler(this.FrmMusterIslem_Load);
            this.Leave += new System.EventHandler(this.FrmMusterIslem_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Button btnParaYatır;
        private System.Windows.Forms.Button btnBakiye;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}