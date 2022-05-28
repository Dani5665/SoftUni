using System;
using System.Collections.Generic;
using System.Data;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> carQueue = new Queue<string>();

            string command = Console.ReadLine();
            int carCounter = 0;

            while (command != "END")
            {
                if (command == "green")
                {
                    if (carQueue.Count > 0)
                    {
                        string currentCar = carQueue.Dequeue();
                        int timeToPass = greenLight + freeWindow;

                        while (timeToPass > 0)
                        {
                            if (currentCar.Length > timeToPass)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {currentCar.Substring(timeToPass, 1)}.");
                                goto endProgram;
                            }
                            else
                            {
                                carCounter++;
                                timeToPass -= currentCar.Length;
                                if (timeToPass <= freeWindow)
                                {
                                    goto newCommand;
                                }
                                else
                                {
                                    if (carQueue.Count > 0)
                                    {
                                        currentCar = carQueue.Dequeue();
                                    }
                                    else
                                    {
                                        goto newCommand;
                                    }
                                }
                            }
                        }
                    }

                }
                else
                {
                    carQueue.Enqueue(command);
                }
                newCommand:;
                command = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCounter} total cars passed the crossroads.");
        endProgram:;
        }
    }
}
