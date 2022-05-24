using System;
using System.Linq;

namespace _3.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int index = 0;
                int[] currArr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (count % 2 == 0)
                {
                    arr1[i] = currArr[index];
                    index++;
                    arr2[i] = currArr[index];
                    index++;
                    count++;
                }
                else
                {
                    arr2[i] = currArr[index];
                    index++;
                    arr1[i] = currArr[index];
                    index++;
                    count++;
                }
            }
                Console.WriteLine(string.Join(" ", arr1));
                Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
