namespace DesignPattern.Facade
{
    public class Authorize:IAuthorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Usser checked");
        }
    }
}
