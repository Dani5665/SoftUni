using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (int number in input)
            {
                if (number % 2 == 0)
                {
                    queue.Enqueue(number);
                }
            }

            while (queue.Count > 0)
            {
                if (queue.Count == 1)
                {
                    Console.Write(queue.Dequeue());
                }
                else
                {
                    Console.Write(queue.Dequeue() + ", ");
                }
                
            }
        }
    }
}
