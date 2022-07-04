using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);              
            }

            int[] swapCommand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.SwapItems(swapCommand[0], swapCommand[1]);

            Console.WriteLine(box);
        }
    }
    
}
