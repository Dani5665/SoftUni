using System;

namespace MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int times = m;
            for (int i = m; i <= 10; i++)
            {
                int res = 0;
                res = n * times;
                Console.WriteLine($"{n} X {times} = {res}");
                res = 0;
                times++;
            }
            if (times > 10)
            {
                int resIfOver10 = n * m;
                Console.WriteLine($"{n} X {m} = {resIfOver10}");
            }
        }
    }
}
