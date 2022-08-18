namespace DesignPattern.Abstract_Factory_Medthod
{
    public abstract class CrossCutingConcersFactory
    {
        public abstract Logging CreateLogger();
        public abstract Caching CreateCaching();
    }
}
