namespace BankaDenemesi
{
    partial class FrmParaCek
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtParaMiktar = new System.Windows.Forms.MaskedTextBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ne kadar para çekmek istersiniz?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(124, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar(TL):";
            // 
            // txtParaMiktar
            // 
            this.txtParaMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaMiktar.Location = new System.Drawing.Point(248, 122);
            this.txtParaMiktar.Mask = "00000000";
            this.txtParaMiktar.Name = "txtParaMiktar";
            this.txtParaMiktar.Size = new System.Drawing.Size(101, 30);
            this.txtParaMiktar.TabIndex = 2;
            this.txtParaMiktar.ValidatingType = typeof(int);
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.Color.LawnGreen;
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(154, 171);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(174, 48);
            this.btnParaCek.TabIndex = 3;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.White;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Red;
            this.btnGeriDon.Location = new System.Drawing.Point(380, 221);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(97, 38);
            this.btnGeriDon.TabIndex = 4;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // FrmParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 271);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.txtParaMiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmParaCek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Çek";
            this.Load += new System.EventHandler(this.FrmParaCek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtParaMiktar;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnGeriDon;
    }
}