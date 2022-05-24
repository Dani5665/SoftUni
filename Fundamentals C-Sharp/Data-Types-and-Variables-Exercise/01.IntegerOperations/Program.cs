using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int result = ((n + n1) / n2) * n3;

            Console.WriteLine(result);

        }
    }
}
