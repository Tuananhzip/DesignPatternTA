using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH7.TemplateMethod
{
    internal class SourBread : BasicBread
    {
        public override void Slide()
        {
            Console.WriteLine("SourBread slide");
        }
    }
}
