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
    public partial class Müşteriler : Form
    {
        müsteri m = new müsteri();                                       //müsteri sınıfından nesne olusturulur


        public Müşteriler()
        {
            InitializeComponent();
        }

        private void BTNana_Click(object sender, EventArgs e)        //butona tıklandıgında anasayfa formunu acar
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
        void Listele()                                                   //Datagrid müsteri listeleme işlemi için metot. 
        {
            dataGridView1.DataSource = m.Listele();
        }
        private void Müşteriler_Load(object sender, EventArgs e)
        {
                                                                          //form yüklenince gridviewe listeleme yapar
            Listele();
        }

        private void BTNekle_Click(object sender, EventArgs e)
        {
                                                                                    // butona tıklandıgında firma ekler
            m.firmaadi = TXTfirma.Text;
            m.Ekle(m);
            Listele();
            MessageBox.Show("Müşteri eklendi!");

        }

        private void BTNsil_Click(object sender, EventArgs e)
        {
                                                                                    //butona tıklandıgında seçilen firmayı siler
            müsteri silinecek = new müsteri();
            silinecek = (müsteri)dataGridView1.CurrentRow.DataBoundItem;
            m.Sil(silinecek);
            MessageBox.Show("Firma silindi!");
            Listele();
        }

        private void BTNbul_Click(object sender, EventArgs e)
        {
                                                                                  //buton bula tıklandıgında girilen firma adına göre filtreleme yapar
            dataGridView1.Columns.Clear();

            SqlConnection con;
            string musteriadi = TXTfirma.Text;                   

            con = new SqlConnection("server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI");  //veritabanına baglanır

            DataTable tablo = new DataTable();                                                       //tablo olusturulur
            SqlDataAdapter adtr = new SqlDataAdapter("select * from TBL_musteriler where FirmaAdı = '" + musteriadi + "'", con); //data adaptör olusturulur
            dataGridView1.DataSource = tablo;                                                      //datagridviewdeki bilgiyi tablonun icine yazar

        }


    }
}
