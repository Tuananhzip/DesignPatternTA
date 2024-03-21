using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternWinForm.Model
{
    internal class MilkTeaBuilder : IBuilder
    {
        private MilkTea milkTea = new MilkTea();
        public MilkTeaBuilder AddBubble(bool bubble)
        {
            milkTea.bubble = bubble;
            return this;
        }

        public MilkTeaBuilder AddCream(bool cream)
        {
            milkTea.cream = cream;
            return this;
        }

        public MilkTeaBuilder AddFlan(bool flan)
        {
            milkTea.flan = flan;
            return this;
        }

        public MilkTeaBuilder AddFlavor(string flavor)
        {
            milkTea.flavor = flavor;
            return this;
        }
        public MilkTeaBuilder AddSugar(int sugar)
        {
            milkTea.sugar = sugar;
            return this;
        }

        public MilkTeaBuilder AddIce(int ice)
        {
            milkTea.ice = ice;
            return this;
        }

        public MilkTeaBuilder AddSize(string size)
        {
            milkTea.size = size;
            return this;
        }
        public MilkTea Reset()
        {
            milkTea.size = "M";
            milkTea.flavor = "hong tra";
            milkTea.sugar = 100;
            milkTea.ice = 100;
            milkTea.bubble = false;
            milkTea.flan = false;
            milkTea.cream = false;
            return new MilkTea();
        }
        public MilkTea Build()
        {
            return new MilkTea(milkTea.size, milkTea.flavor, milkTea.sugar, milkTea.ice, milkTea.bubble, milkTea.flan, milkTea.cream);
        }
    }
}
