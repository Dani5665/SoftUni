﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            DefaultFuelConsumption = 10;
            FuelConsumption = DefaultFuelConsumption;
        }
    }
}
