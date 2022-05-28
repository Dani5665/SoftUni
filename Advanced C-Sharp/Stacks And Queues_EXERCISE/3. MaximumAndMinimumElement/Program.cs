using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();

            int[] input = { 0, 0 };
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                if (input[0] == 1)
                {
                    numbers.Push(input[1]);
                }
                else if (input[0] == 2)
                {
                    numbers.Pop();
                }
                else if (input[0] == 3)
                {
                    if (numbers.Count > 0)
                    {
                        int numToPrint = int.MinValue;
                        foreach (int item in numbers)
                        {
                            if (numToPrint < item)
                            {
                                numToPrint = item;
                            }
                        }
                        Console.WriteLine(numToPrint);
                    }
                }
                else if (input[0] == 4)
                {
                    if (numbers.Count > 0)
                    {
                        int numToPrint = int.MaxValue;
                        foreach (int item in numbers)
                        {
                            if (numToPrint > item)
                            {
                                numToPrint = item;
                            }
                        }
                        Console.WriteLine(numToPrint);
                    }
                }
            }
            if (numbers.Count > 0)
            {
                Console.Write(numbers.Pop());
                while (numbers.Count > 0)
                {
                    Console.Write($", {numbers.Pop()}");
                }
                
            }

        }
    }
}
