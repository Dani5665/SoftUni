using System;
using System.Linq;
using Telephony.Classes;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            string[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] websites = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var number in numbers)
            {
                if (number.Length == 10)
                {
                    smartphone.CallingOtherPhones(number);
                }
                else if (number.Length == 7)
                {
                    stationaryPhone.CallingOtherPhones(number);
                }
            }

            foreach (var website in websites)
            {
                smartphone.BrowsingTheInternet(website);
            }
        }
    }
}
