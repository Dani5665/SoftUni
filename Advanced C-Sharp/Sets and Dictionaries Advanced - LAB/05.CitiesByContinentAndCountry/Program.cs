using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (continents.ContainsKey(continent) == false)
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }
                if (continents[continent].ContainsKey(country) == false)
                {
                    continents[continent].Add(country, new List<string>());
                }
                continents[continent][country].Add(city);
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var county in continent.Value)
                {
                    Console.WriteLine($"  {county.Key} -> {string.Join(", ", county.Value)}");
                }
            }
        }
    }
}
