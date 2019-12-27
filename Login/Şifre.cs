using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Login
{
    public partial class Şifre : Form
    {
        public Şifre()
        {
            InitializeComponent();
        }

        private void Şifre_Load(object sender, EventArgs e)
        {

                                                                        //form yüklendiğinde combobox ve datagridview lstelemesi yapılır
            
            kullanici yeni = new kullanici();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI";


            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT KullaniciAdi FROM TBL_kullanici";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["KullaniciAdi"]);

            }
            baglanti.Close();

        }

        private void BTNgüncelle_Click(object sender, EventArgs e)
        {
                                                                             //seçilen kullanıcının şifresi güncellenir

            kullanici guncellenecek = new kullanici();
            guncellenecek.Ad = comboBox1.Text;
            guncellenecek.Sifre = Convert.ToInt32(TXTsifre.Text);
            guncellenecek.guncelle(guncellenecek);
            MessageBox.Show("Şifre güncellendi!");
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                                                                                 //comboboxta seçilen kullanıcının şifresi textboxa aktarılır

            kullanici guncellenecek = new kullanici();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI";


            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select Sifre from TBL_kullanici where KullaniciAdi Like '%" + comboBox1.SelectedItem + "%'";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

           
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                TXTsifre.Text = dr["Sifre"].ToString();
            }

        }
    }
}
