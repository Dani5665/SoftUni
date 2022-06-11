using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0] != "END")
            {
                string direction = input[0];
                string carPlate = input[1];

                if (direction == "IN")
                {
                    if (parkingLot.Contains(carPlate) == false)
                    {
                        parkingLot.Add(carPlate);
                    }
                }
                else if (direction == "OUT")
                {
                    if (parkingLot.Contains(carPlate))
                    {
                        parkingLot.Remove(carPlate);
                    }
                }
                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            if (parkingLot.Count > 0)
            {
                foreach (var plate in parkingLot)
                {
                    Console.WriteLine(plate);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
