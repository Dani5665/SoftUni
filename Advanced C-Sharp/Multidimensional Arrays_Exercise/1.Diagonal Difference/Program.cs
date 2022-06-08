using System;
using System.Linq;

namespace _1.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] table = new int[n, n];
            for (int row = 0; row < table.GetLength(0); row++)
            {
                int[] rowNumbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = rowNumbers[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            int sum = 0;

            //primary diagonal
            for (int row = 0; row < table.GetLength(0); row++)
            {
                primaryDiagonal += table[row, row];
            }
            //secondary diagonal
            int colBackwards = table.GetLength(1) - 1;
            for (int row = 0; row < table.GetLength(0); row++)
            {
                secondaryDiagonal += table[row, colBackwards];
                colBackwards--;
            }
            //difference
            sum = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(sum);

        }
    }
}
