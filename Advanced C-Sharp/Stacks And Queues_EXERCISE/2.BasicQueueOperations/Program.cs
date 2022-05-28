using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.BasicQueueOperations
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

            Queue<int> numbers = new Queue<int>();

            int N = input[0];
            int S = input[1];
            int X = input[2];

            int[] givenNumbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < N; i++)
            {

                numbers.Enqueue(givenNumbers[i]);
            }

            for (int i = 0; i < S; i++)
            {
                numbers.Dequeue();
            }

            bool condition = false;
            Queue<int> checkedNumbers = new Queue<int>();

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
                    numbers.Dequeue();
                    checkedNumbers.Enqueue(numberToCheck);
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
                        int currNumber = checkedNumbers.Dequeue();
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
