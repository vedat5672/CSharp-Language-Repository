using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Dependency_Injection
{
    public class ProductDataAccessLayer:IProductDal
    {
        public void Save()
        {
            Console.WriteLine("saved with EF");
        }

    }  
    public class Postgres:IProductDal
    {
        public void Save()
        {
            Console.WriteLine("saved with psgres");
        }

    }

    public interface IProductDal
    {
        void Save();
    }

    public class ProductManager
    {
        IProductDal product;

        public ProductManager(IProductDal product)
        {
            this.product = product;
        }

        public void Save()
        {
            product.Save();
        }
    }
}
