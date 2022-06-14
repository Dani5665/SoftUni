using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x *= 1.2);

            foreach (var item in nums)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
