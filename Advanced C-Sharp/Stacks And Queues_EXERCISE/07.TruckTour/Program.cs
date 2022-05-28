using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> myQueue = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                myQueue.Enqueue(input);               
            }

            int index = 0;
            int fuel = 0;
            while (true)
            {
                fuel = 0;
                foreach (var item in myQueue)
                {
                    int[] currentStation = item
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                    int currFuel = currentStation[0];
                    int currDistance = currentStation[1];
                    fuel += currFuel - currDistance;
                    if (fuel < 0)
                    {
                        myQueue.Enqueue(myQueue.Dequeue());
                        index++;
                        break;
                    }
                }
                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                
            }
            
        }
    }
}
