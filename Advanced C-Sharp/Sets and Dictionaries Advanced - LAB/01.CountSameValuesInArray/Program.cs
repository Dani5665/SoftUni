using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> counter = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (counter.ContainsKey(input[i]) == false)
                {
                    counter.Add(input[i], 0);
                }
                counter[input[i]]++;
            }

            foreach (var number in counter)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
