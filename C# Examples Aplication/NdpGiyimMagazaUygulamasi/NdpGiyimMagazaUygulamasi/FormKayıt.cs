using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpGiyimMagazaUygulamasi
{
    public partial class FormKayıt : Form
    {
        
        static string conString = "Server=(localdb)\\MSSQLLocalDB;Database=GiyimMagazası;Trusted_Connection=True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.
        public FormKayıt()
        {
            InitializeComponent();
        }

        private void FormKayıt_Load(object sender, EventArgs e)
        {

        }

        private void Kayıtbutton_Click(object sender, EventArgs e)
        {
            if (SifreTekrartextBox.Text==SifretextBox.Text)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                    string kayit = "Insert Into Musteris(Isim,KullaniciIsmi,Sifre) values (@Isim,@KullaniciIsmi,@Sifre)";
                    // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                    komut.Parameters.AddWithValue("@Isim", AdtextBox1.Text);
                    komut.Parameters.AddWithValue("@KullaniciIsmi", KullanıcıTextBox.Text);
                    komut.Parameters.AddWithValue("@Sifre", SifretextBox.Text);

                    //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                    komut.ExecuteNonQuery();
                    //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                    baglanti.Close();
                    MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("sifreler uyusmuyor");
            }

        }

        private void FormKayıt_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1 form1 = new form1();
            form1.Show();
            this.Hide();
        }
    }
    
}
