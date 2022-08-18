
public class LoggerFactory2 : ILoggerFactory
{
    public ILogger CreateLogger()
    {
        // logger business code
        return new VaLogger();
    }
}
