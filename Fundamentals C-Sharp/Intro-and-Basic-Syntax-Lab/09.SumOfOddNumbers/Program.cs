using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currnum = 1;
            for (int i = 0; i < n; i++)
            {
                sum += currnum;
                Console.WriteLine(currnum);
                currnum += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
