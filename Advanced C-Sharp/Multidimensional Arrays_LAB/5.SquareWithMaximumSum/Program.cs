using System;
using System.Linq;

namespace _5.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableDimencions = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] table = new int[tableDimencions[0], tableDimencions[1]];

            for (int row = 0; row < table.GetLength(0); row++)
            {
                int[] rowNums = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = rowNums[col];
                }
            }

            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;
            for (int row = 0; row < table.GetLength(0) - 1; row++)
            {
                int currSum = 0;
                for (int col = 0; col < table.GetLength(1) - 1; col++)
                {
                    currSum = table[row, col] + table[row, col + 1] + table[row + 1, col] + table[row + 1, col + 1];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine($"{table[maxSumRow, maxSumCol]} {table[maxSumRow, maxSumCol + 1]}");
            Console.WriteLine($"{table[maxSumRow + 1, maxSumCol]} {table[maxSumRow + 1, maxSumCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
