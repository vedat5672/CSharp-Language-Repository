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
 
    public partial class form1 : Form
    {
        FormKayıt formKayıt=new FormKayıt();
        FormMagaza formMagaza=new FormMagaza();
        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=GiyimMagazası;Trusted_Connection=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlDataReader dr;
      
        string user = "vedat56";
        string password = "vedat56";
        public form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formKayıt.Show();
            this.Hide();
         
            
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Random rastgele = new Random();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            string uret = "";
            for (int i = 0; i < 6; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            string sorgu = "SELECT * FROM Musteris where KullaniciIsmi=@user AND Sifre=@pass";
            string sorgu2 = "Insert Into Giris(SessionId,KullaniciIsmi,Sifre,GirisTarih) values (@uret,@KullaniciIsmi,@pass,@tarih)";
            string sorgu3 = "SELECT Isim FROM Musteris where KullaniciIsmi=@user";
            cmd = new SqlCommand(sorgu, connection);
            cmd2 = new SqlCommand(sorgu3, connection);
            cmd1 = new SqlCommand(sorgu2, connection);
            cmd.Parameters.AddWithValue("@user", usertxt.Text);
            cmd.Parameters.AddWithValue("@pass", passwordtxt.Text);
            cmd2.Parameters.AddWithValue("@user", usertxt.Text);
            cmd2.Parameters.AddWithValue("@pass", passwordtxt.Text);



            connection.Open();
           
            cmd1.Parameters.AddWithValue("@uret", uret);
            cmd1.Parameters.AddWithValue("@KullaniciIsmi", usertxt.Text);
            cmd1.Parameters.AddWithValue("@pass", passwordtxt.Text);
            cmd1.Parameters.AddWithValue("@tarih", String.Format("{0:f}", dt));
         
            cmd1.ExecuteNonQuery();
            formMagaza.kullanıcıIsmilabael.Text= cmd2.ExecuteScalar().ToString();
            dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız. ");
                 
                formMagaza.Show();
                this.Hide();
            }
   
            
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            
            connection.Close();
        }
    }
}
