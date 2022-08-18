using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Abstract_Factory_Medthod
{
    public class Factory2 : CrossCutingConcersFactory
    {
        public override Caching CreateCaching()
        {
            return new MemCache();
        }

        public override Logging CreateLogger()
        {
           return new NLogger();
        }
    }
}
