using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int litersInTheTank = 0;

            for (int i = 0; i < n; i++)
            {
                int currLiters = int.Parse(Console.ReadLine());
                if (litersInTheTank + currLiters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    litersInTheTank += currLiters;
                }
            }
            Console.WriteLine(litersInTheTank);

        }
    }
}
