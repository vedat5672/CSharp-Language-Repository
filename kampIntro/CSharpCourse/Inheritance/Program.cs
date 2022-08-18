using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[]
            {
                new Study()  {Age="18",FirstName="sddj",LastName="sds",Id=2 },
                new Customer { City ="elazıg",FirstName="ayse",LastName="asasa",Id=1}
            };


            foreach (var item in person)
            {
                Console.WriteLine(item.LastName+" "+item.FirstName);
            }
        }
  
	
	// bir nesneyi bir kez inheritence yapabilirsiniz..

	}
    
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Study:Person
    {
        public string Age { get; set; }
    }
}
