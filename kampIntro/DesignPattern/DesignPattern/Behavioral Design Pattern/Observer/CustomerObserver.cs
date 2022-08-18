namespace DesignPattern.Observer
{
    public class CustomerObserver:Observer
    {

        public override void UpdatePrice()
        {
            Console.WriteLine("Product price changed message to customer");
        }
    }
}
