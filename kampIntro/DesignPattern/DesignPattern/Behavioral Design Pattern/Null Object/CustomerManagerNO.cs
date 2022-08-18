using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Null_Object
{
    public class CustomerManagerNO
    {
        private ILogger logger;

        public CustomerManagerNO(ILogger logger)
        {
            this.logger = logger;
        }
        public void Save()
        {
            Console.WriteLine("Saved");
            logger.Log();
        }
    }
}
