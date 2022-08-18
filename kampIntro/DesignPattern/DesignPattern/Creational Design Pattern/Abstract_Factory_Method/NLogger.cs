namespace DesignPattern.Abstract_Factory_Medthod
{
    public class NLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with nLogger");
        }
    }
}
