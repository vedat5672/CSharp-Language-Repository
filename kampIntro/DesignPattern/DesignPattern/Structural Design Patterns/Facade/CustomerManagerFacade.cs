namespace DesignPattern.Facade
{
    public class CustomerManagerFacade
    {


        private CrossCutingConcernsFacade _concerns;
        public CustomerManagerFacade()
        {
           _concerns=new CrossCutingConcernsFacade();
        }
        public void Save()
        {
           _concerns.logging.Log("logging");
            _concerns.caching.Cache();
            _concerns.authorize.CheckUser();
            Console.WriteLine("Saved");
        }
      

       
    }
}
