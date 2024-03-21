using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.DecoratorPattern
{
    internal class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();
            Console.WriteLine("***Using another decorator***");
            //Decorating now.
            PaintTheHouse();
        }
        private void PaintTheHouse()
        {
            Console.WriteLine("Now I am painting the house.");
        }
    }
}
