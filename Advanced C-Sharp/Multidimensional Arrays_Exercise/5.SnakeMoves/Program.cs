using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];
            string snake = Console.ReadLine();
            int index = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] snakeCharArr = snake.ToCharArray();
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (index > snake.Length - 1)
                        {
                            index = 0;
                        }
                        matrix[row, col] = snakeCharArr[index].ToString();
                        index++;
                    }
                }
                else
                {
                    int currIndex = matrix.GetLength(1) - 1;
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (index > snake.Length -1)
                        {
                            index = 0;
                        }
                        
                        matrix[row, currIndex] = snakeCharArr[index].ToString();
                        index++;
                        currIndex--;
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
