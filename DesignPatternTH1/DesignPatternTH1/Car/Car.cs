using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH1
{
    internal class Car
    {
        private double MaxSpeed { get; set; }
        protected int Seat { get; set; }
        private int Year { get; set; }
        public Car() { }
        public Car(double MaxSpeed,int Seat,int Year)
        {
            this.MaxSpeed = MaxSpeed;
            this.Seat = Seat;
            this.Year = Year;
        }
        public void Input()
        {
            Console.Write("Input Max Speed: ");
            MaxSpeed = double.Parse(Console.ReadLine());
            Console.Write("Input Seat: ");
            Seat = int.Parse(Console.ReadLine());
            Console.Write("Input Year: ");
            Year = int.Parse(Console.ReadLine());
        }
        public string Output()
        {
            return $"Year: {Year}, Max Speed: {MaxSpeed}, Seat: {Seat}";
        }
    }
}
