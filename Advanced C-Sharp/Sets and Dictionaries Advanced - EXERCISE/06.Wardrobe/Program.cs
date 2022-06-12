using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currColour = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                if (wardrobe.ContainsKey(currColour) == false)
                {
                    wardrobe.Add(currColour, new Dictionary<string, int>());
                }
                
                    foreach (var currItem in clothes)
                    {
                        if (wardrobe[currColour].ContainsKey(currItem) == false)
                        {
                            wardrobe[currColour].Add(currItem, 0);
                        }
                        wardrobe[currColour][currItem]++;
                    }
                
            }
            string[] itemToLookFor = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string item = itemToLookFor[1];
            string colour = itemToLookFor[0];

            foreach (var colourr in wardrobe)
            {
                if (colourr.Key == colour)
                {
                    Console.WriteLine($"{colourr.Key} clothes:");
                    foreach (var itemm in colourr.Value)
                    {
                        if (itemm.Key == item)
                        {
                            Console.WriteLine($"* {itemm.Key} - {itemm.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {itemm.Key} - {itemm.Value}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"{colourr.Key} clothes:");
                    foreach (var itemm in colourr.Value)
                    {
                        Console.WriteLine($"* {itemm.Key} - {itemm.Value}");
                    }
                }
            }
        }
    }
}
