
public class CustomerManagers
{
  
    ILoggerFactory _factory;

    public CustomerManagers(ILoggerFactory factory)
    {
        _factory = factory;
    }

    public void Save()
    {
        Console.WriteLine("Saved");
        ILogger logger = _factory.CreateLogger();
        logger.Log();
    }
}
