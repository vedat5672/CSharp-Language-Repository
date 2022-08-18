using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public  class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3] { "vedat", "yunus", "berfin" };
            List<string> students2 = new List<string>() { "ali", "ayse", "veli" };
            find(students2);
            int x = 0;
            int y = 1;

            HandleException(() =>
            {
                find(students2);
            });
            try
            {

                Console.WriteLine(y / x);
                students[3] = "ahmet";

            }
            catch (DivideByZeroException ex)
            {


                Console.WriteLine(ex.Message);




            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (RecordNotException ex)
            {
                Console.WriteLine(ex.Message);
            }





        }

        private static void HandleException(Action p)
        {
            try
            {
                p.Invoke();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private static void find(List<string> students2)
        {
            if (!students2.Contains("xbhxc"))
            {

                Console.WriteLine(new RecordNotException().Message);
            }
        }
    }
    class RecordNotException:Exception
    {
        public override string Message { get { return "hata"; } }
    }
}
