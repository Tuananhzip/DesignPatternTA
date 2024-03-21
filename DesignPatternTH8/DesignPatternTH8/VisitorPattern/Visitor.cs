using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.VisitorPattern
{
    internal class Visitor : IVisitor
    {
        public void Visit(MyClass myClass)
        {
            Console.WriteLine("Visitor is trying to change the integer value.");
            myClass.MyInt = 100;
            Console.WriteLine("Exiting from Visitor.");
        }
    }
}
