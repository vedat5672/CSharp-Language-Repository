
public class LoggerFactory : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        // logger business code
        return new EdLogger();
    }
}
