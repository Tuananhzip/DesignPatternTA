using DesignPatternTH1.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH1
{
    internal class Program
    {
        private static object liona;

        static void Main(string[] args)
        {
            //Bài 1:
            Car[] cars = new Car[5];
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Nhap thong tin xe thu {i + 1}");
                cars[i] = new Car();
                cars[i].Input();
            }
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write($"Xe {i + 1} -> ");
                cars[i].Output();
                Console.WriteLine();
            }

            //Bài 2:
            Ford ford1 = new Ford();
            Ford ford2 = new Ford();

            Console.WriteLine(ford1.Run());

            Console.WriteLine("Nhap thong tin xe Ford 1: ");
            ford1.FordInput();

            Console.WriteLine("Nhap thong tin xe Ford 2: ");
            ford2.FordInput();

            ford1.FordOutput();
            ford2.FordOutput();

            ford1.Total(ford1, ford2);

            //Bài 3:
            Animal animal = new Animal();
            animal.Input();
            Console.WriteLine(animal.Output());
            Console.WriteLine(animal.Eat());

            //Bài 4:
            Animal[] animals = new Animal[5];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Nhap thong tin con su tu {i + 1}:");
                Lion lion = new Lion();
                lion.Input();
                animals[i] = lion;
            }
            for (int i = 2; i < 5; i++)
            {
                Console.WriteLine($"Nhap thong tin con ca voi {i - 1}:");
                Whale whale = new Whale();
                whale.Input();
                animals[i] = whale;
            }
            Animal heaviestAnimal = GetHeaviestAnimal(animals);
            Console.WriteLine($"\nDong vat nang nhat la:");
            Console.WriteLine(heaviestAnimal.Output());
            if (heaviestAnimal is Lion lionKind)
            {
                Console.WriteLine(lionKind.Hunt());
            }
            else if (heaviestAnimal is Whale whaleKind)
            {
                Console.WriteLine(whaleKind.Fish());
            }

            Console.ReadLine();
        }
        static Animal GetHeaviestAnimal(Animal[] animals)
        {
            Animal heaviestAnimal = null;
            double maxWeight = 0;
            foreach(Animal animal in animals)
            {
                if(animal is Lion || animal is Whale)
                {
                    if(animal.Weight > maxWeight)
                    {
                        maxWeight = animal.Weight;
                        heaviestAnimal = animal;
                    }
                }
            }
            return heaviestAnimal;
        }
    }
}
