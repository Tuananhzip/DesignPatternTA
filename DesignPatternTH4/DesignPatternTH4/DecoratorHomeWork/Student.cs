using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.DecoratorHomeWork
{
    internal class Student : Component
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public Student(string name, int age, string address)
        {
            this.name = name; 
            this.age = age;
            this.address = address;
        }
        public override void DiHoc()
        {
            Console.WriteLine($"Sinh vien {name} dang hoc bai");
        }
    }
}
