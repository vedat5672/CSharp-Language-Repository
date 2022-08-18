
using NdpGiyimMagazaUygulammasi.Entity.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulammasi.Entity.Somut
{
    public class Musteri:IDataView
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string KullaniciIsmi { get; set; }
        public string Sifre { get; set; }

    }
}
