using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (input[0] != "Revision")
            {
                string shopName = input[0];
                string itemName = input[1];
                double itemPrice = double.Parse(input[2]);

                if (shops.ContainsKey(shopName) == false)
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }
                shops[shopName].Add(itemName, itemPrice);

                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
