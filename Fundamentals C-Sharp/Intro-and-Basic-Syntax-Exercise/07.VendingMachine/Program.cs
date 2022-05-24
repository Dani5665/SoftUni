using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            double totalMoney = 0;

            while (input != "Start")
            {
                switch (input)
                {
                    case "0.1" : totalMoney += 0.1; break;
                    case "0.2": totalMoney += 0.2; break;
                    case "0.5": totalMoney += 0.5; break;
                    case "1": totalMoney += 1; break;
                    case "2": totalMoney += 2; break;
                    default: Console.WriteLine($"Cannot accept {input}"); break;
                }
                input = Console.ReadLine();
            }
            EnterProductName:
            input = Console.ReadLine();

                if (input == "Nuts" && totalMoney >= 2)
                {
                    Console.WriteLine("Purchased nuts");
                    totalMoney -= 2;
                    goto EnterProductName;
                }
                else if (input == "Water" && totalMoney >= 0.7)
                {
                    Console.WriteLine("Purchased water");
                    totalMoney -= 0.7;
                    goto EnterProductName;
                }
                else if (input == "Crisps" && totalMoney >= 1.5)
                {
                    Console.WriteLine("Purchased crisps");
                    totalMoney -= 1.5;
                    goto EnterProductName;
                }
                else if (input == "Soda" && totalMoney >= 0.8)
                {
                    Console.WriteLine("Purchased soda");
                    totalMoney -= 0.8;
                    goto EnterProductName;
                }
                else if (input == "Coke" && totalMoney >= 1)
                {
                    Console.WriteLine("Purchased coke");
                    totalMoney -= 1;
                    goto EnterProductName;
                }
                else if (input == "End")
                {
                    goto Change;
                }
                else if (input != "Nuts" && input != "Water" && input != "Crisps" && input != "Soda" && input != "Coke" && input != "End")
                {
                    Console.WriteLine("Invalid product");
                    goto EnterProductName;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                    goto EnterProductName;
                }
            Change:
            Console.WriteLine($"Change: {totalMoney:F2}");

        }
    }
}
