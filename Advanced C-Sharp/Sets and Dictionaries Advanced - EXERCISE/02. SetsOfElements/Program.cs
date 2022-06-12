using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            int[] lenghts = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lenghts[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
            }
            for (int i = 0; i < lenghts[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set2.Add(number);
            }

            HashSet<int> repeatedNumbers = new HashSet<int>();

            foreach (var number in set1)
            {
                if (set2.Contains(number) && repeatedNumbers.Contains(number) == false)
                {
                    repeatedNumbers.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", repeatedNumbers));
        }
    }
}
