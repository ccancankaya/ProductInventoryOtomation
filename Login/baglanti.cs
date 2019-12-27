using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    class baglanti //veri tabani ile baglantiyi saglayan sınıftır
        
    {
        public SqlConnection con;  //baglanti degiskeni tanımlanır
        public SqlCommand cmd;     //komut degiskeni tanımlanır

        public void baglan()       // baglan foksiyonumuz
        {
            con = new SqlConnection("server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI"); //baglanti sorgusu

            cmd = new SqlCommand();      //komutu tanımlarız
            cmd.Connection = con;        //baglanti tanımlarız
        }
    }
}
