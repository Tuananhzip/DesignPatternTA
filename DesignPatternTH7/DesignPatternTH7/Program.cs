using DesignPatternTH7.Strategy;
using DesignPatternTH7.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 1:
            Console.WriteLine("Bài 1:");
            Console.WriteLine("***Strategy Pattern Demo***");
            IChoice choice = null;
            Context context = new Context();
            for(int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\nEnter ur choice(1 or 2)");
                string c = Console.ReadLine();
                if (c.Equals("1"))
                {
                    choice = new FirstChoice();
                }
                else
                {
                    choice = new SecondChoice();
                }
                context.SetChoice(choice);
                context.ShowChoice();
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            // Bài 2:
            Console.WriteLine("\nBài 2:");
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("\nEnter ur choice(1 or 2)");
                string c = Console.ReadLine();
                if (c.Equals("1"))
                {
                    choice = new ThanhToanTrucTiep();
                }
                else
                {
                    choice = new ThanhToanTraGop();
                }
                context.SetChoice(choice);
                context.ShowChoice();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // Bài 3:
            Console.WriteLine("\nBài 3:");
            Console.WriteLine("***Template Method Pattern Demo***");
            BasicEngineering basicEngineering = new ComputerScience();
            Console.WriteLine("Computer sc Papers:");
            basicEngineering.Papers();
            Console.WriteLine();
            basicEngineering = new Electronics();
            Console.WriteLine("Electronics Papers:");
            basicEngineering.Papers();
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            // Bài 4:
            Console.WriteLine("\nBài 4:");
            BasicBread basicBread;
            for(int i = 1;i <= 2;i++)
            {
                if(i == 1)
                {
                    Console.WriteLine("SweetBread make:");
                    basicBread = new SweetBread();
                }
                else
                {
                    Console.WriteLine("SourBread make:");
                    basicBread = new SourBread();
                }
                basicBread.Make();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
