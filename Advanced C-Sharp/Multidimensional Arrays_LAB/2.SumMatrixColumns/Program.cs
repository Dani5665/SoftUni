using System;
using System.Linq;

namespace _2.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int[,] matrixx = new int[matrixSize[0], matrixSize[1]];

            for (int row = 0; row < matrixx.GetLength(0); row++)
            {
                int[] rowNumbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrixx.GetLength(1); col++)
                {
                    matrixx[row, col] = rowNumbers[col];
                }
            }

            for (int col = 0; col < matrixx.GetLength(1); col++)
            {
                int colSum = 0;
                for (int row = 0; row < matrixx.GetLength(0); row++)
                {
                    colSum += matrixx[row, col];
                }
                Console.WriteLine(colSum);
            }
             

        }
    }
}
