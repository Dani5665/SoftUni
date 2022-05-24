using System;
using System.Linq;

namespace _3.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double[] arr2 = new double[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == -0)
                {
                    arr2[i] = -0;
                }
                else
                {
                arr2[i] = Math.Round(arr1[i], MidpointRounding.AwayFromZero);
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {               
                Console.WriteLine($"{arr1[i]} => {arr2[i]}");                
            }

        }
    }
}
