namespace DesignPattern.Command
{
    public class ProductManagers : ProductService
    {
        private IProductDal productDal;

        public ProductManagers(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void Add(Product product)
        {
            productDal.Add(product);
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
           return productDal.GetAll();
        }
    }
}
