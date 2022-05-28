using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            // N - number of elements to push
            // S - number of elements to pop
            // X - element to look for

            Stack<int> numbers = new Stack<int>();

            int N = input[0];
            int S = input[1];
            int X = input[2];

            int[] givenNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < N; i++)
            {
                
                numbers.Push(givenNumbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                numbers.Pop();
            }

            bool condition = false;
            Stack<int> checkedNumbers = new Stack<int>();

            while (numbers.Count > 0)
            {
                int numberToCheck = numbers.Peek();
                if (numberToCheck == X)
                {
                    condition = true;
                    break;
                }
                else
                {
                    numbers.Pop();
                    checkedNumbers.Push(numberToCheck);
                }
            }

            if (condition == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (checkedNumbers.Count > 0)
                {
                    int numToPrint = int.MaxValue;
                    while (checkedNumbers.Count > 0)
                    {
                        int currNumber = checkedNumbers.Pop();
                        if (numToPrint > currNumber)
                        {
                            numToPrint = currNumber;
                        }
                    }
                    Console.WriteLine(numToPrint);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
