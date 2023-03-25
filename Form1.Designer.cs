namespace DepoTakip
{
    partial class FrmMenu
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtkTakip = new System.Windows.Forms.Button();
            this.BtnSatis = new System.Windows.Forms.Button();
            this.Btnİstatistik = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnEkle.Location = new System.Drawing.Point(46, 47);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(121, 82);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "Ürün Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.BtnGuncelle.Location = new System.Drawing.Point(186, 50);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(131, 82);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.Text = "Ürün Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtkTakip
            // 
            this.BtkTakip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtkTakip.Location = new System.Drawing.Point(341, 53);
            this.BtkTakip.Name = "BtkTakip";
            this.BtkTakip.Size = new System.Drawing.Size(118, 79);
            this.BtkTakip.TabIndex = 2;
            this.BtkTakip.Text = "Stok Takip";
            this.BtkTakip.UseVisualStyleBackColor = false;
            this.BtkTakip.Click += new System.EventHandler(this.BtkTakip_Click);
            // 
            // BtnSatis
            // 
            this.BtnSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnSatis.Location = new System.Drawing.Point(46, 151);
            this.BtnSatis.Name = "BtnSatis";
            this.BtnSatis.Size = new System.Drawing.Size(121, 76);
            this.BtnSatis.TabIndex = 3;
            this.BtnSatis.Text = "Satış Ekle";
            this.BtnSatis.UseVisualStyleBackColor = false;
            this.BtnSatis.Click += new System.EventHandler(this.BtnSatis_Click);
            // 
            // Btnİstatistik
            // 
            this.Btnİstatistik.BackColor = System.Drawing.Color.Magenta;
            this.Btnİstatistik.Location = new System.Drawing.Point(186, 151);
            this.Btnİstatistik.Name = "Btnİstatistik";
            this.Btnİstatistik.Size = new System.Drawing.Size(157, 76);
            this.Btnİstatistik.TabIndex = 4;
            this.Btnİstatistik.Text = "İstatistikler";
            this.Btnİstatistik.UseVisualStyleBackColor = false;
            // 
            // BtnCikis
            // 
            this.BtnCikis.BackColor = System.Drawing.Color.Red;
            this.BtnCikis.Location = new System.Drawing.Point(361, 151);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(98, 76);
            this.BtnCikis.TabIndex = 5;
            this.BtnCikis.Text = "Çıkış";
            this.BtnCikis.UseVisualStyleBackColor = false;
            this.BtnCikis.Click += new System.EventHandler(this.BtnCikis_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(512, 273);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.Btnİstatistik);
            this.Controls.Add(this.BtnSatis);
            this.Controls.Add(this.BtkTakip);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnEkle);
            this.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMenu";
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtkTakip;
        private System.Windows.Forms.Button BtnSatis;
        private System.Windows.Forms.Button Btnİstatistik;
        private System.Windows.Forms.Button BtnCikis;
    }
}

