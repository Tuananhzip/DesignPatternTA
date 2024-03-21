using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.FactoryMethodPattern
{
    internal class Tiger : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Tiger says: Halum.");
        }

        public void Speak()
        {
            Console.WriteLine("Tiger prefer hunting...\n");
        }
    }
}
