using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNameTown = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = inputNameTown[0] + " " + inputNameTown[1];
            string town = inputNameTown[2];
            if (inputNameTown.Length == 4)
            {
                town = inputNameTown[2] + " " + inputNameTown[3];
            }                      
            MyTuple<string, string> nameTown =
                new MyTuple<string, string>(name, town);

            string[] inputNameLiters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name2 = inputNameLiters[0];
            int liters = int.Parse(inputNameLiters[1]);
            MyTuple<string, int> nameLiters =
                new MyTuple<string, int>(name2, liters);

            string[] inputNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int num1 = int.Parse(inputNumbers[0]);
            double num2 = double.Parse(inputNumbers[1]);
            MyTuple<int, double> numbers =
                new MyTuple<int, double>(num1, num2);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameLiters.GetItems());
            Console.WriteLine(numbers.GetItems());
        }
    }
}
