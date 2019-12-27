using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class müsteri : IKisi                            //kişi interfaceinden kalıtım alınmıştır
    {
       
        public int Id { get; set; }                  //id propertiesi tanımlanır    
        

        string FirmaAdı;                            //firma adı degiskeni tanımlanır

        public string firmaadi                      //firma adı propertiesi tanımlanır
        {
            get { return FirmaAdı; }               //firma adı degerini alır
            set { FirmaAdı = value; }              //firma adı degerine atar
        }

        string UrunAdı;                           //urun adı degiskeni tanımlanır

        public string ürünadi                     //urun adı propertiesi tanımlanır
        {
            get { return UrunAdı; }              //urun adı degerini alır
            set { UrunAdı = value; }             //urun adı degerine atar
        }

        //bağlantı nesnesi oluşturulur
        baglanti b = new baglanti();

        public müsteri()
        {
            b.baglan();                     //veritabanına baglanti saglar
        }

        public List<müsteri> Listele()
        {
            //datagridview listeleme
            try
            {
                List<müsteri> müsteriliste = new List<müsteri>();   // müsteri liste generic classı olusturulur 
                b.cmd.CommandText = "Select *From TBL_musteriler";  //SQL sorgusu cekilir
                b.cmd.CommandType = CommandType.Text;               //sorgu tipini tanımlarız
                b.con.Open();                                       //baglanti acilir
                SqlDataReader reader = b.cmd.ExecuteReader();       //datareader nesnesi olusturulur ve sorgudan gelen degerleri okuyucunun icine atmayı saglar
                while (reader.Read())
                {
                    müsteri m = new müsteri();                          //müsteri sınıfında nesne olusturulur
                    m.Id = Convert.ToInt32(reader[0].ToString());      //degiskenlerin icine okunan degerler atanır
                    m.FirmaAdı = reader[1].ToString();                 //degiskenlerin icine okunan degerler atanır
                    m.UrunAdı = reader[2].ToString();                  //degiskenlerin icine okunan degerler atanır


                    müsteriliste.Add(m);                               //generic sınıfına gelen degerleri gönderir
                }

                return müsteriliste;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (b.con != null)                                   //baglanti boştan farklı ise baglantiyi kapatır
                {
                    b.con.Close();
                }
            }
        }


        public void Ekle(müsteri m)                             //müsteri ekleme fonksiyonu
        {
            //firma ekler
            try
            {
                b.cmd.CommandText = "Insert Into TBL_musteriler (FirmaAdı,ÜrünAdı) Values ('" +m.firmaadi + "','" + m.ürünadi + "')";   //veritabanına ekleme yapan sorgudur
                b.cmd.CommandType = CommandType.Text;
                b.con.Open();
                b.cmd.ExecuteNonQuery();          //komutu calıstırır
            }
            catch (Exception)
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
        public void Sil(müsteri m)
        {
            //seçileni siler
            try
            {
                b.cmd.CommandText = "Delete From TBL_musteriler Where FirmaID=" + m.Id + "";   //veritabanından müsteri silmek icin SQL sorgusu
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
                if (b.con != null)        //baglanti boştan farklı ise baglantiyi kapatır
                {
                    b.con.Close();
                }
            }
        }

        public void Bul(müsteri m)
        {
                                                            
            try
            {
                b.cmd.CommandText = "select * form TBL_musteriler where FirmaAdı=" + m.firmaadi + "";     //girilen firma ismine göre firmayı bulur
                b.cmd.CommandType = CommandType.Text;
                b.con.Open();
                b.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (b.con != null)          //baglanti boştan farklı ise baglantiyi kapatır
                {
                    b.con.Close();
                }
            }
        }















    }
}
