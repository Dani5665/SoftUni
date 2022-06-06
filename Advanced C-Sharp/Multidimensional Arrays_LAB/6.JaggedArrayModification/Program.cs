using System;
using System.Linq;
using System.Net.WebSockets;

namespace _6.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] table = new int[n][];

            for (int row = 0; row < table.GetLength(0); row++)
            {
                int[] numbersToAdd = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                table[row] = new int[numbersToAdd.Length];
                for (int col = 0; col < numbersToAdd.Length; col++)
                {
                    table[row][col] += numbersToAdd[col];
                }
            }
            string[] command = Console.ReadLine()
                .Split()
                .ToArray();
            while (command[0] != "END")
            {
                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int num = int.Parse(command[3]);
                    if (row >= 0 && row < table.Length && col >= 0 && col < table[row].Length)
                    {
                        table[row][col] += num;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int num = int.Parse(command[3]);
                    if (row >= 0 && row < table.Length && col >= 0 && col < table[row].Length)
                    {
                        table[row][col] -= num;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                command = Console.ReadLine()
                .Split()
                .ToArray();
            }

            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table[row].Length; col++)
                {
                    Console.Write($"{table[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
