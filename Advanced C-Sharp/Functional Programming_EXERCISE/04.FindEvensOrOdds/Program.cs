using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numbers = Enumerable.Range(input[0], input[1]-input[0]+1);

            string command = Console.ReadLine();

            if (command == "even")
            {
                Console.WriteLine(string.Join(" ",numbers.Where(x=>x%2==0)));
            }
            else if (command == "odd")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
            }
        }
    }
}
