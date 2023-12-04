namespace BankaDenemesi
{
    partial class FrmYetkiliIslem
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
            this.label1 = new System.Windows.Forms.Label();
            this.İşlemler = new System.Windows.Forms.GroupBox();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.BtnListe = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGunc = new System.Windows.Forms.Button();
            this.BtnAra = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.İşlemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(224, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş geldiniz Admin";
            // 
            // İşlemler
            // 
            this.İşlemler.Controls.Add(this.BtnCıkıs);
            this.İşlemler.Controls.Add(this.BtnListe);
            this.İşlemler.Controls.Add(this.BtnSil);
            this.İşlemler.Controls.Add(this.BtnGunc);
            this.İşlemler.Controls.Add(this.BtnAra);
            this.İşlemler.Controls.Add(this.BtnEkle);
            this.İşlemler.Location = new System.Drawing.Point(89, 71);
            this.İşlemler.Name = "İşlemler";
            this.İşlemler.Size = new System.Drawing.Size(436, 533);
            this.İşlemler.TabIndex = 1;
            this.İşlemler.TabStop = false;
            this.İşlemler.Text = "İşlemler";
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCıkıs.ForeColor = System.Drawing.Color.Red;
            this.BtnCıkıs.Location = new System.Drawing.Point(123, 406);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(206, 49);
            this.BtnCıkıs.TabIndex = 5;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = true;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // BtnListe
            // 
            this.BtnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnListe.Location = new System.Drawing.Point(123, 337);
            this.BtnListe.Name = "BtnListe";
            this.BtnListe.Size = new System.Drawing.Size(206, 49);
            this.BtnListe.TabIndex = 4;
            this.BtnListe.Text = "Müşterileri Listele";
            this.BtnListe.UseVisualStyleBackColor = true;
            this.BtnListe.Click += new System.EventHandler(this.BtnListe_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(123, 271);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(206, 49);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Müşteri Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGunc
            // 
            this.BtnGunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGunc.Location = new System.Drawing.Point(123, 207);
            this.BtnGunc.Name = "BtnGunc";
            this.BtnGunc.Size = new System.Drawing.Size(206, 49);
            this.BtnGunc.TabIndex = 2;
            this.BtnGunc.Text = "Müşteri Güncelle";
            this.BtnGunc.UseVisualStyleBackColor = true;
            this.BtnGunc.Click += new System.EventHandler(this.BtnGunc_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAra.Location = new System.Drawing.Point(123, 142);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(206, 49);
            this.BtnAra.TabIndex = 1;
            this.BtnAra.Text = "Müşteri Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Location = new System.Drawing.Point(123, 78);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(206, 49);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "Müşteri Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // FrmYetkiliIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 645);
            this.Controls.Add(this.İşlemler);
            this.Controls.Add(this.label1);
            this.Name = "FrmYetkiliIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili İşlem";
            this.İşlemler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox İşlemler;
        private System.Windows.Forms.Button BtnCıkıs;
        private System.Windows.Forms.Button BtnListe;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGunc;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.Button BtnEkle;
    }
}