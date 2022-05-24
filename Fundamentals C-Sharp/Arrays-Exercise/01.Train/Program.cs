using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "end")
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    train.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i <= train.Count - 1; i++)
                    {
                        if (train[i] + int.Parse(command[0]) <= wagonCapacity)
                        {
                            train[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}
