using System;
using System.Linq;

namespace _2.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDiameters = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            string[,] table = new string[matrixDiameters[0], matrixDiameters[1]];

            for (int row = 0; row < table.GetLength(0); row++)
            {
                string[] tableChars = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                
                
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = tableChars[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < table.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < table.GetLength(1) - 1; col++)
                {
                    if (table[row, col] == table[row, col+1] && table[row, col] == table[row+1, col] 
                        && table[row, col] == table[row+1, col+1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
