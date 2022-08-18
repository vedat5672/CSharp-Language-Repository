using NdpGiyimMagazaUygulamasi.Entity.Somut;
using NdpGiyimMagazaUygulamasi.Context;
using NdpGiyimMagazaUygulamasi.MusteriManager.Soyut;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulamasi.MusteriManager.Somut
{
    public class SatisDosyası : ISatisDosyası
    {
 
        public SatisDosyası(IDataContext dataContext)
        {
    
        }
        public void SatilanUrun(int adet)
        {

           
            if (true)//stokta olmayan urun satılamaz
            {

            }
            
        }
    }
}
