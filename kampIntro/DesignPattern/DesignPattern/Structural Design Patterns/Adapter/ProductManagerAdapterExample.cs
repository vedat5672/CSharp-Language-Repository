using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{

    public class ProductManagerAdapterExample
    {
        private ILog _logger;

        public ProductManagerAdapterExample(ILog logger)
        {
            _logger = logger;
        }

        public void Save()
        {
            _logger.Log("User Data");
            Console.WriteLine("Saved");
        }
    }
}
