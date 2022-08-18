using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleMaintenance
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBakım[] bakıms = new IBakım[2] {new Car(),new Cycle() };

            foreach (var item in bakıms)
            {
                item.ChangingRim();
            }
            Console.ReadKey();
          
        }
    }
    class Car : IBakım, IKasko
    {
        public void ChangingRim()
        {
            Console.WriteLine("changed rim");
        }

        public void Clean()
        {
            Console.WriteLine("car clean");
        }

        public void GetMoneyKasko()
        {
            Console.WriteLine("paying money car");
        }

        public void ToSweap()
        {
            Console.WriteLine("sweaping");
        }
    }
    class Cycle : IBakım
    {
        public void ChangingRim()
        {
            Console.WriteLine("changed rim to cycle");
        }

        public void Clean()
        {
            Console.WriteLine("clean cycle");
        }

        public void ToSweap()
        {
            Console.WriteLine("sweaping to cycle");
        }
    }
    interface IBakım
    {
        void Clean();
        void ToSweap();
        void ChangingRim();

    }
    interface IKasko
    {
        void GetMoneyKasko();

    }
    
}
