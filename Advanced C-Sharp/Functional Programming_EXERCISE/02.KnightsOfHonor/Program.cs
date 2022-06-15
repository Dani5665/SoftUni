using System;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> consoleWrite = x => Console.WriteLine($"Sir {x}");

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in input)
            {
                consoleWrite(name);
            }
        }
    }
}
