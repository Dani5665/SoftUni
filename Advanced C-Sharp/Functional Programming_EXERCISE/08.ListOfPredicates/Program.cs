using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            var numsToCheck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var list = Enumerable.Range(1, range);

            Func<IEnumerable<int>, IEnumerable<int>, List<int>> isDividible = (x, y) =>
            {
                List<int> checkedNums = new List<int>();

                foreach (var number1 in x)
                {
                    bool isOk = true;
                    foreach (var number2 in y)
                    {
                        if (number1 % number2 != 0)
                        {
                            isOk = false;
                            continue;
                        }
                    }
                    if (isOk)
                    {
                        checkedNums.Add(number1);
                    }
                }
                return checkedNums;
            };
            var numbersToPrint = isDividible(list, numsToCheck).ToArray();
            Console.WriteLine(string.Join(" ", numbersToPrint));
        }

        
    }
}
