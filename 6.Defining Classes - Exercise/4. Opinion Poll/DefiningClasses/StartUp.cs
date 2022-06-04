using System;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string inputName = input[0];
                int inputAge = int.Parse(input[1]);

                Person newPerson = new Person(inputName, inputAge);
                family.Addperson(newPerson);
            }
            family.PrintOlderThan30();
        }
    }
}
