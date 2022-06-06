using System;
using System.Linq;

namespace _3.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] table = new int[n, n];

            for (int row = 0; row < table.GetLength(0); row++)
            {
                int[] colNumbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = colNumbers[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < table.GetLength(0); row++)
            {
                sum += table[row, row];
            }
            Console.WriteLine(sum);

        }
    }
}
