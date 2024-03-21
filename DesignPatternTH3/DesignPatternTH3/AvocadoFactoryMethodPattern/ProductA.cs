using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.AvocadoFactoryMethodPattern
{
    internal class ProductA : IProduct
    {
        public void ShipForm()
        {
            Console.WriteLine("Shipping from Japan");
        }
    }
}
