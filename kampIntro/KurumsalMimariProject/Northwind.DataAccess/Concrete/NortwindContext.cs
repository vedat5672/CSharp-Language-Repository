using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete
{
    public class NortwindContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> Products {get;set;}
    }
}
