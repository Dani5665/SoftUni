using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Person
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        

        public override string ToString()
        {
            string overritedToStringMethod = $"Name: {this.Name}, Age: {this.Age}";
            return overritedToStringMethod;
        }
    }
}
