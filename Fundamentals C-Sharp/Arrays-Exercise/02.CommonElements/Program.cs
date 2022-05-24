using System;

namespace _2.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split();
            string[] arr2 = Console.ReadLine()
                .Split();
            string[] arr3 = new string[arr1.Length];
            int counter = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        arr3[counter] = arr1[i];
                        counter++;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr3));
        }
    }
}
