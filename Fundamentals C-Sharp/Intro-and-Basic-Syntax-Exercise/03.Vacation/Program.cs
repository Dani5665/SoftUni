using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;
            double discount = 0;

            if (dayOfWeek == "Friday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 8.45; break;
                    case "Business": price = 10.90; break;
                    case "Regular": price = 15; break;
                    default:
                        break;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 9.80; break;
                    case "Business": price = 15.60; break;
                    case "Regular": price = 20; break;
                    default:
                        break;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (typeOfGroup)
                {
                    case "Students": price = 10.46; break;
                    case "Business": price = 16; break;
                    case "Regular": price = 22.50; break;
                    default:
                        break;
                }
            }


            if (typeOfGroup == "Students" && numOfPeople >= 30)
            {
                discount = 0.15;
            }
            if (typeOfGroup == "Business" && numOfPeople >= 100)
            {
                numOfPeople -= 10;
            }
            if (typeOfGroup == "Regular" && numOfPeople >= 10 && numOfPeople <= 20)
            {
                discount = 0.05;
            }

            if (discount != 0)
            {
                totalPrice = (numOfPeople * price) - ((numOfPeople * price) * discount);               
            }
            else
            {
                totalPrice = numOfPeople * price;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
