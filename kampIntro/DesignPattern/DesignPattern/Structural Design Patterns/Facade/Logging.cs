using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class Logging:ILogging
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }

        public void Log(string messsage)
        {
            Console.WriteLine(messsage);
        }
    }
}
