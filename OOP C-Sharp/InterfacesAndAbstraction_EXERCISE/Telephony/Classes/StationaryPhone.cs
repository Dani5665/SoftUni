using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony.Classes
{
    public class StationaryPhone : IStationaryPhone
    {
        public void CallingOtherPhones(string number)
        {
            bool containsLetters = number.Any(char.IsLetter);
            if (containsLetters)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Dialing... {number}");
            }
        }
    }
}
