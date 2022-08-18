namespace DesignPattern.Null_Object
{
    public class NLogLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("logging nlogger");
        }
    }
}
