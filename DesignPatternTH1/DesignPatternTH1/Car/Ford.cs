using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH1
{
    internal class Ford : Car
    {
        public int WarrantyYears { get; set; }
        public Ford():base() { }
        public Ford(double MaxSpeed, int Seat, int Year,int warrantyYears) : base(MaxSpeed,Seat,Year)
        {
            WarrantyYears = warrantyYears;
        }
        public void FordInput()
        {
            Input();
            Console.Write("Input Warranty Years: ");
            WarrantyYears = int.Parse(Console.ReadLine());
        }
        public string FordOutput()
        {
            return Output() + ",Warranty Years: "+ WarrantyYears;
        }
        public string Run()
        {
            return "Ford is running";
        }
        public void Total(Ford ford1,Ford ford2)
        {
            int totalWarrantyYears = ford1.WarrantyYears + ford2.WarrantyYears;
            Console.WriteLine($"Total Warranty Years is: {totalWarrantyYears}");
            if(ford1.Seat > ford2.Seat)
            {
                Console.WriteLine($"Xe Ford 1 co '{ford1.Seat}' ghe nhieu hon Ford 2 '{ford1.Seat - ford2.Seat}' ghe");
            }
            else if(ford1.Seat < ford2.Seat)
            {
                Console.WriteLine($"Xe Ford 2 co '{ford2.Seat}' ghe nhieu hon Ford 1 '{ford2.Seat - ford1.Seat}' ghe");
            }
            else
            {
                Console.WriteLine($"Ca 2 xe deu co so ghe bang nhau {ford1.Seat} ghe Ford 1 : {ford2.Seat} ghe Ford 2");
            }
        }
    }
}
