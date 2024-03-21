using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.VisitorPattern
{
    internal class MyClass : IOriginalInterface
    {
        private int myInt = 5;// Default
        public int MyInt
        {
            get
            {
                return myInt;
            }
            set
            {
                myInt = value;
            }
        }
        public void Accept(IVisitor visitor)
        {
            Console.WriteLine("Initial value of the integer: {0}", myInt);
            visitor.Visit(this);
            Console.WriteLine("Value of the integer now: {0}", myInt);
        }
    }
}
