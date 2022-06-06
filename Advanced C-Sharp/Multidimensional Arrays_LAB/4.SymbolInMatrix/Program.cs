using System;
using System.Linq;

namespace _4.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] table = new char[n, n];

            for (int row = 0; row < table.GetLength(0); row++)
            {
                string rowText = Console.ReadLine();
                char[] rowCharArr = rowText.ToCharArray();
                    
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = rowCharArr[col];
                }
            }

            char symbolToCheck = Console.ReadLine()[0];
            bool symbolExists = false;

            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    if (table[row, col] == symbolToCheck)
                    {
                        Console.WriteLine($"({row}, {col})");
                        symbolExists = true;
                        break;
                    }
                }
                    if (symbolExists)
                    {
                    break;
                    }
            }

            if (symbolExists == false)
            {
                Console.WriteLine($"{symbolToCheck} does not occur in the matrix");
            }

        }
    }
}
