using System;
using System.Linq;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> consoleWrite = x => Console.WriteLine(x);

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in input)
            {
                consoleWrite(name);
            }
                
        }
    }
}
