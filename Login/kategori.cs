using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Login
{
    class kategori:baglanti  //baglanti classından kalıtım alınır
    {
        int KategoriID;      //kategori id degiskeni tanımlanır

        public int kategoriıd   //kategori id propertiesi tanımlanır
        {
            get { return KategoriID; }   //kategori idi alır 
            set { KategoriID = value; }  // kategori id için girilen veriyi kategori id'ye aktarır
        }
        string KatgeoriAdı;          //kategori adı degiskeni tanımlanır
        public string kategoriadi    // kategori adı propertiesi tanımlanır
        {
            get { return KatgeoriAdı; }   //kategori adı alır
            set { KatgeoriAdı = value; }   // kategori adı için girilen veriyi kategori adına aktarır
        }

      
        //public void ekle(kategori k)    // kategori ekleme islemi
        //{
        //    try
        //    {
        //        cmd.CommandText = "Insert Into TBL_kategoriler (KatgeoriAdı) Values ('" + k.kategoriadi + "')";
        //        cmd.CommandType = CommandType.Text;
        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    finally
        //    {
        //        if (con != null)
        //        {
        //            con.Close();
        //        }
        //    }
        //}



    }
}
