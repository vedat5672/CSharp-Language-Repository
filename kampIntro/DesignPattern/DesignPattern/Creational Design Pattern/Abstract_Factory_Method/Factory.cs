namespace DesignPattern.Abstract_Factory_Medthod
{
    public class Factory : CrossCutingConcersFactory
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogger()
        {
            return new Log4NetLogger();
        }
    }
}
