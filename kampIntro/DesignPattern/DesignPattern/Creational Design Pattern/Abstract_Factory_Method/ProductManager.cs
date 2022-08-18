namespace DesignPattern.Abstract_Factory_Medthod
{
    public class ProductManager:IProductService
    {
        CrossCutingConcersFactory _crossCutingConcersFactory;
        private Logging _logger;
        private Caching  _caching;
        public ProductManager(CrossCutingConcersFactory crossCutingConcersFactory)
        {
            _crossCutingConcersFactory = crossCutingConcersFactory;
            _logger=_crossCutingConcersFactory.CreateLogger();
            _caching=_crossCutingConcersFactory.CreateCaching();
        }

        public void GetAll()
        {
            _logger.Log("logged");
            _caching.Cache("caching");
            Console.WriteLine("Products Listed");
        }
    }
}
