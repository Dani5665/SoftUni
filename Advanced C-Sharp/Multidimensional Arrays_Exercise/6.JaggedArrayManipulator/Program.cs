using System;
using System.Data;
using System.Linq;

namespace _6.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] table = new double[n][];

            for (int i = 0; i < n; i++)
            {
                int[] token = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                table[i] = new double[token.Length];
                for (int j = 0; j < token.Length; j++)
                {
                    table[i][j] = token[j];
                }
            }

            for (int row = 0; row < table.GetLength(0) - 1; row++)
            {
                if (table[row].Length == table[row+1].Length)
                
                {
                    for (int col = 0; col < table[row].Length; col++)
                    {
                        table[row][col] *= 2;
                    }
                    for (int col = 0; col < table[row+1].Length; col++)
                    {
                        table[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < table[row].Length; col++)
                    {
                        table[row][col] /= 2;
                    }
                    for (int col = 0; col < table[row+1].Length; col++)
                    {
                        table[row+1][col] /= 2;
                    }
                }
            }
            
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "End")
            {
                string currCommand = command[0];
                int currRow = int.Parse(command[1]);
                int currCol = int.Parse(command[2]);
                int currValue = int.Parse(command[3]);

                if (currCommand == "Add")
                {
                    if (currRow >= 0 && currRow < table.GetLength(0))
                    {
                        if (currCol >= 0 && currCol < table[currRow].Length)
                        {
                            table[currRow][currCol] += currValue;
                        }
                    }
                }
                else if (currCommand == "Subtract")
                {
                    if (currRow >= 0 && currRow < table.GetLength(0))
                    {
                        if (currCol >= 0 && currCol < table[currRow].Length)
                        {
                            table[currRow][currCol] -= currValue;
                        }
                    }
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ",table[i]));
            }
        }
    }
}
