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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;


namespace DepoTakip
{
    public partial class FrmSatıs : Form
    {
        public FrmSatıs()
        {
            InitializeComponent();
        }
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-GFGQKD6\\SQLEXPRESS;Initial Catalog=DepoVeri;Integrated Security=True");

        private void FrmSatıs_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo f in fico)
            {
                comboBox1.Items.Add(f.Name);
                comboBox1.SelectedIndex = 0;
            }
         
        }

        private void BtnBaslatS_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
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
                    textBox1.Text = sonuc.ToString();
                    baglantı.Open();
                    SqlCommand komutgetir1 = new SqlCommand("select Ürünİsmi from Tbl_ÜrünBilgi where BarkodNo = @p1", baglantı);
                    komutgetir1.Parameters.AddWithValue("@p1", textBox1.Text);
                    SqlDataReader read = komutgetir1.ExecuteReader();
                    while (read.Read())
                    {
                        textBox2.Text = read["Ürünİsmi"].ToString();

                    }
                    baglantı.Close();
                    baglantı.Open();
                    SqlCommand komutgetir2 = new SqlCommand("select SatışFiyatı from Tbl_ÜrünBilgi where BarkodNo = @p2", baglantı);
                    komutgetir2.Parameters.AddWithValue("@p2", textBox1.Text);
                    SqlDataReader read2 = komutgetir2.ExecuteReader();
                    while (read2.Read())
                    {
                        textBox3.Text = read2["SatışFiyatı"].ToString();

                    }
                    baglantı.Close();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
            this.Hide();
        }
        int toplam = 0;
        int AdisyonToplam = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat = Convert.ToInt16(textBox3.Text);
            int adet = Convert.ToInt16(maskedTextBox1.Text);
            toplam = adet * fiyat;
            textBox4.Text = toplam.ToString();
            LsbAdisyon.Items.Add(textBox2.Text + " " + toplam + "₺");
            AdisyonToplam += toplam;
            textBox5.Text = AdisyonToplam.ToString();
            baglantı.Open();
            SqlCommand komutgüncelle2 = new SqlCommand("update Tbl_ÜrünBilgi set ÜrünAdet = ÜrünAdet - @p1 where BarkodNo = @p2",baglantı);
            komutgüncelle2.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komutgüncelle2.Parameters.AddWithValue("@p2", textBox1.Text);
            komutgüncelle2.ExecuteNonQuery();
            baglantı.Close();
        }

        private void BtnBitis_Click(object sender, EventArgs e)
        {
            LsbAdisyon.Items.Clear();
            textBox5.Clear();
        }

        private void BtnStokGor_Click(object sender, EventArgs e)
        {
            FrmTakip frmTakip = new FrmTakip();
            frmTakip.Show();
            frmTakip.Barkod = textBox1.Text;
            frmTakip.İsim = textBox2.Text;
            frmTakip.SatisFiyat = textBox3.Text;
        }
    }
}
