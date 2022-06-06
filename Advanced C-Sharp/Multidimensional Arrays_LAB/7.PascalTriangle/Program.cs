using System;

namespace _7.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {


                long[][] triangle = new long[n][];
                triangle[0] = new long[1];
                triangle[0][0] = 1;
                for (int row = 1; row < n; row++)
                {
                    triangle[row] = new long[row + 1];
                    for (int col = 0; col < triangle[row].Length; col++)
                    {
                        if (col == 0)
                        {
                            triangle[row][col] = 1;
                        }
                        else if (col == triangle[row].Length - 1)
                        {
                            triangle[row][col] = 1;
                        }
                        else
                        {
                            triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                        }
                    }
                }

                for (int row = 0; row < triangle.Length; row++)
                {
                    for (int col = 0; col < triangle[row].Length; col++)
                    {
                        Console.Write($"{triangle[row][col]} ");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
