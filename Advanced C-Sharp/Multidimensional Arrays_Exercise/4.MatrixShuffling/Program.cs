using System;
using System.Linq;

namespace _4.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] table = new string[size[0], size[1]];

            for (int row = 0; row < table.GetLength(0); row++)
            {
                string[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)                    
                    .ToArray();
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = rowInput[col];
                }
            }

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0] != "END")
            {                
                if (command[0] == "swap")
                {
                    if (command.Length == 5)
                    {
                        int row1 = int.Parse(command[1]);
                        int col1 = int.Parse(command[2]);
                        int row2 = int.Parse(command[3]);
                        int col2 = int.Parse(command[4]);

                        if (row1 >= 0 && row1 < table.GetLength(0) &&
                            row2 >= 0 && row2 < table.GetLength(0) &&
                            col1 >= 0 && col1 < table.GetLength(1) &&
                            col2 >= 0 && col2 < table.GetLength(1))
                        {
                            string first = table[row1, col1];
                            string second = table[row2, col2];


                            table[row1, col1] = second;
                            table[row2, col2] = first;
                            for (int row = 0; row < table.GetLength(0); row++)
                            {
                                for (int col = 0; col < table.GetLength(1); col++)
                                {
                                    Console.Write($"{table[row, col]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
