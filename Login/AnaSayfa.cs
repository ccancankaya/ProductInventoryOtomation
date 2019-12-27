using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        // herbir menü butonuna tıklanınca ilgili forma gitmesi için kodlar aşağıdadır

        private void simpleButton1_Click(object sender, EventArgs e) //butona tıkladıgınızda urunler formu acılır
        {
            Ürünler ürün = new Ürünler();
            ürün.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e) // butona tıkladıgınızda stoklar formu acılır
        {
            Stok stok = new Stok();
            stok.Show();
            this.Hide();  // bulundugumuz formu gizler

        }

        private void simpleButton3_Click(object sender, EventArgs e) // butona tıkladıgınızda musteriler formu acılır
        {
            Müşteriler müsteri = new Müşteriler();
            müsteri.Show();
            this.Hide();   // bulundugumuz formu gizler
        }

        private void simpleButton4_Click(object sender, EventArgs e) //butona tıkladıgınızda ayarlar formu acılır
        {
            Ayarlar ayar = new Ayarlar();
            ayar.Show();
            this.Hide();     // bulundugumuz formu gizler
        }

        private void BTNsatis_Click(object sender, EventArgs e) // butona tıkladıgınızda satıslar formu acılır
        {
            SatışYap satis = new SatışYap();
            satis.Show();   // bulundugumuz formu gizler
        }

        private void BTNcikis_Click(object sender, EventArgs e) //butona tıkladıgınızda uygulama tamamen kapanır
        {
            this.Close();
            Application.Exit(); //tamamen uygulamayı kapatır
        }
    }
}
