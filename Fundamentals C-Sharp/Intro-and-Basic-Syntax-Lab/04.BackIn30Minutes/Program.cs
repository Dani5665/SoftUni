using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            m += 30;

            if (m > 59)
            {
                m = m % 60;
                h = h + 1;
                if (h > 23)
                {
                    h = 0;
                }
            }
            if (m < 10)
            {
                Console.WriteLine($"{h}:0{m}");
            }
            else
            {
                Console.WriteLine($"{h}:{m}");
            }
        }
    }
}
