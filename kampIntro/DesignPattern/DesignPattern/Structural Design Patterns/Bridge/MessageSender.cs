using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
    public abstract class MessageSender

    {
        public void Save()
        {
            Console.WriteLine("Message Saved");

        }
        public abstract void Send(Body body);

    }
}
