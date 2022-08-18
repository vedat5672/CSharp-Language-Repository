namespace DesignPattern.Abstract_Factory_Medthod
{
    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("redis caching");
        }
    }
}
