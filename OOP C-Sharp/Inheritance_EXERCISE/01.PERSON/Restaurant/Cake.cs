﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double CakeGrams = 250;
        private const double CakeCallories = 1000;
        private const decimal CakePrice = 5;
        public Cake(string name) 
            : base(name, CakePrice, CakeGrams, CakeCallories)
        {

        }
    }
}
