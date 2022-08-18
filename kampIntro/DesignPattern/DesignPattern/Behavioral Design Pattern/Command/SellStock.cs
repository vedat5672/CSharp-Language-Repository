namespace DesignPattern.Command
{
    public class SellStock : IOrder
    {
        private StockManager _manager;

        public SellStock(StockManager manager)
        {
            _manager = manager;
        }

        public void ExeCute()
        {
            _manager.Sell();
        }
      
    }
}
