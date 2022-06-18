using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Person> people = new List<Person>();
            while((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                Person newPerson = new Person(cmdArgs[0], int.Parse(cmdArgs[1]), cmdArgs[2]);
                people.Add(newPerson);
            }
            int n = int.Parse(Console.ReadLine());
            Person toFind = people[n-1];

            int matches = 0;
            int notEqual = 0;
            foreach(Person person in people)
            {
                int result = person.CompareTo(toFind);
                if(result == 0)
                {
                    matches++;
                }
                if(result == -1)
                {
                    notEqual++;
                }
            }
            if (matches > 1)
            {
                Console.WriteLine($"{matches} {notEqual} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
            
        }
    }
}
