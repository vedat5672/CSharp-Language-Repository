
using NdpGiyimMagazaUygulammasi.Entity.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulammasi.Entity.Somut
{
    public class Giris:IDataView
    {
        public string SessionId { get; set; }
        public string KullaniciIsmi { get; set; }
        public string Sifre { get; set; }
        public string GirisTarih { get; set; }
    }
}
