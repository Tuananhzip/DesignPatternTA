using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.Observer
{
    internal class ObserverTypeTwo : IObserver
    {
        string nameOfObserver;
        public ObserverTypeTwo(string name)
        {
            this.nameOfObserver = name;
        }
        public void Update(int i)
        {
            Console.WriteLine("{0} notified: myValue in " +
                "Subject at present: {1}", nameOfObserver, i);
        }
    }
}
