using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] currElements = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < currElements.Length; j++)
                {
                    if (elements.Contains(currElements[j]) == false)
                    {
                        elements.Add(currElements[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
