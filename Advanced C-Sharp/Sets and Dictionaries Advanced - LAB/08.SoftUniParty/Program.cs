using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> normalGuestList = new HashSet<string>();
            HashSet<string> vipGuestList = new HashSet<string>();

            while (command != "PARTY")
            {
                bool result = char.IsDigit(command, 0);
                if (command.Length == 8 && result)
                {
                    vipGuestList.Add(command);
                }
                else if (command.Length == 8 && result == false)
                {
                    normalGuestList.Add(command);
                }
                command = Console.ReadLine();
            }

            while (command != "END")
            {
                if (vipGuestList.Contains(command))
                {
                    vipGuestList.Remove(command);
                }
                else if (normalGuestList.Contains(command))
                {
                    normalGuestList.Remove(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(vipGuestList.Count + normalGuestList.Count);

            foreach (var guest in vipGuestList)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in normalGuestList)
            {
                Console.WriteLine(guest);
            }


        }
    }
}
