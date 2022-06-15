using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double[], double> smallestNumber = x => x.Min();
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Console.WriteLine(smallestNumber(numbers));
        }
    }
}
