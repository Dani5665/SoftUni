using System;
namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person human;
            if (age < 0)
            {
                return;
            }
            if (age <= 15)
            {
                human = new Child(name, age);
            }
            else
            {
                human = new Person(name, age);
            }

            Console.WriteLine(human);
        }
    }
}