using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH8.VisitorPattern
{
    internal interface IVisitor
    {
        void Visit(MyClass myClass);
    }
}
