using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.Observer
{
    internal class Subject : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        private int flag;
        public int Flag
        {
            get
            {
                return flag;
            }
            set
            {
                flag = value;
                NotifyRegisteredUsers(flag);
            }
        }
        public void NotifyRegisteredUsers(int i)
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(i);
            }
        }

        public void Post(string content)
        {
            Console.WriteLine("H is posting a new topic with content {0}", content);
        }

        public void Register(IObserver anObserver)
        {
            observers.Add(anObserver);
        }

        public void Unregister(IObserver anObserver)
        {
            observers.Remove(anObserver);
        }
    }
}
