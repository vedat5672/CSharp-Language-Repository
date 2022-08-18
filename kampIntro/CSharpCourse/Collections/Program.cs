using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayListTesting();
            listTesting();
            DictinaryTesting();

        }

        private static void DictinaryTesting() 
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("a", 1);
            dict.Add("b", 2);
        }

        private static void listTesting()
        {
            List<string> list = new List<string>();
            list.Add("a");
            list.Add("b");
            List<Customer> list2 = new List<Customer>();
            list2.Add(new Customer() { Address = "istanbul", Name = "vedat" });
        }

        private static void ArrayListTesting()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add(35);
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
