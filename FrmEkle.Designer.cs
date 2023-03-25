namespace DepoTakip
{
    partial class FrmEkle
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
            this.components = new System.ComponentModel.Container();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtBarkod = new System.Windows.Forms.TextBox();
            this.Txtisim = new System.Windows.Forms.TextBox();
            this.MskAdet = new System.Windows.Forms.MaskedTextBox();
            this.MskAlis = new System.Windows.Forms.MaskedTextBox();
            this.MskSatis = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.BtnKapat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnEkle1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.Location = new System.Drawing.Point(897, 14);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(5);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(82, 48);
            this.BtnGeri.TabIndex = 0;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Barkodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün İsmi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adeti:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // TxtBarkod
            // 
            this.TxtBarkod.Location = new System.Drawing.Point(194, 130);
            this.TxtBarkod.Name = "TxtBarkod";
            this.TxtBarkod.Size = new System.Drawing.Size(199, 35);
            this.TxtBarkod.TabIndex = 6;
            // 
            // Txtisim
            // 
            this.Txtisim.Location = new System.Drawing.Point(194, 179);
            this.Txtisim.Name = "Txtisim";
            this.Txtisim.Size = new System.Drawing.Size(199, 35);
            this.Txtisim.TabIndex = 7;
            // 
            // MskAdet
            // 
            this.MskAdet.Location = new System.Drawing.Point(194, 237);
            this.MskAdet.Mask = "00000000";
            this.MskAdet.Name = "MskAdet";
            this.MskAdet.Size = new System.Drawing.Size(199, 35);
            this.MskAdet.TabIndex = 8;
            this.MskAdet.ValidatingType = typeof(int);
            // 
            // MskAlis
            // 
            this.MskAlis.Location = new System.Drawing.Point(194, 289);
            this.MskAlis.Mask = "00000000";
            this.MskAlis.Name = "MskAlis";
            this.MskAlis.Size = new System.Drawing.Size(199, 35);
            this.MskAlis.TabIndex = 9;
            // 
            // MskSatis
            // 
            this.MskSatis.Location = new System.Drawing.Point(194, 342);
            this.MskSatis.Mask = "00000000";
            this.MskSatis.Name = "MskSatis";
            this.MskSatis.Size = new System.Drawing.Size(199, 35);
            this.MskSatis.TabIndex = 10;
            this.MskSatis.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kamera:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(524, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 34);
            this.comboBox1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(423, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.Location = new System.Drawing.Point(879, 101);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(111, 64);
            this.BtnBaslat.TabIndex = 14;
            this.BtnBaslat.Text = "Barkod Tara";
            this.BtnBaslat.UseVisualStyleBackColor = true;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Location = new System.Drawing.Point(879, 361);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(111, 78);
            this.BtnKapat.TabIndex = 15;
            this.BtnKapat.Text = "Kamera Kapat";
            this.BtnKapat.UseVisualStyleBackColor = true;
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BtnEkle1
            // 
            this.BtnEkle1.Location = new System.Drawing.Point(194, 400);
            this.BtnEkle1.Name = "BtnEkle1";
            this.BtnEkle1.Size = new System.Drawing.Size(199, 39);
            this.BtnEkle1.TabIndex = 16;
            this.BtnEkle1.Text = "Ürün Ekle";
            this.BtnEkle1.UseVisualStyleBackColor = true;
            this.BtnEkle1.Click += new System.EventHandler(this.BtnEkle1_Click);
            // 
            // FrmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1002, 477);
            this.Controls.Add(this.BtnEkle1);
            this.Controls.Add(this.BtnKapat);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MskSatis);
            this.Controls.Add(this.MskAlis);
            this.Controls.Add(this.MskAdet);
            this.Controls.Add(this.Txtisim);
            this.Controls.Add(this.TxtBarkod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGeri);
            this.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmEkle";
            this.Text = "FrmEkle";
            this.Load += new System.EventHandler(this.FrmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtBarkod;
        private System.Windows.Forms.TextBox Txtisim;
        private System.Windows.Forms.MaskedTextBox MskAdet;
        private System.Windows.Forms.MaskedTextBox MskAlis;
        private System.Windows.Forms.MaskedTextBox MskSatis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Button BtnKapat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnEkle1;
    }
}