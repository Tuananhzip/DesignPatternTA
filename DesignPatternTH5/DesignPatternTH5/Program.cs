using DesignPatternTH5.AdapterPattern;
using DesignPatternTH5.FlyweightPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------- Adapter Pattern -----------------\\
            Console.WriteLine("***Adapter Pattern Demo***\n");
            Android android = new Android();
            Iphone iphone = new Iphone();

            Console.WriteLine("Recharging android with MicroUsb");
            RechargeMicroUsbPhone(android);
            Console.WriteLine();

            Console.WriteLine("Recharging iphone with Lightning");
            RechargeLightningPhone(iphone);
            Console.WriteLine();

            Console.WriteLine("Recharging iphone with MicroUsb");
            RechargeMicroUsbPhone(new LightningToMicroUsbAdapter(iphone));

            //----------------- Flyweight Pattern -----------------\\
            Console.WriteLine("\n***Flyweight Pattern Demo***\n");
            RobotFactory robotFactory = new RobotFactory();
            IRobot shape = robotFactory.GetRobotFromFactory("Small");
            shape.Print();

            for(int i = 0;i < 2; i++)
            {
                shape = robotFactory.GetRobotFromFactory("Small");
                shape.Print();
            }
            int numOfDistinctRobots = robotFactory.TotalObjectCreated;
            Console.WriteLine($"\nNow, total numbers of distinct robot object is = {numOfDistinctRobots}\n");
            
            for(int i = 0; i < 5; i++)
            {
                shape = robotFactory.GetRobotFromFactory("Large");
                shape.Print();
            }
            numOfDistinctRobots = robotFactory.TotalObjectCreated;
            Console.WriteLine($"\nNow, total numbers of distinct robot object is = {numOfDistinctRobots}\n");

            Console.ReadLine();
        }
        static void RechargeMicroUsbPhone(IMicroUsbPhone phone)
        {
            phone.UseMicroUsb();
            phone.Recharge();
        }
        static void RechargeLightningPhone(ILightningPhone phone)
        {
            phone.UseLightning();
            phone.Recharge();
        }
    }
}
