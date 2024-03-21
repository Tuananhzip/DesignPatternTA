using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.AvocadoFactoryMethodPattern
{
    internal abstract class IAvocadoFactory
    {
        public abstract IProduct CreateProduct();
    }
}
