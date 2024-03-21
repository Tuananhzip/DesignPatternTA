using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH7.TemplateMethod
{
    internal abstract class BasicBread
    {
        public void Make()
        {
            MixIngredients();
            Bake();
            Slide();
        }
        private void MixIngredients()
        {
            Console.WriteLine("Mixing ingredients for bread");
        }

        private void Bake()
        {
            Console.WriteLine("Baking for bread");
        }

        public abstract void Slide();
    }
}
