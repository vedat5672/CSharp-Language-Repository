/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2023 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Vedat Arslan
**				ÖĞRENCİ NUMARASI.......: b181210030
**                         DERSİN ALINDIĞI GRUP...: 2/A
****************************************************************************/

namespace SistemGuvenlikUygulaması
{
    public class SistemGuvenlikUygulaması
    {
        public static void Main() // Programın Çalıştırıldığı yer,Main içerisinde verilen bu statik sınıfın metotları kullanılarak şifrenin güvenliği test ediyor.
        {
            string? sifre;  // string değişken tanımı, şifre kullanıcıdan alınacak veri
            Console.WriteLine("sifre giriniz"); // Yazdırma islemi
            sifre = Console.ReadLine();  // kullanıcıdan string  tipi sifre değişkeni veri al

            while (sifre.Contains(" ")) // şifre boşluk içeriyormu 
            {
                Console.WriteLine("şifre hatalı"); //hata meşajı
                sifre = Console.ReadLine(); // tekrar kulanıcı girişi al
            }
            while (sifre.Length < 9) // string değişkenin uzunlugu 9 dan kücük ise içeriye gir degilse devam et. Şifre 9 ve üzeri karakter ise kabul edilebilir
            {
                Console.WriteLine("şifre minumum 9 karakterli olmalı tekrar giriniz"); //hata meşajı
                sifre = Console.ReadLine(); // tekrar kulanıcı girişi al
            }
            if (sifre.Length>=9) // string değişkenin uzunlugu 9 dan büyük eşitmi evetse içeriye gir .
            {
                if (sifre.Length==9) // şifre 9 karakterli ise 10 puan ver
                {
                    Guvenirlik.getPuan(Guvenirlik._puan + 10); // puan degerini  10 puan arttır ve oku
                    Guvenirlik.setPuan(); //döndür puanı
                }
                Guvenirlik.buyuKHarf(sifre); // kullanıcı tarafından tanımlanan string degiskeninde kac tane buyuk harf var ve Her bir büyük harf 10 puan ve 20 puandan fazla küçük harften verilemez. ve puanı döndür
                Guvenirlik.kucukHarf(sifre); 
                Guvenirlik.rakam(sifre);
                Guvenirlik.sembol(sifre); //  kullanıcı tarafından tanımlanan string degiskeninde kac tane sembol  var ve Her bir sembol 10 puandır.

                Console.WriteLine(Guvenirlik.setPuan());
                if (Guvenirlik.buyukHarfSayac<=0 || Guvenirlik.KucukHarfSayac<=0 || Guvenirlik.rakamSayac<=0 ||Guvenirlik.sembolSayac<=0) 
                    // 9 karakter ve üzeri ise büyük harf, küçük harf, rakam ve sembol sayısının
                    // hiçbiri sıfır olmamalı her hangi birinin sayısı sıfır ise şifre kabul edilemez,  değilse kabul edilebilir. 
                {
                    Console.WriteLine("şifre gecerli degil");
                    return; // programı bitir.
                }
               if (Guvenirlik.setPuan()<70) //Genel puan 70 den küçük ise şifre kabul edilemez.
                {
                    Console.WriteLine("şifre Zayıf"+ " şifre güvenlik puanınız 70 den büyük olmalı ve sizin puanınız  >   "+ Guvenirlik.setPuan()); // kullanıcı puanı hakkında bilgilendirme
                   
                }
               
              
                if (Guvenirlik.setPuan()>=70 && Guvenirlik.setPuan()<90) // Genel puan 70 ile 90 arasında ise şifre kabul edilir
                {
                    Console.WriteLine("şifre orta  puan >   " + Guvenirlik.setPuan());
                } 
                if (Guvenirlik.setPuan()>=90 && Guvenirlik.setPuan()<=100) //Genel puan 90 ile 100 şifre kabul edilir ve güçlü.
                {
                    Console.WriteLine("şifre güclü puan  >   " + Guvenirlik.setPuan()); 
                }
                if (Guvenirlik.setPuan()>100)
                {
                    Console.WriteLine("şifre çok güclü puan  >   " + Guvenirlik.setPuan());
                }
               
                
            }
          
          
        }
    }
}
