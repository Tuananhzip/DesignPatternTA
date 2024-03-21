using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH3.AvocadoFactoryMethodPattern
{
    internal class AvocadoClient
    {
        public void Run()
        {
            Console.WriteLine("***Avocado Factory Method Pattern Demo***");

            JapanFactory japanFactory = new JapanFactory();
            BrazilFactory brazilFactory = new BrazilFactory();
            IProduct productA = japanFactory.CreateProduct();
            IProduct productB = brazilFactory.CreateProduct();
            for(int i = 1; i <= 12; i++)
            {
                if (i == 1 || i == 2 || i == 3 || i == 4)
                {
                    Console.Write("Month {0}: ",i);
                    productA.ShipForm();
                }
                else
                {
                    Console.Write("Month {0}: ", i);
                    productB.ShipForm();
                }
            }
            Console.Write("press any key to continue...");
            Console.ReadLine();
        }
    }
}
