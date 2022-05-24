using System;
using System.Collections.Generic;

namespace _8.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            Queue<string> carList = new Queue<string>();

            string input = Console.ReadLine();
            int carCounter = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (carList.Count > 0)
                        {
                            Console.WriteLine($"{carList.Dequeue()} passed!");
                            carCounter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    carList.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{carCounter} cars passed the crossroads.");
        }
    }
}
