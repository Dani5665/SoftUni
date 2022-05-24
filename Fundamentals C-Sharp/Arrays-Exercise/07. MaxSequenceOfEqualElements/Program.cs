using System;
using System.Linq;

namespace _7._MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int seqLenght = 1;
            int seqNumber = arr[0];
            int currLenght = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currNumber = arr[i];

                if (arr[i] == arr[i + 1])
                {
                    currLenght++;
                    
                    if (seqLenght < currLenght)
                    {
                        seqLenght ++;
                        seqNumber = currNumber;
                    }
                }
                else
                {
                    currLenght = 1;
                }
            }

            string[] newArr = new string[seqLenght];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = seqNumber.ToString();
            }

            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}
