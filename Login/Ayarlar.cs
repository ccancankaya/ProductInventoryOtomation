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
    public partial class Ayarlar : Form
    {

        kullanici k = new kullanici();    //kullanıcı sınıfından nesne türetilir
        public Ayarlar()
        {
            InitializeComponent();   
        }

        void Listele() //Datagrid listeleme işlemi için metot 
        {
            dataGridView1.DataSource = k.Listele();
        }

        private void simpleButton4_Click(object sender, EventArgs e) //butona tıkladıgınızda ana sayfa formuna geri doner
            
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            Hide();
        }

        private void Ayarlar_Load(object sender, EventArgs e) //form yuklendiğinde datagrid'e listeleme yapar
        {
            Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)   //butona tıkladıgınızda kullanıcı ekle formu acılır
        {
            KullanıcıEkle k = new KullanıcıEkle();
            k.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //yanlıslıkla ekledim
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e) //butona tıkladıgınızda datagrid'te tıkladıgınız kullancıyı siler
        {
            kullanici silinecek = new kullanici();
            silinecek = (kullanici)dataGridView1.CurrentRow.DataBoundItem; //datagrid'de üstüne tıkladıgınız satırı secer o satırı sil fonksiyonuna gonderir
       
            k.Sil(silinecek);
            Listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e) //butona tıkladıgınızda sifre degistirilmesi icin sifre formunu acar
        {
            Şifre ş = new Şifre();
            ş.Show();
        }
    }
}
