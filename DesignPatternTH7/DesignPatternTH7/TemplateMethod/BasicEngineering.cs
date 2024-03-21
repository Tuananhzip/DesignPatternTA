using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH7.TemplateMethod
{
    internal abstract class BasicEngineering
    {
        public void Papers()
        {
            Math();
            SoftSkill();
            SpecialPaper();
        }
        public abstract void SpecialPaper();

        private void SoftSkill()
        {
            Console.WriteLine("SoftSkills");
        }

        private void Math()
        {
            Console.WriteLine("Mathematics");
        }
    }
}
