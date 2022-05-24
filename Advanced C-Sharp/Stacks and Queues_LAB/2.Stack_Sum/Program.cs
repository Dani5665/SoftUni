using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (int number in numbers)
            {
                stack.Push(number);
            }

            bool opt = false;

            while (opt == false)
            {
                string[] input = Console.ReadLine()
                .Split()
                .ToArray();

                string command = input[0].ToLower();

                if (command != "end")
                {
                    if (command == "add")
                    {
                        int num1 = int.Parse(input[1]);
                        int num2 = int.Parse(input[2]);
                        stack.Push(num1);
                        stack.Push(num2);
                    }
                    else if (command == "remove")
                    {
                        int index = int.Parse(input[1]);
                        if (stack.Count >= index)
                        {
                            for (int i = 0; i < index; i++)
                            {
                                stack.Pop();
                            }
                        }
                    }
                }
                else
                {
                    opt = true;
                }
            }

            int summ = 0;
            while (stack.Count != 0)
            {
                summ += stack.Pop();
            }
            Console.WriteLine($"Sum: {summ}");
        }
    }
}
