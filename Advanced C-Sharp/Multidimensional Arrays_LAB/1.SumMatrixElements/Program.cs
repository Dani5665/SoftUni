using System;
using System.Linq;

namespace _1.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] table = new int[input[0], input[1]];
            for (int row = 0; row < table.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = colElements[col];
                }
            }

            int sum = 0;
            foreach (int num in table)
            {
                sum += num;
            }

            Console.WriteLine(table.GetLength(0));
            Console.WriteLine(table.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
