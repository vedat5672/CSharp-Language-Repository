namespace DesignPattern.Facade
{
    public class CrossCutingConcernsFacade
    {
        public ILogging logging;
        public ICaching caching ;
        public IAuthorize authorize ;
        public CrossCutingConcernsFacade()
        {
           
            caching = new Caching();
            authorize = new Authorize();
            logging = new Logging();
        }
   
    }
}
