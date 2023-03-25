using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DepoTakip
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmEkle frm1 = new FrmEkle();
            frm1.Show();
            this.Hide();
        }

        private void BtkTakip_Click(object sender, EventArgs e)
        {
            FrmTakip frmTakip = new FrmTakip();
            frmTakip.Show();
            this.Hide();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmGuncelle frmGuncelle = new FrmGuncelle();
            frmGuncelle.Show();
            this.Hide();
        }

        private void BtnSatis_Click(object sender, EventArgs e)
        {
            FrmSatıs frmSatıs = new FrmSatıs();
            frmSatıs.Show();
            this.Hide();
        }
    }
}
