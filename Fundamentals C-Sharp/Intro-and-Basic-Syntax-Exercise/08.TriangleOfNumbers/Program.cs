﻿using System;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
