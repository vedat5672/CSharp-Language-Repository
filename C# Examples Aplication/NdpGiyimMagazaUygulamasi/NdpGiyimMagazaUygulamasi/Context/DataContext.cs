using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NdpGiyimMagazaUygulamasi.Context
{
    public class DataContext:IDataContext
    {
        public void baglan()
        {
            SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=GiyimMagazası;Trusted_Connection=True");
            SqlDataAdapter adapter = new SqlDataAdapter(" select * from Uruns", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
        }
       
    }
}
