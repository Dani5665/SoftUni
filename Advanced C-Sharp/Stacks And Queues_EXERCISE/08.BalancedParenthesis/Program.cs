using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] arr = input.ToCharArray();

            Stack<char> left = new Stack<char>();
            Queue<char> right = new Queue<char>();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                left.Push(arr[i]);
            }
            for (int i = arr.Length / 2; i < arr.Length; i++)
            {
                right.Enqueue(arr[i]);
            }

            bool balanced = true;
            if (input.Length == 0)
            {
                Console.WriteLine("NO");
                goto END;
            }
            if (input.Length % 2 == 0)
            {

                for (int i = 0; i < arr.Length / 2; i++)
                {
                    char leftSide = left.Pop();
                    char rightSide = right.Dequeue();
                    if (leftSide == '(' && rightSide != ')')
                    {
                        balanced = false;
                        break;
                    }
                    else if (leftSide == '[' && rightSide != ']')
                    {
                        balanced = false;
                        break;
                    }
                    else if (leftSide == '{' && rightSide != '}')
                    {
                        balanced = false;
                        break;
                    }
                }

                if (balanced)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {

                Console.WriteLine("NO");
            }
        END:;
        }
    }
}
