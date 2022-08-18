namespace DesignPattern.Abstract_Factory_Medthod
{
    public class MemCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("memorize caching");
        }
    }
}
