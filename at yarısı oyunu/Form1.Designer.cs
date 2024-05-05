
namespace at_yarısı_oyunu
{
    partial class frm_GirisEkrani_212701069
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GirisEkrani_212701069));
            this.lblOyuncu_Sayisi_212701069 = new System.Windows.Forms.Label();
            this.txtOyuncu_Sayisi_212701069 = new System.Windows.Forms.TextBox();
            this.btn_Oyunagiris_212701069 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOyuncu_Sayisi_212701069
            // 
            this.lblOyuncu_Sayisi_212701069.AutoSize = true;
            this.lblOyuncu_Sayisi_212701069.BackColor = System.Drawing.Color.Thistle;
            this.lblOyuncu_Sayisi_212701069.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyuncu_Sayisi_212701069.ForeColor = System.Drawing.Color.Black;
            this.lblOyuncu_Sayisi_212701069.Location = new System.Drawing.Point(153, 325);
            this.lblOyuncu_Sayisi_212701069.Name = "lblOyuncu_Sayisi_212701069";
            this.lblOyuncu_Sayisi_212701069.Size = new System.Drawing.Size(234, 29);
            this.lblOyuncu_Sayisi_212701069.TabIndex = 0;
            this.lblOyuncu_Sayisi_212701069.Text = "Oyuncu Sayısı Giriniz:";
            // 
            // txtOyuncu_Sayisi_212701069
            // 
            this.txtOyuncu_Sayisi_212701069.Location = new System.Drawing.Point(427, 325);
            this.txtOyuncu_Sayisi_212701069.Multiline = true;
            this.txtOyuncu_Sayisi_212701069.Name = "txtOyuncu_Sayisi_212701069";
            this.txtOyuncu_Sayisi_212701069.Size = new System.Drawing.Size(114, 29);
            this.txtOyuncu_Sayisi_212701069.TabIndex = 1;
            // 
            // btn_Oyunagiris_212701069
            // 
            this.btn_Oyunagiris_212701069.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Oyunagiris_212701069.ForeColor = System.Drawing.Color.Black;
            this.btn_Oyunagiris_212701069.Location = new System.Drawing.Point(276, 360);
            this.btn_Oyunagiris_212701069.Name = "btn_Oyunagiris_212701069";
            this.btn_Oyunagiris_212701069.Size = new System.Drawing.Size(210, 57);
            this.btn_Oyunagiris_212701069.TabIndex = 2;
            this.btn_Oyunagiris_212701069.Text = "Oyuna Gir!";
            this.btn_Oyunagiris_212701069.UseVisualStyleBackColor = true;
            this.btn_Oyunagiris_212701069.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_GirisEkrani_212701069
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.btn_Oyunagiris_212701069);
            this.Controls.Add(this.txtOyuncu_Sayisi_212701069);
            this.Controls.Add(this.lblOyuncu_Sayisi_212701069);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_GirisEkrani_212701069";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyuncu_Sayisi_212701069;
        private System.Windows.Forms.TextBox txtOyuncu_Sayisi_212701069;
        private System.Windows.Forms.Button btn_Oyunagiris_212701069;
    }
}

