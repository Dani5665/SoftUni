using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            Func<string, bool> nameCheck = x => x.Length <= lenght;

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => nameCheck(x))
                .ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
                
        }
    }
}
