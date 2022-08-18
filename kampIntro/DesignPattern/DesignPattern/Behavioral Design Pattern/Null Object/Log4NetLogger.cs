namespace DesignPattern.Null_Object
{
    public class Log4NetLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logging log4net");
        }
    }
}
