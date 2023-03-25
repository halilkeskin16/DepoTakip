using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DepoTakip
{
    public partial class FrmGuncelle : Form
    {
        public FrmGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=DepoVeri;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }

        private void FrmGuncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'depoVeriDataSet.Tbl_ÜrünBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ÜrünBilgiTableAdapter.Fill(this.depoVeriDataSet.Tbl_ÜrünBilgi);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBarkodG.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtisimG.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskAdetG.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskAlisG.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskSatisG.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();   
        }

        private void BtnGuncelleG_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_ÜrünBilgi Set BarkodNo = @p1 , Ürünİsmi = @p2 , ÜrünAdet = @p3, AlışFiyatı = @p4 , SatışFiyatı = @p5 where BarkodNo = @p1",baglantı);
            komutguncelle.Parameters.AddWithValue("@p1", TxtBarkodG.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtisimG.Text);
            komutguncelle.Parameters.AddWithValue("@p3", MskAdetG.Text);
            komutguncelle.Parameters.AddWithValue("@p4", MskAlisG.Text);
            komutguncelle.Parameters.AddWithValue("@p5", MskSatisG.Text);
            komutguncelle.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi");
            


   
        }

        private void BtnSilg_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil = new SqlCommand("delete from Tbl_ÜrünBilgi where  BarkodNo=@p1", baglantı);
            komutsil.Parameters.AddWithValue("@p1", TxtBarkodG.Text);
            komutsil.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün Bilgisi Silindi");
            
        }

    }
}
