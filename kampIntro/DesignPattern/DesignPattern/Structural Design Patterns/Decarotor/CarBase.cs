using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decarotor
{
    public abstract class  CarBase
    {
        public abstract string Brand { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal HirePrice { get; set; }


    }
}
