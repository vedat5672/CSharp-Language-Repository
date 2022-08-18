namespace DesignPattern.Command
{
    public class ProductDal : IProductDal
    {
        List<Product> Products = new List<Product>() 
        { 
            new Product(){Name="Laptop",quantity=1000},
            new Product(){Name="Fare",quantity=100},
            new Product(){Name="Mouse",quantity=300},
            new Product(){Name="Monitor",quantity=700},
            new Product(){Name="Klavye",quantity=200}
        };
        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Delete(Product product)
        {
            Products.Remove(product);
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
          
            return Products;
        }
    }
}
