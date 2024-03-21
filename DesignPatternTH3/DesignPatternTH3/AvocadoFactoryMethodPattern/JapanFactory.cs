using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.AvocadoFactoryMethodPattern
{
    internal class JapanFactory : IAvocadoFactory
    {
        public override IProduct CreateProduct()
        {
            return new ProductA();
        }
    }
}
