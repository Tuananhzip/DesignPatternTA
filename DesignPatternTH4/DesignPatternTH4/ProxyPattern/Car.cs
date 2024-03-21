using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.Proxy_Pattern
{
    internal class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("Car has been driven!");
        }
    }
}
