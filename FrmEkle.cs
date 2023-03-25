using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient;

namespace DepoTakip
{
    public partial class FrmEkle : Form
    {
        public FrmEkle()
        {
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=DepoVeri;Integrated Security=True");

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmMenu frm1 = new FrmMenu();
            frm1.Show();
            this.Hide();
        }

        private void FrmEkle_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fico[comboBox1.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader brd = new BarcodeReader();
                Result sonuc = brd.Decode((Bitmap)pictureBox1.Image);
                if (sonuc != null)
                {
                    TxtBarkod.Text = sonuc.ToString();

                }
            }


            
        }

        private void BtnEkle1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("insert into Tbl_ÜrünBilgi(BarkodNo,Ürünİsmi,ÜrünAdet,AlışFiyatı,SatışFiyatı) values (@p1,@p2,@p3,@p4,@p5)", baglantı);
            komut1.Parameters.AddWithValue("@p1", TxtBarkod.Text);
            komut1.Parameters.AddWithValue("@p2", Txtisim.Text);
            komut1.Parameters.AddWithValue("@p3", MskAdet.Text);
            komut1.Parameters.AddWithValue("@p4", MskAlis.Text);
            komut1.Parameters.AddWithValue("@p5", MskSatis.Text);
            komut1.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Ürün Eklendi");
        }
    }
}
