using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternWinForm.Model
{
    internal interface IBuilder
    {
        MilkTeaBuilder AddSize(string size);
        MilkTeaBuilder AddFlavor(string flavor);
        MilkTeaBuilder AddSugar(int sugar);
        MilkTeaBuilder AddIce(int ice);
        MilkTeaBuilder AddBubble(bool bubble);
        MilkTeaBuilder AddFlan(bool flan);
        MilkTeaBuilder AddCream(bool cream);
        MilkTea Reset();
        MilkTea Build();
    }
}
