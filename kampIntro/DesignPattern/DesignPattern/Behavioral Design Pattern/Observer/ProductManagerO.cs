using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class ProductManagerO
    {
        List<Observer> Observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product price changed");
            Notify();
        }
        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        } 
        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        } 
        private void Notify()
        {
          foreach (Observer observer in Observers)
            {
                  observer.UpdatePrice();
            }
        }

    }
}
