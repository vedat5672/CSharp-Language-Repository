namespace DesignPattern.Command
{
    public class ByStock : IOrder
    {
        private StockManager _manager;

        public ByStock(StockManager manager)
        {
            _manager = manager;
        }

        public void ExeCute()
        {
            _manager.Buy();
        }
    }
}
