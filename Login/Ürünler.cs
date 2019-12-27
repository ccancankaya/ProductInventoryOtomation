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
    public partial class Ürünler : Form 
    {
        ürün ü = new ürün();                           //ürün sınıfından nesne oluşturulur.


        public Ürünler()
        {
            InitializeComponent();
        }
        void Listele()                                         //Datagrid listeleme işlemi için metot. 
        {
            dataGridView1.DataSource = ü.Listele();
        }
        private void BTNana_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            KategoriEkle ekle = new KategoriEkle();
            ekle.Show();
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
                                                         // form yüklenince datagrid tablosunun içini doldurur ve kategoriler comboboxının içini doldurur
            Listele();
            SqlConnection con;
            SqlCommand cmd;
            con = new SqlConnection("server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "Select KatgeoriAdı from TBL_kategoriler";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ComboKategori.Items.Add(dr["KatgeoriAdı"]);

            }
            con.Close();
        }

        private void BTNekle_Click(object sender, EventArgs e)
        {
                                                                    //ürün ekleme yapar

            ü.Urunkodu = Convert.ToInt32(TXTkod.Text);
            ü.Urunadi = TXTad.Text;
            ü.Marka = TXTmrk.Text;
            ü.Model = TXTmdl.Text;
            ü.Kategori = ComboKategori.Text;
            ü.Adet = Convert.ToInt32(TXTadt.Text);
            ü.Birimfiyat = Convert.ToSingle(TXTbirim.Text);
            ü.Satisfiyat = Convert.ToSingle(TXTsatis.Text);
            ü.Ekle(ü);
            MessageBox.Show("Ürün eklendi!");
            Listele();
        }

        private void BTNsil_Click(object sender, EventArgs e)
        {
                                                            //data gridviewden seçilen ürünü siler

            ürün silinecek = new ürün();
            silinecek = (ürün)dataGridView1.CurrentRow.DataBoundItem;
            ü.Sil(silinecek);
            MessageBox.Show("Ürün silindi!");
            Listele();
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                                                                     //datagridviewde hücreye tıklanınca texboxlara yazar

            TXTkod.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTmrk.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTmdl.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ComboKategori.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXTadt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXTbirim.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TXTsatis.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void BTNguncelle_Click(object sender, EventArgs e)
        {
                                                                                //seçilen ürünü günceller

            ürün guncellenecek = new ürün();
            guncellenecek= (ürün)dataGridView1.CurrentRow.DataBoundItem;
            guncellenecek.Urunkodu = Convert.ToInt32(TXTkod.Text);
            guncellenecek.Urunadi = TXTad.Text;
            guncellenecek.Marka = TXTmrk.Text;
            guncellenecek.Model = TXTmdl.Text;
            guncellenecek.Kategori = ComboKategori.Text;
            guncellenecek.Adet = Convert.ToInt32(TXTadt.Text);
            guncellenecek.Birimfiyat= Convert.ToSingle(TXTbirim.Text);
            guncellenecek.Satisfiyat= Convert.ToSingle(TXTsatis.Text);

            guncellenecek.guncelle(guncellenecek);
            MessageBox.Show("Ürün güncellendi!");
            Listele();
        }
    }
}
