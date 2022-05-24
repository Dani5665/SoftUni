using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[i] <= arr1[j])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{arr1[i]} ");
                }
            }

        }    
    }
}
