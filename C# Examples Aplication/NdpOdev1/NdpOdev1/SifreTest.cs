using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpOdev1
{
    public static class SifreTest    // İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir.
                                     // Metotlar ve alanlar static olarak tanımlanmalıdır.
                                     // Static olarak tanımlanan bir metoda program çalıştığı sürece erişilir, böylece sadece bir metot ile birden çok nesne çağırabiliriz. 
    {
        public static int _puan;                     
        public static int sayacBuyukHarf = 0;
        public static int sayacKucukHarf = 0;
        public static int sayacRakam = 0;
        public static int sayacSembol = 0;
        public static void getPuanAl(int puan)      
            // Burda puan degeri okutuyorum
        {

            _puan = puan;
        }
        public static int setPuanAl()
        {
            // mevcut puan ı döndürüyorum
            return _puan;

        }
        public static void BuyukHarf(char[] array, string sifre)
        {
          
            foreach (var eleman in sifre)
            // string değişkenin elemanlarına erişiyorum
            // Sifre Elemanlarının en son elemanlarına kadar Döngü ilerliyor
            {
                if (array.Contains(eleman)) // Gönderilen Dizinin Elemanları Sifre elemanlarını içeriyormu?
                {
                    // Sifre Buyuk Harf İçeriyor

                    sayacBuyukHarf++; // Buyuk Harf Sayısını Tut
                    if (sayacBuyukHarf <= 2) // Buyuk Harf Sayacı 2 den küçük esitse içeri gir degilse çık. 
                    {
                        // iki kere döneceği icin en fazla 20 puan alabilir
                        getPuanAl(_puan += 10); // sifre puanına 10 puan ekle

                         

                    }


                }
             
            } //Döngü Sonu
        }
        public static void KucukHarf(char[] array, string sifre)
        {
            
            foreach (var eleman in sifre) // string değişkenin elemanlarına erişiyorum
                                         
            {
                if (array.Contains(eleman))   // Gönderilen Dizinin Elemanları Sifre elemanlarını içeriyormu?
                {
                    // Sifre Kucuk Harf İçeriyor

                    sayacKucukHarf++;  // Kucuk Harf Sayısını Tut
                    if (sayacKucukHarf <= 2)  // Kucuk Harf Sayacı 2 den küçük esitse içeri gir degilse çık. 
                    {
                        // iki kere döneceği icin en fazla 20 puan alabilir
                        getPuanAl(_puan += 10); // sifre puanına 10 puan ekle



                    }


                }

            }

        }
        public static void RakamHarf(char[] array, string sifre)
        {
          

            foreach (var eleman in sifre)   // string değişkenin elemanlarına erişiyorum
            {
                if (array.Contains(eleman))  // Gönderilen Dizinin Elemanları Sifre elemanlarını içeriyormu?
                {
                    //şifre Rakam  içeriyor

                    sayacRakam++; // Rakam  Sayısını Tut
                    if (sayacRakam <= 2) 
                        // Rakam  Sayacı 2 den küçük esitse içeri gir degilse çık.
                    {
                        // iki kere döneceği icin en fazla 20 puan alabilir
                        getPuanAl(_puan += 10); //// sifre puanına 10 puan ekle



                    }


                }

            }
        }
        public static void SembolHarf(char[] array, string sifre)
        {
            
            foreach (var eleman in sifre)  // string değişkenin elemanlarına erişiyorum
            {
               
                if (array.Contains(eleman)) // // Gönderilen Dizinin Elemanları Sifre elemanlarını içeriyormu? 
                {
                    sayacSembol++; // Sembol Sayısını Tut
                    // sifre uzunlugu boyunca ne kadar sembol kulanıldıysa 10 puan ekle
                    getPuanAl(_puan += 10); // sifre puanına 10 puan ekle
                   
                   

                }



            }

        }
    }
}
