using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;                //veritabanı bağlantısı için
using System.Data;

namespace Login
{
    class ürün : baglanti                            //bağlantı kurmak için bağlantı classından kaltım yapılmıştır
    {
        int urunkodu;

        public int Urunkodu
        {
            get { return urunkodu; }
            set { urunkodu = value; }
        }

        string urunadi;
        public string Urunadi
        {
            get { return urunadi; }
            set { urunadi = value; }
        }

        string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }                                           //özellikler tanımlanmıştır kapsülleme yapılmıştır

        string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        string kategori;
        public string Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }

        int adet;
        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }
        float birimfiyat;
        public float Birimfiyat
        {
            get { return birimfiyat; }
            set { birimfiyat = value; }
        }
        float satisfiyat;
        public float Satisfiyat
        {
            get { return satisfiyat; }
            set { satisfiyat = value; }
        }

        public ürün()
        {
            baglan();
        }



        public List<ürün> Listele()
        {
                                                                           //datagridview listeleme
                                                                           //veritabanından alınan verileri ürünkodu, ürünadı,marka, model,ürün kategorisi, adet, birim ve satıs fiyatına göre listeleme yapar
            try
            {
                List<ürün> ürünliste = new List<ürün>();
                cmd.CommandText = "Select *From TBL_urunler";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ürün ü = new ürün();
                    ü.Urunkodu = Convert.ToInt32(reader[0].ToString());
                    ü.Urunadi = reader[1].ToString();
                    ü.Marka = reader[2].ToString();
                    ü.Model = reader[3].ToString();
                    ü.Kategori = reader[4].ToString();
                    ü.Adet = Convert.ToInt32(reader[5].ToString());
                    ü.Birimfiyat = Convert.ToSingle(reader[6].ToString());
                    ü.Satisfiyat = Convert.ToSingle(reader[7].ToString());


                    ürünliste.Add(ü);
                }

                return ürünliste;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void Ekle(ürün ü)
        {
                                                                             //ürün ekleme
            try
            {
                cmd.CommandText = "Insert Into TBL_urunler (ÜrünKodu,ÜrünAdı,Marka,Model,Kategori,Adet,BirimFiyat,SatisFiyat) Values ('" + ü.Urunkodu + "','" + ü.Urunadi + "','" + ü.Marka + "','" + ü.Model + "','" + ü.Kategori + "','" + ü.Adet + "','" + ü.Birimfiyat + "','" + ü.Satisfiyat + "')";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }

        }

        public void Sil(ürün ü)
        {
                                                                                      //ürün silme
            try
            {
                cmd.CommandText = "Delete From TBL_urunler Where ÜrünKodu=" + ü.Urunkodu + "";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void guncelle(ürün ü)
        {
                                                                    //ürün güncelleme
            try
            {
                cmd.CommandText = "Update TBL_urunler Set ÜrünKodu=" + ü.Urunkodu + ", ÜrünAdı='" + ü.Urunadi + "', Marka='" + ü.Marka + "' ,Model='" + ü.Model + "' ,Kategori='" + ü.Kategori + "' ,Adet=" + ü.Adet + " ,BirimFiyat=" + ü.Birimfiyat + " ,SatisFiyat=" + ü.Satisfiyat + " where ÜrünKodu='" + ü.Urunkodu + "'";
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void urunsat(ürün ü)
        {
                                                                       //ürün satma

            try
            {

                cmd.CommandText = "UPDATE TBL_urunler SET Adet=" + ü.Adet + " where ÜrünAdı='" + ü.Urunadi + "'";

                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public int adetAl(string urunadı)
        {
                                                           //stoktan satılan ürün kadar adet düşmek için adet bilgisini alır
            try
            {

                ürün ü = new ürün();
                cmd.CommandText = "Select Adet from TBL_urunler Where ÜrünAdı='" + urunadı + "'";
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();


                int a = Convert.ToInt32(dr["Adet"]);
                return a;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }



    }



}

