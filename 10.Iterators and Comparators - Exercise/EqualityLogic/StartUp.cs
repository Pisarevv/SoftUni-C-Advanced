using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualityLogic
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                var person = new Person(cmdArgs[0], int.Parse(cmdArgs[1]));
                sortedSet.Add(person);
                hashSet.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
