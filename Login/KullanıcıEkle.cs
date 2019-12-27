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
    public partial class KullanıcıEkle : Form
    {
        

        public KullanıcıEkle()
        {
            InitializeComponent();
        }

        private void BTNekle_Click(object sender, EventArgs e)  //butona tıkladıgımızda veritabanına kullanıcı ekler
        {
            //login işlemleri için kullanıcı ekler

           kullanici yeni = new kullanici();                //kullanıcı sınıfı olusturulur
            yeni.Ad = TXTkullnıcı.Text;                     //kullanıcı ad degiskenine textboxa yazılan deger atanır
            yeni.Sifre = Convert.ToInt32(TXTsifre.Text);    //sifre degiskenine textboxa yazılan deger atanır
            yeni.Ekle(yeni);                                //nesnenin ekle fonksiyonuna degerler gonderilir
            yeni.Listele();                                 //yeni degerler listelenir
            MessageBox.Show("Kullanıcı eklendi!");          //eklendigine dair ekranda mesaj gosteriilir
            this.Close();                                   //formu kapatır
        }
    }
}
