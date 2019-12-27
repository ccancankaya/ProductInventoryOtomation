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
    public partial class SatışYap : Form
    {
        public SatışYap()
        {
            InitializeComponent();
        }

        private void BTNiptal_Click(object sender, EventArgs e)     //butona tıklandıgında satısyap formunu kapatır
        {
            this.Close();
        }

        private void BTNsat_Click(object sender, EventArgs e)     //butonsata tıkladıgında ürün satısı yapar stoktan düser
        {
            

            ürün ü = new ürün();                                  //urun classında nesne olusturulur

            int adet =  ü.adetAl(TXTürün.Text)- Convert.ToInt32(TXTadet.Text);  //girilen adet kadar stoktan düser

            ü.Urunadi = TXTürün.Text;                                          //girilen degeri urun adı degiskenine atar 
           
            ü.Adet = adet;                                                     // adeti adet degiskenine atar
            ü.urunsat(ü);

            müsteri m = new müsteri();                                        //müsteri sınıfından müsteri nesnesi olusturulur

            m.firmaadi = TXTfirma.Text;                                       //girilen degeri firma adı degiskenine atar
            m.ürünadi = TXTürün.Text;                                         // girilen degeri urun adı degiskenine atar
            m.Ekle(m);                                                        //ekle fonksiyonuna girdigimiz degerleri gonderir

            
            MessageBox.Show("Satış yapıldı!");                                 //satıs yapıldı mesajını gosterir
           
            
        }
    }
}
