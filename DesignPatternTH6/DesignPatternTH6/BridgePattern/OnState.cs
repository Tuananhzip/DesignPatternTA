using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH6.BridgePattern
{
    internal class OnState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("On State");
        }
    }
}
