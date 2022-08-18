namespace DesignPattern.Command
{
    public class StockController
    {
        List<IOrder> _orders = new List<IOrder>();
        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }
        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.ExeCute();
            }
            _orders.Clear();
        }
    }
}
