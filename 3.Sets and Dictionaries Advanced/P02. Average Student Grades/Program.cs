using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentsGrades = new Dictionary<string,List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades[studentName] = new List<decimal>();
                }
                studentsGrades[studentName].Add(grade);
            }

            foreach(var kvp in studentsGrades)
            {

                List<decimal> grades = kvp.Value;
                string gradesString = string.Join(" ",grades.Select(x => x.ToString("F2")));
                decimal average = grades.Average();

                Console.WriteLine($"{kvp.Key} -> {gradesString} (avg: {average:F2})");
            }
        }
    }
}
