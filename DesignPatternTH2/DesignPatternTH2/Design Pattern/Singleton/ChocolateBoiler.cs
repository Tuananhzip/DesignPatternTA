using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH2.Model
{
    internal class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        private readonly static ChocolateBoiler instance = new ChocolateBoiler();
        private int numberOfInstances = 0;
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public static ChocolateBoiler Instance
        {
            get
            {
                Console.WriteLine("We already have an instance now. Use it.");
                return instance;
            }
        }
        public void Fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
                //fill the boiler with a milk / chocolate mixture
            }
        }
        public void Drain()
        {
            if(!isEmpty() && !isBoiled()) 
            {
                //drain the boiled milk and chocolate
                empty = true;
            }
        }
        public void Boil()
        {
            if(!isEmpty() && !isBoiled())
            {
                //bring the contents to a boil
                boiled = true;
            }
        }
        public bool isEmpty()
        {
            return empty;   
        }
        public bool isBoiled()
        {
            return boiled;
        }
    }
}
