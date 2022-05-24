using System;
using System.Collections.Generic;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '(')
                {
                    indexes.Push(i);
                }
                else if (ch == ')')
                {
                    int startindex = indexes.Pop();
                    string textToPrint = input.Substring(startindex, i - startindex + 1);
                    Console.WriteLine(textToPrint);
                }
            }
        }
    }
}
