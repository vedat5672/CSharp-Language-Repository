namespace DesignPattern.Adapter
{
    public class Log4NetAdapter :  ILog
    {
        public void Log(string message)
        {
            Log4Net log4Net = new Log4Net();
            log4Net.LogMessage(message);
        }
    
    }
}
