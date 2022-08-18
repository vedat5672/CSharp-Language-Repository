namespace DesignPattern.Null_Object
{
    public class StubLogger : ILogger
    {
        private static StubLogger stubLogger;
        private static object _lock=new object();
        private StubLogger()
        {

        }
        public static StubLogger GetLogger()
        {
            lock(_lock)
            {
                if (stubLogger==null)
                {
                    stubLogger = new StubLogger();
                }
            }
            return stubLogger;
        }
        public void Log()
        {
           
        }
    }
}
