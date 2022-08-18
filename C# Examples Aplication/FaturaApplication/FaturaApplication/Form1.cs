                                                                        /****************************************************************************
                                                                        ** SAKARYA ÜNÝVERSÝTESÝ
                                                                        ** BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
                                                                        ** BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
                                                                        ** NESNEYE DAYALI PROGRAMLAMA DERSÝ
                                                                        ** 2021-2022 BAHAR DÖNEMÝ
                                                                        **
                                                                        ** ÖDEV NUMARASI..........:  NNP-Odev 2
                                                                        ** ÖÐRENCÝ ADI............:  Vedat Arslan  
                                                                        ** ÖÐRENCÝ NUMARASI.......:  B181210030
                                                                        ** DERSÝN ALINDIÐI GRUP...:  2A
                                                                        ****************************************************************************/
namespace FaturaApplication
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        TextBox txt = new TextBox(); // textbox nesnesi olustur 
        Label lbl = new Label();  
        Label lblMetin = new Label();
        Label lblMetin1 = new Label();
        
       

        private void Form1_Load(object sender, EventArgs e) // Form açýlýrken plcaklar
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // Formun Sabit Durmasýný Saðlýyor


         
            Point txtyer = new Point(150, 50); // yeni  bir pozisyon
            txt.Size = new Size(250, 50); // yeni bir boyut
            txt.Location = txtyer;
            txt.Name = "txt1";
            Controls.Add(txt);
            

             //Bir label nesnesi oluþturur.
            Point lblyer = new Point(150, 100);
            lbl.Location = lblyer;
            //Label'i yerleþtireceðimiz bir nokta belirliyor ve oraya konumlandýrýyoruz.     
            lbl.Text = ""; // içine yazdýrcaðim için text boþ olnasý lazým
            lbl.TextAlign = ContentAlignment.MiddleLeft; // yazý nýn baþladýðý konum
            lbl.Name = "lbl1";
            lbl.Size = new Size(250, 25);
            lbl.BackColor = Color.White; //arka plan kýrmýzý
            //Label'ýn name ve text özelliklerini deðiþtirdik.
            this.Controls.Add(lbl);

            lblMetin.AutoSize = false;
            Point lblMetinyer = new Point(40, 50);
            lblMetin.Location = lblMetinyer;
            //Label'i yerleþtireceðimiz bir nokta belirliyor ve oraya konumlandýrýyoruz.     
            lblMetin.Text = "lütfen Sayý Giriniz"; // içine yazdýrcaðim için text boþ olnasý lazým
            
            lblMetin.TextAlign = ContentAlignment.MiddleLeft; // yazý nýn baþladýðý konum
            lblMetin.Name = "lblMetin";
            lblMetin.BackColor = Color.AliceBlue;
            this.Controls.Add(lblMetin);

            lblMetin1.AutoSize = false;
            Point lblMetin1yer = new Point(40, 100);
            lblMetin1.Location = lblMetin1yer;
            //Label'i yerleþtireceðimiz bir nokta belirliyor ve oraya konumlandýrýyoruz.     
            lblMetin1.Text = "Sayý Yazdýrma"; // içine yazdýrcaðim için text boþ olnasý lazým
            lblMetin1.TextAlign = ContentAlignment.MiddleLeft; // yazý nýn baþladýðý konum
            lblMetin1.Name = "lblMetin1";
            lblMetin1.BackColor = Color.AliceBlue;
            this.Controls.Add(lblMetin1);

           ; //arka plan kýrmýzý
            //Label'ýn name ve text özelliklerini deðiþtirdik.
            

            Button btn = new Button();
            Point btnyer = new Point(180, 150); // butonu ortalamaya calýþýyorum x=180 y=150
            btn.Size = new Size(200, 60);
            btn.Location = btnyer;
            btn.Name = "btn1";
            btn.ForeColor=Color.White;
            btn.Text = "Hesapla";
            Controls.Add(btn);
            btn.Click += new EventHandler(btn_Click);  // buton týklama olayýný caðýrýyorum
           

        }


        private void btn_Click(object? sender, EventArgs e) // butona týkladýðýnda olcak eykemler
        {

           
            int index = txt.Text.IndexOf('.'); // noktanýn indexsini buluyorum
           


            lbl.Text = "";
            try
            {
                if (!(txt.Text.Contains('.'))) // nokta içermiyorsa
                {
                    int tamPara = Convert.ToInt32(txt.Text);  // stringi integere dönüstür
                    if (txt.Text.Length < 6)
                    {

                        if (txt.Text.Length >= 4) // 5 ve 4 basamak  binler ve onbinler
                        {
                            switch (tamPara / 10000)  // bolumden kalan case döndür
                            {
                                case 9: lbl.Text = lbl.Text + "Doksan "; break;
                                case 8: lbl.Text = lbl.Text + "Seksen "; break;
                                case 7: lbl.Text = lbl.Text + "Yetmiþ "; break;
                                case 6: lbl.Text = lbl.Text + "Altmiþ "; break;
                                case 5: lbl.Text = lbl.Text + "Elli "; break;
                                case 4: lbl.Text = lbl.Text + "Kýrk "; break;
                                case 3: lbl.Text = lbl.Text + "Otuz "; break;
                                case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                                case 1: lbl.Text = lbl.Text + "On "; break;
                            }
                            switch ((tamPara % 10000) / 1000) // moddan kalan case döndür
                            {
                                case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                                case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                                case 7: lbl.Text = lbl.Text + "Yedi "; break;
                                case 6: lbl.Text = lbl.Text + "Altý "; break;
                                case 5: lbl.Text = lbl.Text + "Beþ "; break;
                                case 4: lbl.Text = lbl.Text + "Dört "; break;
                                case 3: lbl.Text = lbl.Text + "Üçb "; break;
                                case 2: lbl.Text = lbl.Text + "Ýki "; break;

                            }
                            lbl.Text = lbl.Text + "bin ";  // sonuna bie tane bin koyuyorum 
                        }

                        switch (tamPara % 1000 / 100)
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuzyüz "; break;
                            case 8: lbl.Text = lbl.Text + "Sekizyüz "; break;
                            case 7: lbl.Text = lbl.Text + "Yediyüz "; break;
                            case 6: lbl.Text = lbl.Text + "Altýyüz "; break;
                            case 5: lbl.Text = lbl.Text + "Beþyüz "; break;
                            case 4: lbl.Text = lbl.Text + "Dörtyüz "; break;
                            case 3: lbl.Text = lbl.Text + "Üçyüz "; break;
                            case 2: lbl.Text = lbl.Text + "Ýkiyüz "; break;
                            case 1: lbl.Text = lbl.Text + "Yüz "; break;
                        } //
                        switch ((tamPara % 100) / 10)
                        {
                            case 9: lbl.Text = lbl.Text + "Doksan "; break;
                            case 8: lbl.Text = lbl.Text + "Seksen "; break;
                            case 7: lbl.Text = lbl.Text + "Yetmiþ "; break;
                            case 6: lbl.Text = lbl.Text + "Altmýþ "; break;
                            case 5: lbl.Text = lbl.Text + "Elli "; break;
                            case 4: lbl.Text = lbl.Text + "Kýrk "; break;
                            case 3: lbl.Text = lbl.Text + "Otuz "; break;
                            case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                            case 1: lbl.Text = lbl.Text + "On "; break;
                        }
                        switch ((tamPara % 10))
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                            case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                            case 7: lbl.Text = lbl.Text + "Yedi "; break;
                            case 6: lbl.Text = lbl.Text + "Altý "; break;
                            case 5: lbl.Text = lbl.Text + "Beþ "; break;
                            case 4: lbl.Text = lbl.Text + "Dört "; break;
                            case 3: lbl.Text = lbl.Text + "Üç "; break;
                            case 2: lbl.Text = lbl.Text + "Ýki "; break;
                            case 1: lbl.Text = lbl.Text + "Bir "; break;
                        }

                        lbl.Text = lbl.Text + " TL";
                    }
                    else // uzunluk 6 dan buyuk veya esitse hata mesajý
                    {
                        MessageBox.Show("en fazla bes basamaklý sayý giriniz");
                    }
                }
                if (txt.Text.Contains('.'))  // Nokta içeriyorsa
                {
                    string tl = txt.Text.Substring(0, index); //Noktaya kadar al
                    string kurus = txt.Text.Substring(index + 1); //Noktadan Sonra Al
                    int tamPara = Convert.ToInt32(tl); // tl yi integer a cevir
                    int bozukPara = Convert.ToInt32(kurus); // kurusu integere cevir 


                    while (bozukPara > 99)  // kurus 99 dan buyuk olunca tl ye eklesin
                    {
                        int artanTamKýsým = bozukPara / 100; // kurus iki basamaklý oldugu için artan basamaðý tl ye cevirir
                        tamPara += artanTamKýsým;  // artan kýsmý liraya ekler
                        bozukPara = bozukPara - artanTamKýsým * 100; // bozukPara artan basamak çýkartýlýr sanki iki basmakmýþ hale getirilir


                    }

                    if (tl.Length < 6)
                    {

                        if (tl.Length >= 4)
                        {
                            switch (tamPara / 10000)
                            {
                                case 9: lbl.Text = lbl.Text + "Doksan "; break;
                                case 8: lbl.Text = lbl.Text + "Seksen "; break;
                                case 7: lbl.Text = lbl.Text + "Yetmiþ "; break;
                                case 6: lbl.Text = lbl.Text + "Altmiþ "; break;
                                case 5: lbl.Text = lbl.Text + "Elli "; break;
                                case 4: lbl.Text = lbl.Text + "Kýrk "; break;
                                case 3: lbl.Text = lbl.Text + "Otuz "; break;
                                case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                                case 1: lbl.Text = lbl.Text + "On "; break;
                            }
                            switch ((tamPara % 10000) / 1000)
                            {
                                case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                                case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                                case 7: lbl.Text = lbl.Text + "Yedi "; break;
                                case 6: lbl.Text = lbl.Text + "Altý "; break;
                                case 5: lbl.Text = lbl.Text + "Beþ "; break;
                                case 4: lbl.Text = lbl.Text + "Dört "; break;
                                case 3: lbl.Text = lbl.Text + "Üçb "; break;
                                case 2: lbl.Text = lbl.Text + "Ýki "; break;

                            }
                            lbl.Text = lbl.Text + "bin ";
                        }

                        switch (tamPara % 1000 / 100)
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuzyüz "; break;
                            case 8: lbl.Text = lbl.Text + "Sekizyüz "; break;
                            case 7: lbl.Text = lbl.Text + "Yediyüz "; break;
                            case 6: lbl.Text = lbl.Text + "Altýyüz "; break;
                            case 5: lbl.Text = lbl.Text + "Beþyüz "; break;
                            case 4: lbl.Text = lbl.Text + "Dörtyüz "; break;
                            case 3: lbl.Text = lbl.Text + "Üçyüz "; break;
                            case 2: lbl.Text = lbl.Text + "Ýkiyüz "; break;
                            case 1: lbl.Text = lbl.Text + "Yüz "; break;
                        }
                        switch ((tamPara % 100) / 10)
                        {
                            case 9: lbl.Text = lbl.Text + "Doksan "; break;
                            case 8: lbl.Text = lbl.Text + "Seksen "; break;
                            case 7: lbl.Text = lbl.Text + "Yetmiþ "; break;
                            case 6: lbl.Text = lbl.Text + "Altmýþ "; break;
                            case 5: lbl.Text = lbl.Text + "Elli "; break;
                            case 4: lbl.Text = lbl.Text + "Kýrk "; break;
                            case 3: lbl.Text = lbl.Text + "Otuz "; break;
                            case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                            case 1: lbl.Text = lbl.Text + "On "; break;
                        }
                        switch ((tamPara % 10))
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                            case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                            case 7: lbl.Text = lbl.Text + "Yedi "; break;
                            case 6: lbl.Text = lbl.Text + "Altý "; break;
                            case 5: lbl.Text = lbl.Text + "Beþ "; break;
                            case 4: lbl.Text = lbl.Text + "Dört "; break;
                            case 3: lbl.Text = lbl.Text + "Üç "; break;
                            case 2: lbl.Text = lbl.Text + "Ýki "; break;
                            case 1: lbl.Text = lbl.Text + "Bir "; break;
                        }
                        lbl.Text = lbl.Text + " TL ";
                        if (bozukPara != 0) // noktalý kýsým sýfýra esit degilse
                        {

                            switch (bozukPara / 10)
                            {
                                case 9: lbl.Text = lbl.Text + "Doksan "; break;
                                case 8: lbl.Text = lbl.Text + "Seksen "; break;
                                case 7: lbl.Text = lbl.Text + "Yetmiþ "; break;
                                case 6: lbl.Text = lbl.Text + "Altmýþ "; break;
                                case 5: lbl.Text = lbl.Text + "Elli "; break;
                                case 4: lbl.Text = lbl.Text + "Kýrk "; break;
                                case 3: lbl.Text = lbl.Text + "Otuz "; break;
                                case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                                case 1: lbl.Text = lbl.Text + "On "; break;
                            }
                            switch ((bozukPara % 10))
                            {
                                case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                                case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                                case 7: lbl.Text = lbl.Text + "Yedi "; break;
                                case 6: lbl.Text = lbl.Text + "Altý "; break;
                                case 5: lbl.Text = lbl.Text + "Beþ "; break;
                                case 4: lbl.Text = lbl.Text + "Dört "; break;
                                case 3: lbl.Text = lbl.Text + "Üç "; break;
                                case 2: lbl.Text = lbl.Text + "Ýki "; break;
                                case 1: lbl.Text = lbl.Text + "Bir  "; break;
                            }
                            lbl.Text = lbl.Text + "kurus "; // sonuna kurus ekle                                                                                                                                                   

                        }

                    }
                    else
                    {
                        MessageBox.Show("en fazla 5 basamak");
                    }


                }
            }
            catch (Exception)
            {
                MessageBox.Show("!!!!!!   Hatalý Giriþ Yaptýnýz   !!!!");
            }
           







        }
    }
}