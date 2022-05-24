using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            int count = int.Parse(Console.ReadLine());

            Queue<string> participants = new Queue<string>();

            foreach (string name in input)
            {
                participants.Enqueue(name);
            }

            while (participants.Count > 0)
            {
                if (participants.Count == 1)
                {
                    Console.WriteLine($"Last is {participants.Dequeue()}");
                }
                else
                {
                    for (int i = 1; i <= count; i++)
                    {
                        if (i % count == 0)
                        {
                            Console.WriteLine($"Removed {participants.Dequeue()}");
                        }
                        else
                        {
                            string currPerson = participants.Dequeue();
                            participants.Enqueue(currPerson);
                        }
                    }
                }
            }
            
        }
    }
}
