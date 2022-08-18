namespace DesignPattern.Observer
{
    public class EmployeeObserver:Observer
    {

        public override void UpdatePrice()
        {
            Console.WriteLine("Product price changed message to Employee");
        }
    }
}
