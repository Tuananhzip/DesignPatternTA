using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.Observer
{
    internal class ObserverTypeOne : IObserver
    {
        string nameOfObserver;
        public ObserverTypeOne(string name)
        {
            this.nameOfObserver = name;
        }
        public void Update(int i)
        {
            Console.WriteLine("{0} has received an alert: Someone has " +
                "updated myValue in Subject to: {1}", nameOfObserver, i);
        }
    }
}
