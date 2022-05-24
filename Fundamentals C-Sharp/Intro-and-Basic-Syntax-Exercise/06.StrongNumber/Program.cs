using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int total = 0;

            while (number > 0)
            {
                int digit = number % 10;
                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                total += factorial;
                number = number / 10;
            }
            if (total == numberCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
