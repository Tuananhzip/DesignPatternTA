using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH5.AdapterPattern
{
    internal class Android : IMicroUsbPhone
    {
        private bool connector;
        public void Recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharge started");
                Console.WriteLine("Recharge finished");
            }
            else
            {
                Console.WriteLine("Connect micro usb first");
            }
        }

        public void UseMicroUsb()
        {
            connector = true;
            Console.WriteLine("MicroUsb connected");
        }
    }
}
