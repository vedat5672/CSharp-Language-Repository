namespace DesignPattern.Adapter
{
    public class EdLogger : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine("Logged,{0}",message);
        }

    }  
}
