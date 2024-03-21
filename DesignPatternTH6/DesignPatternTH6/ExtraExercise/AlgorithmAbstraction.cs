using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH6.ExtraExercise
{
    internal abstract class AlgorithmAbstraction
    {
        protected IAlgorithm algorithm;
        public IAlgorithm Algorithm
        {
            get { return algorithm; }
            set { algorithm = value; }
        }
        public abstract void SolveSolution();
    }
}
