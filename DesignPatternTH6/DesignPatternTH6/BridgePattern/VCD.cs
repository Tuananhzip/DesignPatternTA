using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH6.BridgePattern
{
    internal class VCD : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\n VCD is functioning at: ");
            state.MoveState();
        }
    }
}
