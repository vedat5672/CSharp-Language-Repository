using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaYazdırma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TextBox textSayi = new TextBox();
        Button buton = new Button();
        Label SayıLabel = new Label();
        Label SonucLabel = new Label();
        Label CevirLabel = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            // dinamik buton olusturma boyutunu konumunu  textini ekleme
            buton.Text = "Hesapla";
            buton.Width = 100;
            buton.Height = 40;
            buton.Location = new Point(225, 250);
            this.Controls.Add(buton); //forma ekler
            buton.Click += new EventHandler(buton_Click); // buton tıklanma olayı


            SayıLabel.AutoSize = true;
            SayıLabel.Text = "Sayı Giriniz";
            SayıLabel.Location = new Point(120, 155);
            this.Controls.Add(SayıLabel);

            //TextBox txt = new TextBox();
            textSayi.Name = "txtSayi";
            textSayi.Width = 150;
            textSayi.TextAlign = HorizontalAlignment.Center; // stringi ortalar

           
            textSayi.Location = new Point(200, 150);
            this.Controls.Add(textSayi);

            SonucLabel.AutoSize = true;
            SonucLabel.Text = "Sonuc";
            SonucLabel.Location = new Point(120, 190);
            this.Controls.Add(SonucLabel);

            
            CevirLabel.AutoSize = false; /// boyutu arttırtmak için
            CevirLabel.Text = "";
            CevirLabel.BackColor = Color.White;
            CevirLabel.Width = 400;
            CevirLabel.Location = new Point(200, 190);
            this.Controls.Add(CevirLabel);

        }

        private void buton_Click(object? sender, EventArgs e)
        {
          decimal para=Convert.ToDecimal(textSayi.Text.Replace('.',',')); //decimal odugu için 
            // noktayı kesirli kısım diye algılamıyor nokta yerine virgul koydum
            int index = textSayi.Text.IndexOf('.');
            if (textSayi.Text.Contains('.')) // nokta içeriyorsa 
            {
                if (index>5) // noktaya kadar kısım uzunluğu
                {
                    MessageBox.Show("en fazla bes basamak giriniz");
                }
                else  // uzunluk  5 ten kucukse yazdır
                {
                    CevirLabel.Text = Yaziya_Cevir.yaziyaCevir(para); // Static fonksiyondan döndürülen degeri labela atadım
                }


                
            }
            if (!(textSayi.Text.Contains('.')))// nokta içermiyorsa
            {
                if (textSayi.Text.Length>5) // uzunluk buyukmu 5 ten
                {
                    MessageBox.Show("en fazla bes basamak giriniz"); // Mesaj döndürür Arayüze
                   
                }
                else
                {
                    CevirLabel.Text = Yaziya_Cevir.yaziyaCevir(para); // Static fonksiyondan döndürülen degeri labela atadım
                }



            }
           
            


        }
        public static class Yaziya_Cevir
        {
            public static string yaziyaCevir(decimal para)
            {
                string spara = para.ToString("F2").Replace(',','.');
               
                //  Replace('.',',')  ondalık ayracının . olma durumu için  virgülü nokta yapar 

                string türkLira = spara.Substring(0, spara.IndexOf('.'));
                // noktadan önceki rakamlar 0 .indexten noktanın indexsine kadar  

                string kurus = spara.Substring(spara.IndexOf('.') + 1, 2); // noktadan sonrasına kurus deddim
                string yazi = "";
                // Basamakları diziye atalım
                string[] birler = { "", "BİR ", "İKİ ", "ÜÇ ", "DÖRT ", "BEŞ ", "ALTI ", "YEDİ ", "SEKİZ ", "DOKUZ " };
                string[] onlar = { "", "ON ", "YİRMİ ", "OTUZ ", "KIRK ", "ELLİ ", "ALTMIŞ ", "YETMİŞ ", "SEKSEN ", "DOKSAN " };
                string[] binler = { "KATRİLYON ", "TRİLYON ", "MİLYAR ", "MİLYON ", "BİN ", "" };
                

                int grupSayisi = 6;
                // 3 erli gruplara ayırdım ona göre yaptım grup sayısı her 3 rakam için 1 artar
                //Sayıdaki 3'lü grup sayısı. Katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)                       
                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.    


                 türkLira = türkLira.PadLeft(grupSayisi * 3, '0');   //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.  



                string grupDeğeriAlma;
                for (int i = 0; i < grupSayisi * 3; i += 3)            //sayı 3'erli gruplar halinde ele alınıyor. 
                {
                    grupDeğeriAlma = "";
                    string s = türkLira.Substring(i, 1);
                    if (s != "0")
                        grupDeğeriAlma += birler[Convert.ToInt32(türkLira.Substring(i, 1))] + "YÜZ"; //yüzler            
                    if (grupDeğeriAlma == "BİRYÜZ") //biryüz düzeltiliyor.         
                        grupDeğeriAlma = "YÜZ";
                    grupDeğeriAlma += onlar[Convert.ToInt32(türkLira.Substring(i + 1, 1))]; //onlar  
                    grupDeğeriAlma += birler[Convert.ToInt32(türkLira.Substring(i + 2, 1))]; //birler    
                    if (grupDeğeriAlma != "") //binler    
                        grupDeğeriAlma += binler[i/3];
                    if (grupDeğeriAlma == "BİRBİN") //birbin düzeltiliyor.         
                        grupDeğeriAlma = "";
                    yazi += grupDeğeriAlma;
                }

                // VİRGÜLDEN SONRA İKİ BASAMAK
                if (kurus!="00") // kurus 00 esit degilse gir içeri 
                {
                    if (kurus.Substring(0, 1) != "0") //kuruş onlar   0 esit degilse   
                    {
                     

                        yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))]; 
                    }
                    if (kurus.Substring(1, 1) != "0") //kuruş birler   0 esit degilse 
                    {
                        yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];
                        
                    }
                    yazi += "KURUS "; 

                }
             
                yazi = yazi.Replace("YÜZ", "YÜZ ").Replace("BİN", "BİN "); // düzeltmek için 
                return yazi;
            }
        }
    }
}

