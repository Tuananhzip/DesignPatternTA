using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH6.CompositePattern
{
    internal class SoftDrink
    {
        public int calories { get; set; }
        public List<SoftDrink> flavors { get; set; }
        public SoftDrink(int calories)
        {
            this.calories = calories;
            this.flavors = new List<SoftDrink>();
        }
        public void DisplayCalories()
        {
            Console.WriteLine(this.GetType().Name + ": " + this.calories.ToString() + " calories.");
            foreach(var item in this.flavors)
            {
                item.DisplayCalories();
            }
        }
    }
}
