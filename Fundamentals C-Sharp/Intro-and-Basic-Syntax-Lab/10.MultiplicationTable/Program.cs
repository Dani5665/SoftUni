using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 1;
            for (int i = 0; i < 10; i++)
            {
                int res = 0;
                res = n * times;
                Console.WriteLine($"{n} X {times} = {res}");
                res = 0;
                times++;


            }
        }
    }
}
