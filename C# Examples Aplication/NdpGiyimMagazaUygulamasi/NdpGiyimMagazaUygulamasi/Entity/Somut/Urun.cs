using NdpGiyimMagazaUygulammasi.Entity.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulammasi.Entity.Somut
{
    public class Urun:IDataView
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int SubId { get; set; }
        public string Marka { get; set; }
        public int stokAdet { get; set; }
        
        public decimal  Fiyat { get; set; }
        public bool UrunVarmı { get; set; }
        public string Renk { get; set; }
        public string Beden { get; set; }
        public string ImagePath { get; set; }
    }
}
