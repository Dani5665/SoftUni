using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int[]> operation = null;
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));

            string command = Console.ReadLine();

            while (command!="end")
            {
                if (command=="add")
                {
                    operation = numbers => 
                    {
                        for (int i = 0; i < list.Length; i++)
                        {
                            list[i] += 1;
                        }
                        return numbers;
                    };
                    operation(list);
                }
                else if (command=="multiply")
                {
                    operation = x =>
                    {
                        for (int i = 0; i < list.Length; i++)
                        {
                            list[i] *= 2;
                        }
                        return list;
                    };
                    operation(list);
                }
                else if (command=="subtract")
                {
                    operation = x =>
                    {
                        for (int i = 0; i < list.Length; i++)
                        {
                            list[i] -= 1;
                        }
                        return list;
                    };
                    operation(list);
                }
                else if (command=="print")
                {
                    print(list);
                }
                command = Console.ReadLine();
            }
        }
    }
}
