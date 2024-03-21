    using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    internal class MilkTea
    {
        public string size;
        public string flavor;
        public int sugar;
        public int ice;
        public bool bubble;
        public bool flan;
        public bool cream;
        public MilkTea() { }
        public MilkTea(string size, string flavor, int sugar, int ice, bool bubble, bool flan, bool cream)
        {
            this.size = size;
            this.flavor = flavor;
            this.sugar = sugar;
            this.ice = ice;
            this.bubble = bubble;
            this.flan = flan;
            this.cream = cream;
        }
        public override string ToString()
        {
            return $"Size: {size}, Flavor: {flavor}, Sugar: {sugar}%, Ice: {ice}%{(bubble ? ", Bubble" : "")}{(flan ? ", Flan" : "")}{(cream ? ", Cream" : "")}";
        }
    }
}
