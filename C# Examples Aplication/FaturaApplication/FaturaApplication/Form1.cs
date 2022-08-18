                                                                        /****************************************************************************
                                                                        ** SAKARYA �N�VERS�TES�
                                                                        ** B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
                                                                        ** B�LG�SAYAR M�HEND�SL��� B�L�M�
                                                                        ** NESNEYE DAYALI PROGRAMLAMA DERS�
                                                                        ** 2021-2022 BAHAR D�NEM�
                                                                        **
                                                                        ** �DEV NUMARASI..........:  NNP-Odev 2
                                                                        ** ��RENC� ADI............:  Vedat Arslan  
                                                                        ** ��RENC� NUMARASI.......:  B181210030
                                                                        ** DERS�N ALINDI�I GRUP...:  2A
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
        
       

        private void Form1_Load(object sender, EventArgs e) // Form a��l�rken plcaklar
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // Formun Sabit Durmas�n� Sa�l�yor


         
            Point txtyer = new Point(150, 50); // yeni  bir pozisyon
            txt.Size = new Size(250, 50); // yeni bir boyut
            txt.Location = txtyer;
            txt.Name = "txt1";
            Controls.Add(txt);
            

             //Bir label nesnesi olu�turur.
            Point lblyer = new Point(150, 100);
            lbl.Location = lblyer;
            //Label'i yerle�tirece�imiz bir nokta belirliyor ve oraya konumland�r�yoruz.     
            lbl.Text = ""; // i�ine yazd�rca�im i�in text bo� olnas� laz�m
            lbl.TextAlign = ContentAlignment.MiddleLeft; // yaz� n�n ba�lad��� konum
            lbl.Name = "lbl1";
            lbl.Size = new Size(250, 25);
            lbl.BackColor = Color.White; //arka plan k�rm�z�
            //Label'�n name ve text �zelliklerini de�i�tirdik.
            this.Controls.Add(lbl);

            lblMetin.AutoSize = false;
            Point lblMetinyer = new Point(40, 50);
            lblMetin.Location = lblMetinyer;
            //Label'i yerle�tirece�imiz bir nokta belirliyor ve oraya konumland�r�yoruz.     
            lblMetin.Text = "l�tfen Say� Giriniz"; // i�ine yazd�rca�im i�in text bo� olnas� laz�m
            
            lblMetin.TextAlign = ContentAlignment.MiddleLeft; // yaz� n�n ba�lad��� konum
            lblMetin.Name = "lblMetin";
            lblMetin.BackColor = Color.AliceBlue;
            this.Controls.Add(lblMetin);

            lblMetin1.AutoSize = false;
            Point lblMetin1yer = new Point(40, 100);
            lblMetin1.Location = lblMetin1yer;
            //Label'i yerle�tirece�imiz bir nokta belirliyor ve oraya konumland�r�yoruz.     
            lblMetin1.Text = "Say� Yazd�rma"; // i�ine yazd�rca�im i�in text bo� olnas� laz�m
            lblMetin1.TextAlign = ContentAlignment.MiddleLeft; // yaz� n�n ba�lad��� konum
            lblMetin1.Name = "lblMetin1";
            lblMetin1.BackColor = Color.AliceBlue;
            this.Controls.Add(lblMetin1);

           ; //arka plan k�rm�z�
            //Label'�n name ve text �zelliklerini de�i�tirdik.
            

            Button btn = new Button();
            Point btnyer = new Point(180, 150); // butonu ortalamaya cal���yorum x=180 y=150
            btn.Size = new Size(200, 60);
            btn.Location = btnyer;
            btn.Name = "btn1";
            btn.ForeColor=Color.White;
            btn.Text = "Hesapla";
            Controls.Add(btn);
            btn.Click += new EventHandler(btn_Click);  // buton t�klama olay�n� ca��r�yorum
           

        }


        private void btn_Click(object? sender, EventArgs e) // butona t�klad���nda olcak eykemler
        {

           
            int index = txt.Text.IndexOf('.'); // noktan�n indexsini buluyorum
           


            lbl.Text = "";
            try
            {
                if (!(txt.Text.Contains('.'))) // nokta i�ermiyorsa
                {
                    int tamPara = Convert.ToInt32(txt.Text);  // stringi integere d�n�st�r
                    if (txt.Text.Length < 6)
                    {

                        if (txt.Text.Length >= 4) // 5 ve 4 basamak  binler ve onbinler
                        {
                            switch (tamPara / 10000)  // bolumden kalan case d�nd�r
                            {
                                case 9: lbl.Text = lbl.Text + "Doksan "; break;
                                case 8: lbl.Text = lbl.Text + "Seksen "; break;
                                case 7: lbl.Text = lbl.Text + "Yetmi� "; break;
                                case 6: lbl.Text = lbl.Text + "Altmi� "; break;
                                case 5: lbl.Text = lbl.Text + "Elli "; break;
                                case 4: lbl.Text = lbl.Text + "K�rk "; break;
                                case 3: lbl.Text = lbl.Text + "Otuz "; break;
                                case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                                case 1: lbl.Text = lbl.Text + "On "; break;
                            }
                            switch ((tamPara % 10000) / 1000) // moddan kalan case d�nd�r
                            {
                                case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                                case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                                case 7: lbl.Text = lbl.Text + "Yedi "; break;
                                case 6: lbl.Text = lbl.Text + "Alt� "; break;
                                case 5: lbl.Text = lbl.Text + "Be� "; break;
                                case 4: lbl.Text = lbl.Text + "D�rt "; break;
                                case 3: lbl.Text = lbl.Text + "��b "; break;
                                case 2: lbl.Text = lbl.Text + "�ki "; break;

                            }
                            lbl.Text = lbl.Text + "bin ";  // sonuna bie tane bin koyuyorum 
                        }

                        switch (tamPara % 1000 / 100)
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuzy�z "; break;
                            case 8: lbl.Text = lbl.Text + "Sekizy�z "; break;
                            case 7: lbl.Text = lbl.Text + "Yediy�z "; break;
                            case 6: lbl.Text = lbl.Text + "Alt�y�z "; break;
                            case 5: lbl.Text = lbl.Text + "Be�y�z "; break;
                            case 4: lbl.Text = lbl.Text + "D�rty�z "; break;
                            case 3: lbl.Text = lbl.Text + "��y�z "; break;
                            case 2: lbl.Text = lbl.Text + "�kiy�z "; break;
                            case 1: lbl.Text = lbl.Text + "Y�z "; break;
                        } //
                        switch ((tamPara % 100) / 10)
                        {
                            case 9: lbl.Text = lbl.Text + "Doksan "; break;
                            case 8: lbl.Text = lbl.Text + "Seksen "; break;
                            case 7: lbl.Text = lbl.Text + "Yetmi� "; break;
                            case 6: lbl.Text = lbl.Text + "Altm�� "; break;
                            case 5: lbl.Text = lbl.Text + "Elli "; break;
                            case 4: lbl.Text = lbl.Text + "K�rk "; break;
                            case 3: lbl.Text = lbl.Text + "Otuz "; break;
                            case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                            case 1: lbl.Text = lbl.Text + "On "; break;
                        }
                        switch ((tamPara % 10))
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                            case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                            case 7: lbl.Text = lbl.Text + "Yedi "; break;
                            case 6: lbl.Text = lbl.Text + "Alt� "; break;
                            case 5: lbl.Text = lbl.Text + "Be� "; break;
                            case 4: lbl.Text = lbl.Text + "D�rt "; break;
                            case 3: lbl.Text = lbl.Text + "�� "; break;
                            case 2: lbl.Text = lbl.Text + "�ki "; break;
                            case 1: lbl.Text = lbl.Text + "Bir "; break;
                        }

                        lbl.Text = lbl.Text + " TL";
                    }
                    else // uzunluk 6 dan buyuk veya esitse hata mesaj�
                    {
                        MessageBox.Show("en fazla bes basamakl� say� giriniz");
                    }
                }
                if (txt.Text.Contains('.'))  // Nokta i�eriyorsa
                {
                    string tl = txt.Text.Substring(0, index); //Noktaya kadar al
                    string kurus = txt.Text.Substring(index + 1); //Noktadan Sonra Al
                    int tamPara = Convert.ToInt32(tl); // tl yi integer a cevir
                    int bozukPara = Convert.ToInt32(kurus); // kurusu integere cevir 


                    while (bozukPara > 99)  // kurus 99 dan buyuk olunca tl ye eklesin
                    {
                        int artanTamK�s�m = bozukPara / 100; // kurus iki basamakl� oldugu i�in artan basama�� tl ye cevirir
                        tamPara += artanTamK�s�m;  // artan k�sm� liraya ekler
                        bozukPara = bozukPara - artanTamK�s�m * 100; // bozukPara artan basamak ��kart�l�r sanki iki basmakm�� hale getirilir


                    }

                    if (tl.Length < 6)
                    {

                        if (tl.Length >= 4)
                        {
                            switch (tamPara / 10000)
                            {
                                case 9: lbl.Text = lbl.Text + "Doksan "; break;
                                case 8: lbl.Text = lbl.Text + "Seksen "; break;
                                case 7: lbl.Text = lbl.Text + "Yetmi� "; break;
                                case 6: lbl.Text = lbl.Text + "Altmi� "; break;
                                case 5: lbl.Text = lbl.Text + "Elli "; break;
                                case 4: lbl.Text = lbl.Text + "K�rk "; break;
                                case 3: lbl.Text = lbl.Text + "Otuz "; break;
                                case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                                case 1: lbl.Text = lbl.Text + "On "; break;
                            }
                            switch ((tamPara % 10000) / 1000)
                            {
                                case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                                case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                                case 7: lbl.Text = lbl.Text + "Yedi "; break;
                                case 6: lbl.Text = lbl.Text + "Alt� "; break;
                                case 5: lbl.Text = lbl.Text + "Be� "; break;
                                case 4: lbl.Text = lbl.Text + "D�rt "; break;
                                case 3: lbl.Text = lbl.Text + "��b "; break;
                                case 2: lbl.Text = lbl.Text + "�ki "; break;

                            }
                            lbl.Text = lbl.Text + "bin ";
                        }

                        switch (tamPara % 1000 / 100)
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuzy�z "; break;
                            case 8: lbl.Text = lbl.Text + "Sekizy�z "; break;
                            case 7: lbl.Text = lbl.Text + "Yediy�z "; break;
                            case 6: lbl.Text = lbl.Text + "Alt�y�z "; break;
                            case 5: lbl.Text = lbl.Text + "Be�y�z "; break;
                            case 4: lbl.Text = lbl.Text + "D�rty�z "; break;
                            case 3: lbl.Text = lbl.Text + "��y�z "; break;
                            case 2: lbl.Text = lbl.Text + "�kiy�z "; break;
                            case 1: lbl.Text = lbl.Text + "Y�z "; break;
                        }
                        switch ((tamPara % 100) / 10)
                        {
                            case 9: lbl.Text = lbl.Text + "Doksan "; break;
                            case 8: lbl.Text = lbl.Text + "Seksen "; break;
                            case 7: lbl.Text = lbl.Text + "Yetmi� "; break;
                            case 6: lbl.Text = lbl.Text + "Altm�� "; break;
                            case 5: lbl.Text = lbl.Text + "Elli "; break;
                            case 4: lbl.Text = lbl.Text + "K�rk "; break;
                            case 3: lbl.Text = lbl.Text + "Otuz "; break;
                            case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                            case 1: lbl.Text = lbl.Text + "On "; break;
                        }
                        switch ((tamPara % 10))
                        {
                            case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                            case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                            case 7: lbl.Text = lbl.Text + "Yedi "; break;
                            case 6: lbl.Text = lbl.Text + "Alt� "; break;
                            case 5: lbl.Text = lbl.Text + "Be� "; break;
                            case 4: lbl.Text = lbl.Text + "D�rt "; break;
                            case 3: lbl.Text = lbl.Text + "�� "; break;
                            case 2: lbl.Text = lbl.Text + "�ki "; break;
                            case 1: lbl.Text = lbl.Text + "Bir "; break;
                        }
                        lbl.Text = lbl.Text + " TL ";
                        if (bozukPara != 0) // noktal� k�s�m s�f�ra esit degilse
                        {

                            switch (bozukPara / 10)
                            {
                                case 9: lbl.Text = lbl.Text + "Doksan "; break;
                                case 8: lbl.Text = lbl.Text + "Seksen "; break;
                                case 7: lbl.Text = lbl.Text + "Yetmi� "; break;
                                case 6: lbl.Text = lbl.Text + "Altm�� "; break;
                                case 5: lbl.Text = lbl.Text + "Elli "; break;
                                case 4: lbl.Text = lbl.Text + "K�rk "; break;
                                case 3: lbl.Text = lbl.Text + "Otuz "; break;
                                case 2: lbl.Text = lbl.Text + "Yirmi "; break;
                                case 1: lbl.Text = lbl.Text + "On "; break;
                            }
                            switch ((bozukPara % 10))
                            {
                                case 9: lbl.Text = lbl.Text + "Dokuz "; break;
                                case 8: lbl.Text = lbl.Text + "Sekiz "; break;
                                case 7: lbl.Text = lbl.Text + "Yedi "; break;
                                case 6: lbl.Text = lbl.Text + "Alt� "; break;
                                case 5: lbl.Text = lbl.Text + "Be� "; break;
                                case 4: lbl.Text = lbl.Text + "D�rt "; break;
                                case 3: lbl.Text = lbl.Text + "�� "; break;
                                case 2: lbl.Text = lbl.Text + "�ki "; break;
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
                MessageBox.Show("!!!!!!   Hatal� Giri� Yapt�n�z   !!!!");
            }
           







        }
    }
}