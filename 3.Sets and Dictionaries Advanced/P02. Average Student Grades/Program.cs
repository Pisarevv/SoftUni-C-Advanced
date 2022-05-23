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
            var studentsGrades = new Dictionary<string,List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string studentName = input[0];
                double grade = double.Parse(input[1]);

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades[studentName] = new List<double>();
                }
                studentsGrades[studentName].Add(grade);
            }

            foreach(var kvp in studentsGrades)
            {

                Console.Write($"{kvp.Key} - > ");
                foreach(var grade in kvp.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.Write($"(avg: {kvp.Value.Average():F2})");
                Console.WriteLine();
            }
        }
    }
}
