using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;

            while (number > 0)
            {
                int currNum = number % 10;
                total += currNum;
                number /= 10;
            }

            Console.WriteLine(total);
        }
    }
}
