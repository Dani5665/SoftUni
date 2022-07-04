using System;
using System.Linq;

namespace _05.GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CheckItems(elementToCompare));
        }
    }
}
