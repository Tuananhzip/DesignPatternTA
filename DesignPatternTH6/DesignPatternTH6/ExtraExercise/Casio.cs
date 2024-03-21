using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH6.ExtraExercise
{
    internal class Casio : AlgorithmAbstraction
    {
        public override void SolveSolution()
        {
            Console.WriteLine("Đang giải toán trong Casio:");
            algorithm.Solve();
        }
    }
}
