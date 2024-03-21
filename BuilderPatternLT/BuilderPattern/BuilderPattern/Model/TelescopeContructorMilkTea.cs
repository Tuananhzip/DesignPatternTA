using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    internal class TelescopeContructorMilkTea
    {
        public string size;
        public string flavor;
        public int sugar;
        public int ice;
        public bool bubble;
        public bool flan;
        public bool cream;

        //Best practice
        public TelescopeContructorMilkTea() : this("M") { }
        public TelescopeContructorMilkTea(string size) : this(size, "hong tra") { }
        public TelescopeContructorMilkTea(string size, string flavor) : this(size, flavor, 100) { }
        public TelescopeContructorMilkTea(string size, string flavor, int sugar) : this(size, flavor, sugar, 100) { }
        public TelescopeContructorMilkTea(string size, string flavor, int sugar,int ice) : this(size, flavor, sugar, ice, false){ }
        public TelescopeContructorMilkTea(string size, string flavor, int sugar, int ice, bool bubble) : this(size, flavor, sugar, ice, bubble, false) { }
        public TelescopeContructorMilkTea(string size, string flavor, int sugar, int ice, bool bubble, bool flan) : this(size, flavor, sugar, ice, bubble, flan, false) { }
        public TelescopeContructorMilkTea(string size, string flavor, int sugar, int ice, bool bubble, bool flan, bool cream)
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







        /*//giải quyết telescope contructor chúng ta có thể dùng theo ngôn ngữ Java JavaBeans setter các giá trị optional khi cần        
        public void setSize(string size)
        {
            this.size = size;
        }
        public void setFlavor(string flavor)
        {
            this.flavor = flavor;
        }
        public void setSugar(int sugar)
        {
            this.sugar = sugar;
        }
        public void setIce(int ice)
        {
            this.ice = ice;
        }
        public void setBubble(bool bubble)
        {
            this.bubble = bubble;
        }
        public void setFlan(bool flan)
        {
            this.flan = flan;
        }
        public void setCream(bool cream)
        {
            this.cream = cream;
        }*/
    }
}
