﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH5.FlyweightPattern
{
    internal class LargeRobot : IRobot
    {
        public void Print()
        {
            Console.WriteLine("I'm a large Robot");
        }
    }
}