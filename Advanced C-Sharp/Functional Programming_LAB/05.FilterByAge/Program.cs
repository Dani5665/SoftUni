using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _05.FilterByAge
{
    class Person
    {
        public string Name;

        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var person = new Person(input[0],int.Parse(input[1]));
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int ageToCompare = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = null;
            

            if (condition == "younger")
            {
                filter = x => x.Age < ageToCompare;
            }
            else if (condition == "older")
            {
                filter = x => x.Age >= ageToCompare;
            }

            var filteredPeople = people.Where(filter);

            if (format == "name age")
            {
                foreach (var person in filteredPeople)
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
            else if (format == "name")
            {
                foreach (var person in filteredPeople)
                {
                    Console.WriteLine(person.Name);
                }
            }
            else if (format == "age")
            {
                foreach (var person in filteredPeople)
                {
                    Console.WriteLine(person.Age);
                }
            }
        }
    }
}
