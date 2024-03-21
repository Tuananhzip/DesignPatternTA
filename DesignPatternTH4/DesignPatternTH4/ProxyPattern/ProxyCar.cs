using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.Proxy_Pattern
{
    internal class ProxyCar : ICar
    {
        private Driver driver;
        private ICar iCar;
        public ProxyCar(Driver driver)
        {
            this.driver = driver;
            iCar = new Car();
        }

        public void DriveCar()
        {
            if(driver.age < 16)
            {
                Console.WriteLine("Sorry, the driver is too young to drive.");
            }
            else
            {
                iCar.DriveCar();
            }
        }
    }
}
