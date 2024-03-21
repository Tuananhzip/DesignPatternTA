using DesignPatternTH6.BridgePattern;
using DesignPatternTH6.CompositePattern;
using DesignPatternTH6.ExtraExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài 1: Composite
            var colas = new Cola(210);
            colas.flavors.Add(new VanillaCola(215));
            colas.flavors.Add(new CherryCola(210));

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);
            rootBeers.flavors.Add(new VanillaRootBeer(200));
            rootBeers.flavors.Add(new StrawberryRootBeer(200));

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.flavors.Add(lemonLime);
            sodaWater.flavors.Add(colas);
            sodaWater.flavors.Add(rootBeers);

            sodaWater.DisplayCalories();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //Bài 2: Bridge
            Console.WriteLine("\n\n\n***Bridge Pattern Demo***");

            Console.WriteLine("\n Dealing with a Television:");
            ElectronicGoods eItem = new Television();
            IState presentState = new OnState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();

            presentState = new OffState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();

            Console.WriteLine("\n \n Dealing with a VCD:");
            eItem = new VCD();
            presentState = new OnState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();

            presentState = new OffState();
            eItem.State = presentState;
            eItem.MoveToCurrentState();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

            //Bài làm thêm
            Console.WriteLine("\n\n\n ---Algorithm---");

            IAlgorithm algorithm = new AlgorithmA();
            AlgorithmAbstraction algorithmAbstraction = new Casio();
            algorithmAbstraction.Algorithm = algorithm;
            algorithmAbstraction.SolveSolution();

            algorithm = new AlgorithmB();
            algorithmAbstraction.Algorithm = algorithm;
            algorithmAbstraction.SolveSolution();

            algorithmAbstraction = new Vinacal();
            algorithm = new AlgorithmA();
            algorithmAbstraction.Algorithm = algorithm;
            algorithmAbstraction.SolveSolution();

            algorithm = new AlgorithmB();
            algorithmAbstraction.Algorithm = algorithm;
            algorithmAbstraction.SolveSolution();

            Console.ReadLine();
        }
    }
}
