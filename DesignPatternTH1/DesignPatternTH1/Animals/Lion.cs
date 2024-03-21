using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH1.Animals
{
    internal class Lion : Animal
    {
        public string LionKind { get; set; }
        public Lion():base() 
        {
            LionKind = "";
        }
        public Lion(string name, int old, double weight, string lionKind) : base(name, old, weight)
        {
            LionKind = lionKind;    
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai su tu: ");
            LionKind = Console.ReadLine();
        }
        public override string Output()
        {
            return base.Output() + $", Lion Kind: {LionKind}";
        }
        public string Hunt()
        {
            return $"{Name} is hunting";
        }
    }
}
