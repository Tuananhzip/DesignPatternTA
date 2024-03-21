using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.FactoryMethodPattern
{
    internal class DogFactory : IAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}
