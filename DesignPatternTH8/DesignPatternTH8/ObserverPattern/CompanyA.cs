using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.Observer
{
    internal class CompanyA : IObserverCompany
    {
        private string name;
        private string address;

        public CompanyA(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} at {address} received notification: {message}");
        }
    }
}
