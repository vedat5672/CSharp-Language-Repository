namespace DesignPattern.Adapter
{
    //Nuget
    public class Log4Net  // Baskasını sınıfı
    {
        public void LogMessage(string   message)
        {
            Console.WriteLine("Log4Net {0} is locked",message);
        }
    }
}
