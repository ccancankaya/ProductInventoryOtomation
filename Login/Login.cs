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

namespace Login
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void TXTuser_Click(object sender, EventArgs e)
        {
            TXTuser.Text = "";
        }                                                                  //buradaki click işlemleri textboxa tıklanınca içini temizler

        private void TXTpass_Click(object sender, EventArgs e)
        {
            TXTpass.Text = "";
        }

        private void BTNcikis_Click(object sender, EventArgs e)     //butona tıklandıgında programı kapatır
        {
            this.Close();
        }

        private void BTNgiris_Click(object sender, EventArgs e)
        {
            //Giriş butonuna basınca veritabanından aldığı kullanıcı adı ve şifreyi karşılaştırarak giriş yapar
            try
            {
                SqlConnection con;
                con = new SqlConnection("server=.; Initial Catalog=Otomasyon;Integrated Security=SSPI"); //veritabanına bağlantı sağlar
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM TBL_kullanici WHERE KullaniciAdi='" + TXTuser.Text + "' AND Sifre='" + TXTpass.Text + "'", con);
                DataTable dt = new DataTable();        //aldıgı degerleri veritablosuna aktarır 
                sda.Fill(dt);                          // SQL data adoptörünü data table ile doldurur
                if (dt.Rows[0][0].ToString() == "1")    // eger satırdaki bilgiler dogru ise formu acar
                {
                    AnaSayfa ana = new AnaSayfa();    //anasayfa formu acılır
                    ana.Show();
                    this.Hide();        //giris formunu gizler ve anasayfayı acar

                }
                else                                         //eger satırdaki bilgiler yanlıs ise kullanıcı adı veya sifre yanlıs mesajını gösterir
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre yanlış!");   
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Alanlar boş bırakılamaz!!");      // eger alanlar bos ise alanlar bos bırakılmaz mesajını gösterir
            }




        }


    }
}
