using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony.Classes
{
    public class Smartphone : ISmartphone
    {
        
        public void BrowsingTheInternet(string website)
        {
            bool isDigitPresent = website.Any(c => char.IsDigit(c));
            if (isDigitPresent)
            {
                Console.WriteLine("Invalid URL!");               
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");                
            }
        }

        public void CallingOtherPhones(string number)
        {
            bool containsLetters = number.Any(char.IsLetter);
            if (containsLetters)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine($"Calling... {number}");
            }
        }
    }
}
