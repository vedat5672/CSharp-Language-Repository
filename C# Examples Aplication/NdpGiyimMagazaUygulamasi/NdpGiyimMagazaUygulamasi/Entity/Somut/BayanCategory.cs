
using NdpGiyimMagazaUygulammasi.Entity.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulamasi.Entity.Somut
{
    public  class BayanCategory:IDataView
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
       
        public int SubId { get; set; }
        public string Isim { get; set; }

    }
}
