using System;
using System.Linq;

namespace _1.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = {
                  "Monday",
                  "Tuesday",
                  "Wednesday",
                  "Thursday",
                  "Friday",
                  "Saturday",
                  "Sunday"
            };

            int imput = int.Parse(Console.ReadLine());

            if (imput >= 1 && imput <= 7)
            {
                Console.WriteLine(days[imput - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
