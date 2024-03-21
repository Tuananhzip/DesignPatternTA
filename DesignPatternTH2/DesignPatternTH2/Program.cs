using DesignPatternTH2.Design_Pattern.Prototype;
using DesignPatternTH2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Singleton Pattern Demo***\n");
            Console.WriteLine("Trying to create instance s1");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Trying to create instance s2");
            Singleton s2 = Singleton.Instance;
            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n");

            Console.WriteLine("***Prototype Pattern Demo***\n");
            //Base or Original Copy
            BasicCar nanoBase = new Nano("Green Nano") { Price = 100000 };
            BasicCar fordBase = new Ford("Red Ford") { Price = 100000 };
            BasicCar basicCar1;

            //Nano
            basicCar1 = nanoBase.Clone();
            basicCar1.Price = nanoBase.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1} ", basicCar1.ModelName, basicCar1.Price);

            //Ford
            basicCar1 = fordBase.Clone();
            basicCar1.Price = fordBase.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1} ", basicCar1.ModelName, basicCar1.Price);

            Console.WriteLine("\n\n\n\n\n\n");
            ChuyenToan chuyenToan = new ChuyenToan("Tuan Anh", "828 Su Van Hanh", 20);
            ChuyenTin chuyenTin = new ChuyenTin("Tuan Em", "282 Cao thang", 19);
            Console.WriteLine("Toi ten la {0} : {1} : {2}.", chuyenToan.name, Student.SetStatus(), chuyenToan.DiThiChuyenToan());
            Console.WriteLine("Toi ten la {0} : {1} : {2}.", chuyenTin.name, Student.SetStatus(), chuyenTin.DiThiChuyenTin());
            Student students;

            //Chuyên Toán
            students = chuyenToan.Clone();
            Console.WriteLine("Toi ten la {0} : {1} : {2}.",students.name,Student.SetStatus(),chuyenToan.DiThiChuyenToan());

            //Chuyên Tin
            students = chuyenTin.Clone();
            Console.WriteLine("Toi ten la {0} : {1} : {2}.", students.name, Student.SetStatus(), chuyenTin.DiThiChuyenTin());
            Console.ReadLine();
        }
    }
}
