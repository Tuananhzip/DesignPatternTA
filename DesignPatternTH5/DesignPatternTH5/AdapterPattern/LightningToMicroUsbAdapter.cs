using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH5.AdapterPattern
{
    internal class LightningToMicroUsbAdapter : IMicroUsbPhone
    {
        private readonly ILightningPhone lightningPhone;
        public LightningToMicroUsbAdapter(ILightningPhone lightningPhone)
        {
            this.lightningPhone = lightningPhone;
        }
        public void Recharge()
        {
            lightningPhone.Recharge();
        }

        public void UseMicroUsb()
        {
            Console.WriteLine("MicroUsb connected");
            lightningPhone.UseLightning();
        }
    }
}
