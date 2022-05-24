using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .Reverse()
                .ToArray();

            Stack<int> numbers = new Stack<int>();
            Stack<string> symbols = new Stack<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    numbers.Push(int.Parse(input[i]));
                }
                else
                {
                    symbols.Push(input[i]);
                }
            }

            int summ = numbers.Pop();

            while (symbols.Count > 0)
            {
                string currSymbol = symbols.Pop();
                if (currSymbol == "+")
                {
                    summ += numbers.Pop();
                }
                else
                {
                    summ -= numbers.Pop();
                }
            }

            Console.WriteLine(summ);
        }
    }
}
