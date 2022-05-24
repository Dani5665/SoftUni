using System;
using System.Linq;

namespace _7.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = 0;
            int arrSum = 0;
            bool isTrue = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    index = i;
                    isTrue = true;
                    goto End;
                }
                else
                {
                    arrSum += arr1[i];
                }
            }

            End:
            if (isTrue)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {arrSum}");
            }
        }
    }
}
