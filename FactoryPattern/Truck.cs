﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Truck : IVehicle

    {
        public void Drive()
        {
            Console.WriteLine( "This is a truck ");
        }
    }
}
