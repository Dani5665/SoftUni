using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isDivisible = (x, y) => x % y != 0;

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());

            numbers = numbers.Where(x => isDivisible(x, num))
                .Reverse()
                .ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
