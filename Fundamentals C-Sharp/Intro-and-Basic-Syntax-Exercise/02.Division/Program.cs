using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int divisibleBy = 0;

            if (a % 2 == 0)
            {
                divisibleBy = 2;
            }
            if (a % 3 == 0)
            {
                divisibleBy = 3;
            }
            if (a % 6 == 0)
            {
                divisibleBy = 6;
            }
            if (a % 7 == 0)
            {
                divisibleBy = 7;
            }
            if (a % 10 == 0)
            {
                divisibleBy = 10;
            }
            if (divisibleBy != 0)
            {
                Console.WriteLine($"The number is divisible by {divisibleBy}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
