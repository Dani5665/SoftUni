using System;
using System.Linq;

namespace _3.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimencions = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] table = new int[dimencions[0], dimencions[1]];
            if (dimencions[0] > 2 && dimencions[1] > 2)
            {


                for (int row = 0; row < table.GetLength(0); row++)
                {
                    int[] rowNumbers = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    for (int col = 0; col < table.GetLength(1); col++)
                    {
                        table[row, col] = rowNumbers[col];

                    }
                }

                int sum = int.MinValue;
                int sumRow = 0;
                int sumCol = 0;

                for (int row = 0; row < table.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < table.GetLength(1) - 2; col++)
                    {
                        int currsum = table[row, col] + table[row, col + 1] + table[row, col + 2]
                            + table[row + 1, col] + table[row + 1, col + 1] + table[row + 1, col + 2]
                            + table[row + 2, col] + table[row + 2, col + 1] + table[row + 2, col + 2];
                        if (currsum > sum)
                        {
                            sum = currsum;
                            sumRow = row;
                            sumCol = col;
                        }

                    }
                }

                Console.WriteLine($"Sum = {sum}");
                for (int row = sumRow; row <= sumRow + 2; row++)
                {
                    for (int col = sumCol; col <= sumCol + 2; col++)
                    {
                        Console.Write($"{table[row, col]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
