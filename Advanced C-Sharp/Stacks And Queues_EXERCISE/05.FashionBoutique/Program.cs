using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());

            int rackCount = 0;

            Stack<int> clothes = new Stack<int>();

            foreach (int item in input)
            {
                clothes.Push(item);
            }
            int currentRackCapacity = 0;
            while (clothes.Count > 0)
            {
                
                int currentCloth = clothes.Peek();

                if (rackCount == 0)
                {
                    rackCount++;
                }
                if (currentRackCapacity + currentCloth <= rackCapacity )
                {
                    currentRackCapacity += currentCloth;
                    clothes.Pop();
                }
                else
                {
                    currentRackCapacity = currentCloth;
                    rackCount++;
                    clothes.Pop();
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
