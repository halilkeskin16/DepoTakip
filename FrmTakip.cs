using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoTakip
{
    public partial class FrmTakip : Form
    {
        public FrmTakip()
        {
            InitializeComponent();
        }
        public string Barkod;
        public string İsim;
        public string SatisFiyat;
        private void FrmTakip_Load(object sender, EventArgs e)
        {
            this.tbl_ÜrünBilgiTableAdapter.Fill(this.depoVeriDataSet1.Tbl_ÜrünBilgi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu fr1 = new FrmMenu();
            fr1.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Barkod = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            İsim = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            SatisFiyat = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }
    }
}
