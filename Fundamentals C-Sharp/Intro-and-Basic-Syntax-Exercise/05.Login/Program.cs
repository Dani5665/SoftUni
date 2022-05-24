using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string enterPassword = Console.ReadLine();
            int counter = 1;

            while (enterPassword != password)
            {
                if (counter == 4)
                {                 
                    goto Finish;
                }
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                enterPassword = Console.ReadLine();
            }
            Finish:
            if (counter < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
            Console.WriteLine($"User {username} blocked!");
            }

        }
    }
}
