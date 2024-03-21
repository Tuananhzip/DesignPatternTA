using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Model
{
    internal class Director
    {
        public void MilkTeaTradional(MilkTeaBuilder builder)
        {
            builder.Reset();
            builder.AddSize("M")
                   .AddFlavor("hong tra")
                   .AddSugar(100)
                   .AddIce(100)
                   .AddBubble(true);
        }
        public void MilkTeaCream(MilkTeaBuilder builder)
        {
            builder.Reset();
            builder.AddSize("M")
                   .AddFlavor("hong tra")
                   .AddSugar(100)
                   .AddIce(100)
                   .AddCream(true);
        }
        public void MilkTeaFlan(MilkTeaBuilder builder)
        {
            builder.Reset();
            builder.AddSize("M")
                   .AddFlavor("hong tra")
                   .AddSugar(100)
                   .AddIce(100)
                   .AddFlan(true);
        }
        public void MilkTeaBubbleAndFlan(MilkTeaBuilder builder)
        {
            builder.Reset();
            builder.AddSize("M")
                   .AddFlavor("hong tra")
                   .AddSugar(100)
                   .AddIce(100)
                   .AddBubble(true)
                   .AddFlan(true);
        }
        public void MilkTeaBubbleAndCream(MilkTeaBuilder builder)
        {
            builder.Reset();
            builder.AddSize("M")
                   .AddFlavor("hong tra")
                   .AddSugar(100)
                   .AddIce(100)
                   .AddBubble(true)
                   .AddCream(true);
        }
        public void MilkTeaFullTopping(MilkTeaBuilder builder)
        {
            builder.Reset();
            builder.AddSize("M")
                   .AddFlavor("hong tra")
                   .AddSugar(100)
                   .AddIce(100)
                   .AddBubble(true)
                   .AddFlan(true)
                   .AddCream(true);      
        }
    }
}
