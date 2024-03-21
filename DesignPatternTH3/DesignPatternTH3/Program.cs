using DesignPatternTH3.AvocadoFactoryMethodPattern;
using DesignPatternTH3.BuilderPattern;
using DesignPatternTH3.FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mẫu 1 - Bài 1: Builder
            Console.WriteLine("***Builder Pattern Demo***");
            Director director = new Director();
            IBuilder b1 = new Car("Ford");
            IBuilder b2 = new MotorCycle("Honda");

            //Making Car
            director.Construct(b1);
            Product p1 = b1.GetVehical();
            p1.Show();

            //Making Motorcycle
            director.Construct(b2);
            Product p2 = b2.GetVehical();
            p2.Show();

            Console.Write("\npress any key to continue...");
            Console.ReadLine();

            //Mẫu 2 - Bài 1: Factory Method
            Client client = new Client();
            client.Run();

            //Mẫu 2 - Bài 2: Factory Method
            AvocadoClient avocadoClient = new AvocadoClient();
            avocadoClient.Run();
        }
    }
}
