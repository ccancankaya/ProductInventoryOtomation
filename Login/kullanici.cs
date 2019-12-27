using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Login
{
    class kullanici:IKisi   //kisi interface'inden kalıtım alır
    {
        int id;             // id degiskeni tanımlanır
        public int Id       // id propertiesi tanımlanır
        {
            get { return id; }    // id alınır
            set { id = value; }   // girilen deger id degiskenine atanır
        }


        string adi;       // ad degiskeni tanımlanır
        public string Ad   // ad propertiesi tanımlanır
        {
            get { return adi; }   //ad alınır
            set { adi = value; }  // girilen deger ad degiskenine atanır
        }


        int sifre;            //sifre degiskeni tanımlanır
        public int Sifre      // sifre propertiesi tanımlanır
        {
            get { return sifre; }   // sifre alınır
            set { sifre = value; }  //girilen deger sifre degiskenine atanır
        }

        baglanti b = new baglanti();    //baglanti classından nesne türetir

        public kullanici()           // kullanıcı formu acılınca baglantiyi saglar
        {
            b.baglan();
        }

       


        public List<kullanici> Listele()     // veri tabanından alınan bilgileri listemek icin 
        {

            try
            {
                List<kullanici> kullaniciListe = new List<kullanici>();  //kullanıcı generic sınıfı olusturulur
                b.cmd.CommandText = "Select *From TBL_kullanici";        //SQL sorgusu cekilir
                b.cmd.CommandType = CommandType.Text;                    //sorgu tipini tanımlarız
                b.con.Open();                                           //baglanti acilir
                SqlDataReader reader = b.cmd.ExecuteReader();           //datareader nesnesi olusturulur ve sorgudan gelen degerleri okuyucunun icine atmayı saglar
                while (reader.Read())
                {
                    kullanici k = new kullanici();                           // kullanici sınıfında nesne olusturulur
                    k.Id = Convert.ToInt32(reader[0].ToString());            //degiskenlerin icine okunan degerler atanır
                    k.Ad = reader[1].ToString();                             //degiskenlerin icine okunan degerler atanır
                    k.Sifre = Convert.ToInt32(reader[2].ToString());          //degiskenlerin icine okunan degerler atanır

                    kullaniciListe.Add(k);                           //generic sınıfına gelen degerleri gönderir
                }

                return kullaniciListe;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (b.con != null)         //baglanti boştan farklı ise baglantiyi kapatır
                {
                    b.con.Close();        
                }
            }
        }


        public void Ekle(kullanici k)      //kullanıcı ekleme fonksiyonu
        {
            try
            {
                b.cmd.CommandText = "Insert Into TBL_kullanici (KullaniciAdi,Sifre) Values ('" + k.Ad + "','" + k.Sifre + "')"; //veritabanına ekleme yapan sorgudur
                b.cmd.CommandType = CommandType.Text;
                b.con.Open();              
                b.cmd.ExecuteNonQuery();        //komutu calıstırır
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (b.con != null)       //baglanti bostan farklı ise baglantiyi kapatır
                {
                    b.con.Close();
                }
            }

        }
        public void Sil(kullanici k)    //kullanici silme fonksiyonumuz
        {
            try
            {
                b.cmd.CommandText = "Delete From TBL_kullanici Where KullaniciID=" + k.Id + "";  //veritabanında silme yapan sorgu
                b.cmd.CommandType = CommandType.Text;
                b.con.Open();
                b.cmd.ExecuteNonQuery();     //komutu calistirir
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (b.con != null)     //baglanti bostan farklı ise baglantiyi kapatır
                {
                    b.con.Close();
                }
            }
        }

        public void guncelle(kullanici k)     //kullanıcı güncelleme fonksiyonumuz
        {
            try
            {
                b.cmd.CommandText = "Update TBL_kullanici set Sifre="+k.Sifre+ " where KullaniciAdi='" + k.Ad+ "'"; //veritabanında güncelleme yapan sorgu
                b.cmd.CommandType = CommandType.Text;
                b.con.Open();
                b.cmd.ExecuteNonQuery();       //komutu calistirir

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (b.con != null)      //baglanti bostan farklı ise baglantiyi kapatır
                {
                    b.con.Close();
                }
            }
        }



    }
}
