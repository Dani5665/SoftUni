using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                ;
            var count = list.Count();
            var average = list.Sum();

            Console.WriteLine(count);
            Console.WriteLine(average);
        }
    }
}
