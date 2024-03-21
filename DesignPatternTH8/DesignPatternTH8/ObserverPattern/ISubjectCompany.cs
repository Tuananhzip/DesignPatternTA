using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.Observer
{
    internal interface ISubjectCompany
    {
        void Subscribe(IObserverCompany company);
        void Unsubscribe(IObserverCompany company);
        void Notify(string message);
        void Post(string content);
    }
}
