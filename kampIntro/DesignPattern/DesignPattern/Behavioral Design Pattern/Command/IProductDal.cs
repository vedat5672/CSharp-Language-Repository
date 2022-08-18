namespace DesignPattern.Command
{
    public interface IProductDal
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        void Get(int id);
    }
}
