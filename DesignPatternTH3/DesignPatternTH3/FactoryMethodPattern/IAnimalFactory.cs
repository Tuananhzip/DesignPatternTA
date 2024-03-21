using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.FactoryMethodPattern
{
    internal abstract class IAnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }
}
