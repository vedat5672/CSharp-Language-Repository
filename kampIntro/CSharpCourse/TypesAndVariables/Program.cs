using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is vedata arslan";
         
            sentence=sentence.Trim();
            var result2=sentence.Clone();
            var result3 = sentence;
            sentence = "My name is vedatMuhendis";
            Console.WriteLine(result2);
            Console.WriteLine(result3);
         
        }
    }
}
