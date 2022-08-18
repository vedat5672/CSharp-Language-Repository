namespace DesignPattern.Abstract_Factory_Medthod
{
    public class Log4NetLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with log4net");
        }
    }
}
