using System;
using System.Linq;

namespace _6.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int index = 0;
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;
          
                for (int j = i - 1; j >= 0; j--)
                {
                    sumLeft += arr[j];
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    sumRight += arr[k];
                }

                if (sumLeft == sumRight)
                {
                    index = i;
                    goto End;
                }
            }
            End:
            if (sumLeft == sumRight)
            {
            Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
