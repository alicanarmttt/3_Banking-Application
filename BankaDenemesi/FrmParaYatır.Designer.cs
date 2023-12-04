namespace BankaDenemesi
{
    partial class FrmParaYatır
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
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnParaYatır = new System.Windows.Forms.Button();
            this.txtParaMiktar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.White;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Red;
            this.btnGeriDon.Location = new System.Drawing.Point(361, 197);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(97, 38);
            this.btnGeriDon.TabIndex = 9;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnParaYatır
            // 
            this.btnParaYatır.BackColor = System.Drawing.Color.LawnGreen;
            this.btnParaYatır.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatır.Location = new System.Drawing.Point(135, 147);
            this.btnParaYatır.Name = "btnParaYatır";
            this.btnParaYatır.Size = new System.Drawing.Size(174, 48);
            this.btnParaYatır.TabIndex = 8;
            this.btnParaYatır.Text = "Para Yatır";
            this.btnParaYatır.UseVisualStyleBackColor = false;
            this.btnParaYatır.Click += new System.EventHandler(this.btnParaYatır_Click);
            // 
            // txtParaMiktar
            // 
            this.txtParaMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaMiktar.Location = new System.Drawing.Point(229, 98);
            this.txtParaMiktar.Mask = "00000000";
            this.txtParaMiktar.Name = "txtParaMiktar";
            this.txtParaMiktar.Size = new System.Drawing.Size(101, 30);
            this.txtParaMiktar.TabIndex = 7;
            this.txtParaMiktar.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miktar(TL):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(68, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ne kadar para yatırmak istersiniz?";
            // 
            // FrmParaYatır
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 271);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnParaYatır);
            this.Controls.Add(this.txtParaMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmParaYatır";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmParaYatır";
            this.Load += new System.EventHandler(this.FrmParaYatır_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnParaYatır;
        private System.Windows.Forms.MaskedTextBox txtParaMiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}