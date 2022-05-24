using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double p = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(n / p);

            Console.WriteLine(courses);
        }
    }
}
