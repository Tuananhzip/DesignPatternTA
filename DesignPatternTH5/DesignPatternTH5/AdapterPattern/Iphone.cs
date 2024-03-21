using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH5.AdapterPattern
{
    internal class Iphone : ILightningPhone
    {
        private bool connector;
        public void Recharge()
        {
            if(connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect lightning first");
            }
        }

        public void UseLightning()
        {
            connector = true;
            Console.WriteLine("Lightning connected");
        }
    }
}
