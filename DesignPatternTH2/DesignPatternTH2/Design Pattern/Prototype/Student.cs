using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH2.Design_Pattern.Prototype
{
    internal abstract class Student
    {
        public string name {  get; set; }
        public string diaChi { get; set; }
        public int tuoi { get; set; }
        public static string SetStatus()
        {
            return "Sinh vien di hoc";
        }
        public abstract Student Clone();
    }
}
