using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> table = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (table.ContainsKey(ch) == false)
                {
                    table.Add(ch, 0);
                }
                table[ch]++;
            }

            foreach (var ch in table)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
