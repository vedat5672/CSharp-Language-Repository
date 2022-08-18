namespace NdpOdev1
{
    class Program
    {
        public static void Main()
        {
            char HarfAta;
            char[] buyukHarf = new char[26]; // Buyuk Harf Dizisi
            char[] kucukHarf = new char[26]; // Kucuk Harf Dizisi
            char[] rakam = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };  // Rakam Dizisi
            char[] sembol = new char[] { '!', '>', '<', '£', '^', '#', '+', '$', '%', '½', '&', '/', '{', '(', '[', ')', ']', '=', '}', '?', '*', '_', '-', '|', ',', '.', ':', ';', '`' }; // Sembol Dizisi
            int buyukHarfİndex = 0;
            int kucukHarfIndex = 0;
            for (HarfAta = 'A'; HarfAta <= 'Z'; HarfAta++) // Char değişkenimiz A dan Z ye kadar alfaden sırayla ilerle
            {
                //  Dizinin bastan sonuna kadar alfabedeki buyuk harfleri ekle

                buyukHarf[buyukHarfİndex] = HarfAta;
                buyukHarfİndex++; //  Bir Sonraki Elemana İlerle

            }
            foreach (char c in buyukHarf)
            // Buyuk Harf Dizisinin Her Elemanınına Erişiyorum
            {
                if (Char.IsUpper(c)) // Burda Büyük Harf mi? Kontrolü Yapıyorum
                {
                    kucukHarf[kucukHarfIndex] = Char.ToLower(c); // Buyuk Harf Dizisinin Elemanını Kucuk Harfe Cevir Ata
                    kucukHarfIndex++; // Sonraki Kucuk Harf Elemanına İlerle

                }
                // Döngüde her Buyuk Harf Dizisine Her Döndüğünde Sonraki Elemana İlerliyor
            }
            /*******************************************************************************************************************/
            string sifre = " ";



            Console.WriteLine("Sifre Test Uygulamasına Hoşgeldiniz"); // Ekrana Yazdırma İşlemi
            Console.WriteLine("Lütfen Şifreyi Giriniz :");
            sifre = Console.ReadLine(); // Kullanıcıdan Veri Al Sifre Ata

            while (sifre.Contains(" ")) //Boşluk Iceriyormu Evetse İçeri Gir Hayırsa Girme
            {
                Console.WriteLine("sifre boşluk içermemeli tekrar sifre giriniz");
                sifre = Console.ReadLine(); // tekrar veri al
            }

            while (sifre.Length < 9) // Sifre  9 karakter uzunluğundan kücük mü ? evetse gir hayırsa girme
            {
                Console.WriteLine("sifre en az 9 karakter olmalıdır. Lütfen tekrar şifre giriniz ");
                sifre = Console.ReadLine();
                while (sifre.Contains(" "))
                {
                    Console.WriteLine("sifre boşluk içermemeli tekrar sifre giriniz");
                    sifre = Console.ReadLine();
                }
            }
            if (sifre.Length >= 9) // Sifre 9 karakter veya üzeri ise gir
            {
                if (sifre.Length == 9) // Sifre 9 Karakter ise 10 Puan ekle
                {
                    SifreTest.getPuanAl(SifreTest._puan = +10); // Puan değişkenine 10 puan ekle ve topla

                }

                // Static Sınıf Metotlarımı Cağırıyorum . Ve gerekli olan bir dizi ve string parametre yolluyorum
                // Kullanıcı Sifresinin Puanı Bu Metotlara Hesaplatıyorum

                SifreTest.BuyukHarf(buyukHarf, sifre);   // Static oldugu için nesne olusturmuyorum

                SifreTest.KucukHarf(kucukHarf, sifre);

                SifreTest.RakamHarf(rakam, sifre);

                SifreTest.SembolHarf(sembol, sifre);


            }
            if (SifreTest.sayacRakam <= 0 || SifreTest.sayacBuyukHarf <= 0 || SifreTest.sayacKucukHarf <= 0 || SifreTest.sayacSembol <= 0) // Sembol,Rakam,Buyuk ve Kucuk harf sıfır ise Sifre Kabul edilemez.
            {

                Console.WriteLine("Buyuk Harf Sayısı :" + SifreTest.sayacBuyukHarf);   // Kac tane Buyuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Kucuk Harf Sayısı :" + SifreTest.sayacKucukHarf);   // Kac tane Kucuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Rakam Sayısı :" + SifreTest.sayacRakam);            // Kac tane Rakam Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine("Sembol Sayısı :" + SifreTest.sayacSembol);          // Kac tane Sembol Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine("Sifre Buyuk Harf ,Kucuk Harf,Sembol ve Rakamdan en az birer tane içermelidir.  ");
                Console.WriteLine("Hatalı Sifre Girdiniz ");
                Console.WriteLine("Program Sonlandırılıyor....");
                return;  // programı bitir 


            }
            while (SifreTest.setPuanAl() < 70) 
            {
                Console.WriteLine("Sifreniz Zayıf , Sifre Kabul Edilmedi");
                Console.WriteLine();
                Console.WriteLine("Buyuk Harf Sayısı :" + SifreTest.sayacBuyukHarf);   // Kac tane Buyuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Kucuk Harf Sayısı :" + SifreTest.sayacKucukHarf);   // Kac tane Kucuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Rakam Sayısı :" + SifreTest.sayacRakam);            // Kac tane Rakam Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine("Sembol Sayısı :" + SifreTest.sayacSembol);          // Kac tane Sembol Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine();
                Console.WriteLine("Program Sonlandırılıyor");
                break;

            }
            if (SifreTest.setPuanAl() >= 70 && SifreTest.setPuanAl() < 90)
            {
                Console.WriteLine();
                Console.WriteLine("Puanınız   :" + SifreTest._puan);
                Console.WriteLine("Sifre Kabul Edildi");
                Console.WriteLine();
                Console.WriteLine("Buyuk Harf Sayısı :" + SifreTest.sayacBuyukHarf);   // Kac tane Buyuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Kucuk Harf Sayısı :" + SifreTest.sayacKucukHarf);   // Kac tane Kucuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Rakam Sayısı :" + SifreTest.sayacRakam);            // Kac tane Rakam Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine("Sembol Sayısı :" + SifreTest.sayacSembol);          // Kac tane Sembol Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine();
            }
            if (SifreTest.setPuanAl() >= 90 && SifreTest.setPuanAl() <= 100)
            {
                Console.WriteLine();
                Console.WriteLine("Puanınız   :" + SifreTest._puan);
                Console.WriteLine("Sifre Kabul Edilir Ve Güçlü");
                Console.WriteLine();
                Console.WriteLine("Buyuk Harf Sayısı :" + SifreTest.sayacBuyukHarf);   // Kac tane Buyuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Kucuk Harf Sayısı :" + SifreTest.sayacKucukHarf);   // Kac tane Kucuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Rakam Sayısı :" + SifreTest.sayacRakam);            // Kac tane Rakam Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine("Sembol Sayısı :" + SifreTest.sayacSembol);          // Kac tane Sembol Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine();
            }
            if (SifreTest.setPuanAl() > 100)
            {
                Console.WriteLine();
                Console.WriteLine("Puanınız   :" + SifreTest._puan);
                Console.WriteLine("Sifre Kabul Edilir Ve Cok Güçlü" );
                
                Console.WriteLine();
                Console.WriteLine("Buyuk Harf Sayısı :" + SifreTest.sayacBuyukHarf);   // Kac tane Buyuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Kucuk Harf Sayısı :" + SifreTest.sayacKucukHarf);   // Kac tane Kucuk harf içeriyorsa onu döndürüyorum
                Console.WriteLine("Rakam Sayısı :" + SifreTest.sayacRakam);            // Kac tane Rakam Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine("Sembol Sayısı :" + SifreTest.sayacSembol);          // Kac tane Sembol Sayısı içeriyorsa onu döndürüyorum
                Console.WriteLine();
            }

        }
    }

}