using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH1.Animals
{
    internal class Whale : Animal
    {
        private string WhaleKind { get; set; }
        public Whale() : base() 
        {
            WhaleKind = "";
        }
        public Whale(string name, int old, double weight, string whaleKind) : base(name,old,weight)
        {
            WhaleKind = whaleKind;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai ca voi: ");
            WhaleKind = Console.ReadLine();
        }
        public override string Output()
        {
            return base.Output() + $", Whale kind: {WhaleKind}";
        }
        public string Fish()
        {
            return $"{Name} is fishing";
        }
    }
}
