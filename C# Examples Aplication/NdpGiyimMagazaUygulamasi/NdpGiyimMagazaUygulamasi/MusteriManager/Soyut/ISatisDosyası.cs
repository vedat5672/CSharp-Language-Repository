
using NdpGiyimMagazaUygulamasi.Context;
using NdpGiyimMagazaUygulammasi.Entity.Soyut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulamasi.MusteriManager.Soyut
{
    public interface ISatisDosyası:IDataView 
    {
        void SatilanUrun(int adet);
        
    }
}
