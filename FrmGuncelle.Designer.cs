namespace DepoTakip
{
    partial class FrmGuncelle
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alışFiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satışFiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblÜrünBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoVeriDataSet = new DepoTakip.DepoVeriDataSet();
            this.tbl_ÜrünBilgiTableAdapter = new DepoTakip.DepoVeriDataSetTableAdapters.Tbl_ÜrünBilgiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MskSatisG = new System.Windows.Forms.MaskedTextBox();
            this.MskAlisG = new System.Windows.Forms.MaskedTextBox();
            this.MskAdetG = new System.Windows.Forms.MaskedTextBox();
            this.TxtisimG = new System.Windows.Forms.TextBox();
            this.TxtBarkodG = new System.Windows.Forms.TextBox();
            this.BtnGuncelleG = new System.Windows.Forms.Button();
            this.BtnSilg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoVeriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(0, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodNoDataGridViewTextBoxColumn,
            this.ürünİsmiDataGridViewTextBoxColumn,
            this.ürünAdetDataGridViewTextBoxColumn,
            this.alışFiyatıDataGridViewTextBoxColumn,
            this.satışFiyatıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblÜrünBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            this.barkodNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünİsmiDataGridViewTextBoxColumn
            // 
            this.ürünİsmiDataGridViewTextBoxColumn.DataPropertyName = "Ürünİsmi";
            this.ürünİsmiDataGridViewTextBoxColumn.HeaderText = "Ürünİsmi";
            this.ürünİsmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünİsmiDataGridViewTextBoxColumn.Name = "ürünİsmiDataGridViewTextBoxColumn";
            this.ürünİsmiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ürünAdetDataGridViewTextBoxColumn
            // 
            this.ürünAdetDataGridViewTextBoxColumn.DataPropertyName = "ÜrünAdet";
            this.ürünAdetDataGridViewTextBoxColumn.HeaderText = "ÜrünAdet";
            this.ürünAdetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ürünAdetDataGridViewTextBoxColumn.Name = "ürünAdetDataGridViewTextBoxColumn";
            this.ürünAdetDataGridViewTextBoxColumn.Width = 125;
            // 
            // alışFiyatıDataGridViewTextBoxColumn
            // 
            this.alışFiyatıDataGridViewTextBoxColumn.DataPropertyName = "AlışFiyatı";
            this.alışFiyatıDataGridViewTextBoxColumn.HeaderText = "AlışFiyatı";
            this.alışFiyatıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alışFiyatıDataGridViewTextBoxColumn.Name = "alışFiyatıDataGridViewTextBoxColumn";
            this.alışFiyatıDataGridViewTextBoxColumn.Width = 125;
            // 
            // satışFiyatıDataGridViewTextBoxColumn
            // 
            this.satışFiyatıDataGridViewTextBoxColumn.DataPropertyName = "SatışFiyatı";
            this.satışFiyatıDataGridViewTextBoxColumn.HeaderText = "SatışFiyatı";
            this.satışFiyatıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satışFiyatıDataGridViewTextBoxColumn.Name = "satışFiyatıDataGridViewTextBoxColumn";
            this.satışFiyatıDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblÜrünBilgiBindingSource
            // 
            this.tblÜrünBilgiBindingSource.DataMember = "Tbl_ÜrünBilgi";
            this.tblÜrünBilgiBindingSource.DataSource = this.depoVeriDataSet;
            // 
            // depoVeriDataSet
            // 
            this.depoVeriDataSet.DataSetName = "DepoVeriDataSet";
            this.depoVeriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ÜrünBilgiTableAdapter
            // 
            this.tbl_ÜrünBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Alış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Satış Fiyatı:";
            // 
            // MskSatisG
            // 
            this.MskSatisG.Location = new System.Drawing.Point(175, 304);
            this.MskSatisG.Mask = "00000000";
            this.MskSatisG.Name = "MskSatisG";
            this.MskSatisG.Size = new System.Drawing.Size(199, 30);
            this.MskSatisG.TabIndex = 15;
            this.MskSatisG.ValidatingType = typeof(int);
            // 
            // MskAlisG
            // 
            this.MskAlisG.Location = new System.Drawing.Point(175, 244);
            this.MskAlisG.Mask = "00000000";
            this.MskAlisG.Name = "MskAlisG";
            this.MskAlisG.Size = new System.Drawing.Size(199, 30);
            this.MskAlisG.TabIndex = 14;
            // 
            // MskAdetG
            // 
            this.MskAdetG.Location = new System.Drawing.Point(175, 188);
            this.MskAdetG.Mask = "00000000";
            this.MskAdetG.Name = "MskAdetG";
            this.MskAdetG.Size = new System.Drawing.Size(199, 30);
            this.MskAdetG.TabIndex = 13;
            this.MskAdetG.ValidatingType = typeof(int);
            // 
            // TxtisimG
            // 
            this.TxtisimG.Location = new System.Drawing.Point(175, 130);
            this.TxtisimG.Name = "TxtisimG";
            this.TxtisimG.Size = new System.Drawing.Size(199, 30);
            this.TxtisimG.TabIndex = 12;
            // 
            // TxtBarkodG
            // 
            this.TxtBarkodG.Location = new System.Drawing.Point(175, 69);
            this.TxtBarkodG.Name = "TxtBarkodG";
            this.TxtBarkodG.Size = new System.Drawing.Size(199, 30);
            this.TxtBarkodG.TabIndex = 11;
            // 
            // BtnGuncelleG
            // 
            this.BtnGuncelleG.Location = new System.Drawing.Point(441, 218);
            this.BtnGuncelleG.Name = "BtnGuncelleG";
            this.BtnGuncelleG.Size = new System.Drawing.Size(143, 35);
            this.BtnGuncelleG.TabIndex = 16;
            this.BtnGuncelleG.Text = "Güncelle";
            this.BtnGuncelleG.UseVisualStyleBackColor = true;
            this.BtnGuncelleG.Click += new System.EventHandler(this.BtnGuncelleG_Click);
            // 
            // BtnSilg
            // 
            this.BtnSilg.Location = new System.Drawing.Point(441, 148);
            this.BtnSilg.Name = "BtnSilg";
            this.BtnSilg.Size = new System.Drawing.Size(143, 35);
            this.BtnSilg.TabIndex = 17;
            this.BtnSilg.Text = "Sil";
            this.BtnSilg.UseVisualStyleBackColor = true;
            this.BtnSilg.Click += new System.EventHandler(this.BtnSilg_Click);
            // 
            // FrmGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(731, 577);
            this.Controls.Add(this.BtnSilg);
            this.Controls.Add(this.BtnGuncelleG);
            this.Controls.Add(this.MskSatisG);
            this.Controls.Add(this.MskAlisG);
            this.Controls.Add(this.MskAdetG);
            this.Controls.Add(this.TxtisimG);
            this.Controls.Add(this.TxtBarkodG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGuncelle";
            this.Text = "FrmGuncelle";
            this.Load += new System.EventHandler(this.FrmGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoVeriDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DepoVeriDataSet depoVeriDataSet;
        private System.Windows.Forms.BindingSource tblÜrünBilgiBindingSource;
        private DepoVeriDataSetTableAdapters.Tbl_ÜrünBilgiTableAdapter tbl_ÜrünBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alışFiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satışFiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskSatisG;
        private System.Windows.Forms.MaskedTextBox MskAlisG;
        private System.Windows.Forms.MaskedTextBox MskAdetG;
        private System.Windows.Forms.TextBox TxtisimG;
        private System.Windows.Forms.TextBox TxtBarkodG;
        private System.Windows.Forms.Button BtnGuncelleG;
        private System.Windows.Forms.Button BtnSilg;
    }
}