using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] token = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string studentName = token[0];
                decimal studentGrade = decimal.Parse(token[1]);

                if (grades.ContainsKey(studentName))
                {
                    grades[studentName].Add(studentGrade);
                }
                else
                {
                    grades.Add(studentName, new List<decimal> { studentGrade });
                }
            }

            foreach (var student in grades)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(x => x.ToString("f2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
