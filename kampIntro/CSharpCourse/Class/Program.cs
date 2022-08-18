using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.change();
            Customer customer = new  Customer();
            customer.age = 18;
            customer.Name = "Vedat Arslan";

        }
    }
    class CustomerManager : PersonManager
    {
       

    public  void  add()
        {
            Console.WriteLine("customer added");

        }
        public void update()
        {
            Console.WriteLine("Customer updated");
        }
    }
     abstract class PersonManager
     {
      public virtual void add()
        {
            Console.WriteLine("kişi eklendi");
        }
        public void change()
        {
            Console.WriteLine("changed");
        }
     }
}
