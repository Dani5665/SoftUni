﻿using System;

namespace ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "England": 
                case "USA": 
                    Console.WriteLine("English"); break;
                case "Spain": 
                case "Argentina": 
                case "Mexico": 
                    Console.WriteLine("Spanish"); break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
