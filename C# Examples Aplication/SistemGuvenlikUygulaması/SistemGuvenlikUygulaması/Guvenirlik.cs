using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemGuvenlikUygulaması
{
    public static class Guvenirlik // sınıf sitatic yaptık nesne olusturmadan sınıfın static üyelerine 
        //erişebilcez ve static sınıfın uyeleri ve metotları static olmak zorunda
    {
        static char harf; // char tipinde veri değişkeni buyuk harf ve kucuk harf dizilerin elemanlarına veri atamak için kullanıcaz.
        public static int _puan; // kullanıcı girişli şifrenin güvenirlik puanını tutuyor.
        public static int buyukHarfSayac=0; // buyuk harf sayısı
        public static int KucukHarfSayac=0; 
        public static int rakamSayac=0;
        public static int sembolSayac=0;
        static char[] BuyukHarf = new char[26]; //buyuk harf dizi
        static char[] KucukHarf = new char[26];
        static char[] Rakam = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; // kendim tanımladım
        static char[] Sembol = new char[] { '!', '>', '^', '#', '+', '$', '%', '½', '-', '*', '/','|','-','_','?','}','=','{','£','&','(',')','[',']','.',',','~','é','<' };

            public static void getPuan(int puan) //puanı okur
            {
            _puan = puan;
            }
            public static int setPuan() // puanı döndürür
            {
                return _puan;
            }

        public static void buyuKHarf(string key) // gelen string parametresine göre işlemleri yapacak
        {
            int i = 0;
            for (harf = 'A'; harf <= 'Z'; harf++) // for döngüsüyle büyük harfleri A dan Z ye kadar diziye atıyoruz.
            {
                BuyukHarf[i] = harf; // dizinin i. elemanı esittir harf
               
                i++; // i arttıt
            }
            foreach (var item in key) //string değişkenini Inumerable hale getiriyoruz.
                //yani keyin her elemanına erişebiliyoruz bir dizi gibi
            {
                if (BuyukHarf.Contains(item)) // her bir string buyuk harf içeriyormu 
                {
                    //şifre buyuk harf içeriyor
                    buyukHarfSayac++; // her buyuk harf sayısı içerdiğinde buyuk harf sayacı bir atttır.
                    if (buyukHarfSayac<=2) // buyuk harfin sayac 2 den kucuk esitmi kucuk esşitse içeri gir
                    {
                        //max 20 puan alabilir
                        getPuan(_puan += 10); // her bir harf için 10 topla
                    
                        Console.WriteLine(setPuan());    //döndürülen değeri yaz

                    }
                  
                
                }
                
            }
            Console.WriteLine("buyuk harf sayısı:   "+buyukHarfSayac); // döngüden çıktıktan sonra sayac degerini yazdır.
                
            
           
            
        }

        public static void kucukHarf(string key)
        {
            int i = 0;
            for (harf = 'a'; harf <= 'z'; harf++)
            {
                KucukHarf[i] = harf;
               
                i++;
            }
            foreach (var item in key)
            {
                if (KucukHarf.Contains(item))
                {
                    KucukHarfSayac++;
                    if (KucukHarfSayac<=2)
                    {
                        getPuan(_puan += 10);
                        setPuan();
                        Console.WriteLine(_puan);
                        
                    }
                   

                }

            }
            Console.WriteLine("kucuk harf sayısı :    "+KucukHarfSayac);
        }

        public static void rakam(string key)
        {
            foreach (var item in key)
            {
                if (Rakam.Contains(item))
                {
                    rakamSayac++;
                    if (rakamSayac<=2)
                    {
                        getPuan(_puan += 10);
                        setPuan();
                        Console.WriteLine(_puan);
                    }
                    
                  

                }

            }
            Console.WriteLine("rakam sayısı :  "+ rakamSayac);
        }

        public static void sembol(string key)
        {
            foreach (var item in key)
            {
                if (Sembol.Contains(item)) // sembol içeriyorsa her sembol için 10 puan arttır
                {
                    getPuan(_puan += 10);
                    setPuan();
                    Console.WriteLine(_puan);
                    sembolSayac++;

                }

            }
            Console.WriteLine("sembol sayısı :   " +sembolSayac);
        }
    }
}
