using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH1.Animals
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Old {  get; set; }
        public double Weight { get; set; }
        public Animal() { }
        public Animal(string name, int old, double weight)
        {
            Name = name;
            Old = old;
            Weight = weight;
        }
        public virtual void Input()
        {
            Console.Write("Nhap ten animal: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi animal: ");
            Old = int.Parse(Console.ReadLine());
            Console.Write("Nhap can nang animal: ");
            Weight = double.Parse(Console.ReadLine());
        }
        public virtual string Output()
        {
            return $"{Name} Name, {Old} Old, {Weight} Weight";
        }
        public string Eat()
        {
            return $"{Name} is eating";
        }
    }
}
