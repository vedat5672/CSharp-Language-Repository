using NdpGiyimMagazaUygulammasi;
using NdpGiyimMagazaUygulammasi.Entity.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulammasi.Entity.Somut
{
    public class Category:IDataView
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public int SubCategoryId { get; set; }

    }
}
