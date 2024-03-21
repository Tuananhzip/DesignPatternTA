using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH7.TemplateMethod
{
    internal class Electronics : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("Digital Logic and Circuit Theory");
        }
    }
}
