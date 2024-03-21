using DesignPatternTH4.DecoratorHomeWork;
using DesignPatternTH4.DecoratorPattern;
using DesignPatternTH4.Proxy_Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Proxy Pattern
            Console.WriteLine("***Proxy pattern Demo***");
            ICar iCar = new ProxyCar(new Driver(15));
            iCar.DriveCar();

            iCar = new ProxyCar(new Driver(25));
            iCar.DriveCar();

            //Console.ReadLine();

            //Decorator Pattern
            Console.WriteLine("\n\n\n***Decorator pattern Demo***");
            ConcreteComponent cc = new ConcreteComponent();

            DecoratorPattern.AbstractDecorator decorator1 = new ConcreteDecoratorEx1();
            decorator1.SetTheComponent(cc);
            decorator1.MakeHouse();

            Console.WriteLine("----------------------------------------------------");

            DecoratorPattern.AbstractDecorator decorator2 = new ConcreteDecoratorEx2();
            //Adding result from decoretor1
            decorator2.SetTheComponent(decorator1);
            decorator2.MakeHouse();

            //Console.ReadLine();

            //Homework
            Console.WriteLine("\n\n\n***Homework***");
            Student student = new Student("Tuan anh",17,"Su Van Hanh");

            DecoratorHomeWork.AbstractDecorator deco1 = new MathStudent(student);
            deco1.SetComponent(student);
            deco1.DiHoc();

            Console.WriteLine("----------------------------------------------------");

            DecoratorHomeWork.AbstractDecorator deco2 = new ITStudent(student);
            deco2.SetComponent(deco1);
            deco2.DiHoc();

            Console.ReadLine();
        }
    }
}
