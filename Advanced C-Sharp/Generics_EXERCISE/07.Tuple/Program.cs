using System;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNameTownAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = inputNameTownAdress[0] + " " + inputNameTownAdress[1];
            string adress = inputNameTownAdress[2];
            string town = inputNameTownAdress[3];
            if (inputNameTownAdress.Length == 5)
            {
                town = inputNameTownAdress[3] + " " + inputNameTownAdress[4];
            }                      
            MyTuple<string, string, string> nameTown =
                new MyTuple<string, string,string>(name,adress,town);

            string[] inputNameLiters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name2 = inputNameLiters[0];
            int liters = int.Parse(inputNameLiters[1]);
            string drunkOrNot = inputNameLiters[2];
            bool drunkOrNotBool = false;
            if (drunkOrNot == "drunk")
            {
                drunkOrNotBool = true;
            }
            MyTuple<string, int, bool> nameLiters =
                new MyTuple<string, int, bool>(name2, liters, drunkOrNotBool);

            string[] inputNameAndBank = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name3 = inputNameAndBank[0];
            double bankBallance = double.Parse(inputNameAndBank[1]);
            string bankName = inputNameAndBank[2];
            MyTuple<string, double, string> numbers =
                new MyTuple<string, double, string>(name3, bankBallance, bankName);

            Console.WriteLine(nameTown.GetItems());
            Console.WriteLine(nameLiters.GetItems());
            Console.WriteLine(numbers.GetItems());
        }
    }
}
