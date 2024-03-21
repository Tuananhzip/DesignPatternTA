using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.FactoryMethodPattern
{
    internal class Client
    {
        public void Run()
        {
            Console.WriteLine("***Factory Method Pattern Demo***\n");

            IAnimalFactory tigerFactory = new TigerFactory();
            IAnimal tiger = tigerFactory.CreateAnimal();
            tiger.Action();
            tiger.Speak();

            IAnimalFactory dogFactory = new DogFactory();
            IAnimal dog = dogFactory.CreateAnimal();
            dog.Action();
            dog.Speak();

            Console.Write("press any key to continue...");
            Console.ReadLine();
        }
    }
}
