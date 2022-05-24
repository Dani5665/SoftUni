using System;
using System.Linq; 

namespace _4.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = string.Join(' ', Console.ReadLine()
                .Split()
                .Reverse()
                .ToArray());
            Console.WriteLine(arr);
                
        }
    }
}
