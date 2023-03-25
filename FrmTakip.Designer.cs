namespace DepoTakip
{
    partial class FrmTakip
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünİsmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ürünAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alışFiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satışFiyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblÜrünBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.depoVeriDataSet1 = new DepoTakip.DepoVeriDataSet1();
            this.tbl_ÜrünBilgiTableAdapter = new DepoTakip.DepoVeriDataSet1TableAdapters.Tbl_ÜrünBilgiTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoVeriDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodNoDataGridViewTextBoxColumn,
            this.ürünİsmiDataGridViewTextBoxColumn,
            this.ürünAdetDataGridViewTextBoxColumn,
            this.alışFiyatıDataGridViewTextBoxColumn,
            this.satışFiyatıDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblÜrünBilgiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(888, 400);
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
            this.tblÜrünBilgiBindingSource.DataSource = this.depoVeriDataSet1;
            // 
            // depoVeriDataSet1
            // 
            this.depoVeriDataSet1.DataSetName = "DepoVeriDataSet1";
            this.depoVeriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ÜrünBilgiTableAdapter
            // 
            this.tbl_ÜrünBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stok Takip";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(777, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTakip";
            this.Text = "FrmTakip";
            this.Load += new System.EventHandler(this.FrmTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblÜrünBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depoVeriDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DepoVeriDataSet1 depoVeriDataSet1;
        private System.Windows.Forms.BindingSource tblÜrünBilgiBindingSource;
        private DepoVeriDataSet1TableAdapters.Tbl_ÜrünBilgiTableAdapter tbl_ÜrünBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünİsmiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ürünAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alışFiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satışFiyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}