﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH7.Strategy
{
    internal class ThanhToanTrucTiep : IChoice
    {
        public void MyChoice()
        {
            Console.WriteLine("Thanh Toán Trực Tiếp");
        }
    }
}
