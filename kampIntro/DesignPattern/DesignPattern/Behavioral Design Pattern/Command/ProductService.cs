namespace DesignPattern.Command
{
    public interface ProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        void Get(int id);

    }
}
