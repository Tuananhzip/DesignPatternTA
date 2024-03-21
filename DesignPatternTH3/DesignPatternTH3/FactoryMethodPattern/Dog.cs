using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.FactoryMethodPattern
{
    internal class Dog : IAnimal
    {

        public void Action()
        {
            Console.WriteLine("Dog says: Bow-Wow.");
        }

        public void Speak()
        {
            Console.WriteLine("Dogs prefer barking...\n");
        }
    }
}
