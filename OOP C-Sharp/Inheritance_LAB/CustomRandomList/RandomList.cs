﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int index = random.Next(0, Count);
            return this[index];
        }
        public void RemoveRandomElement()
        {
            Random random = new Random();
            int index = random.Next(0, Count);
            this.RemoveAt(index);
        }
    }
}
