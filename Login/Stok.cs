using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    public partial class Stok : Form
    {
        ürün ü = new ürün();                        //urun classında urun nesnesi olusturulur
        public Stok()                              
        {
            InitializeComponent();
        }

        private void BTNana_Click(object sender, EventArgs e)     //butona tıkladıgında ana sayfaya döner
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
        void Listele()                                                         //Datagrid listeleme işlemi için metot. 
        {
            dataGridView1.DataSource = ü.Listele();
        }
        private void Stok_Load(object sender, EventArgs e)
        {
                                                                      //datagirdviewe listeleme yapılır ve kategoriler comboboxa eklenir

            Listele();
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection("server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Select KatgeoriAdı from TBL_kategoriler";
            SqlDataReader dr = cmd.ExecuteReader();
            comboBox1.Items.Add("Kategori Seç");
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["KatgeoriAdı"]);

            }
            comboBox1.SelectedIndex = 0;
            con.Close();
        }

        private void BTNlistele_Click(object sender, EventArgs e)
        {
                                                                       //seçilen kategori veya girilen ürün adına göre filtreleme yapılır
            string urunadi, kategori;
            kategori = comboBox1.SelectedItem.ToString();
            
            urunadi = TXTürünAdi.Text;

            SqlConnection con;
            
            con = new SqlConnection("server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI");

            DataTable tablo = new DataTable();            
            if (urunadi!="" && kategori!="")
            {
                SqlDataAdapter adtr = new SqlDataAdapter("select * from TBL_urunler where ÜrünAdı like '%" + urunadi + "%' and Kategori='"+kategori+"'", con);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }

            if (urunadi != "" && kategori == "")
            {
                SqlDataAdapter adtr = new SqlDataAdapter("select * from TBL_urunler where ÜrünAdı like '%" + urunadi + "%' ", con);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }

            if (urunadi == "" && kategori != "")
            {
                SqlDataAdapter adtr = new SqlDataAdapter("select * from TBL_urunler where Kategori='" + kategori + "' ", con);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            if (urunadi == "" && kategori == "")
            {
                SqlDataAdapter adtr = new SqlDataAdapter("select * from TBL_urunler  ", con);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
                  //yukarıdaki islemlerde ürün adı veya kategoriye göre asagıya istenilen ürünler gosterilir
               




        }

        
    }
}
