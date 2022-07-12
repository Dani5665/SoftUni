using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "1", "2", "3", "4", "5", "6", "7" };
            var stack = new StackOfStrings();
            stack.AddRange(list);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
