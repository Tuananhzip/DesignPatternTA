using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH6.BridgePattern
{
    internal class Television : ElectronicGoods
    {
        public override void MoveToCurrentState()
        {
            Console.WriteLine("\n Television is functioning at: ");
            state.MoveState();
        }
    }
}
