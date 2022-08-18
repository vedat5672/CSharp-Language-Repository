using NdpGiyimMagazaUygulammasi.Entity.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulamasi.Entity.Somut
{
    public class Tedarikci:IDataView
    {
        public int Id { get; set; }
        public string Name  { get; set; }
    }
}
