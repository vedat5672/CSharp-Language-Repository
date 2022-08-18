using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    public  class StockManager
    {
        private ProductService productService;

        public StockManager(ProductService productService)
        {
            this.productService = productService;
        }

      
        public void Buy()
        {
            Console.WriteLine("alınan ürün");
            var name = Console.ReadLine();
            Console.WriteLine("alınan fiyatı");
            var quantity =Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Stock : {0}, {1} bought!",name, quantity);
            var product = new Product();
            product.Name = name;
            product.quantity = quantity;
            productService.Add(product);
            foreach (var item in productService.GetAll())
            {
                Console.WriteLine("İSİM  :"+ item.Name + "QUANTİTY :"+ item.quantity);
            }
            
            
        }
        public void Sell()
        {
            Console.WriteLine("Stock :  sold");
        }
    }
}
