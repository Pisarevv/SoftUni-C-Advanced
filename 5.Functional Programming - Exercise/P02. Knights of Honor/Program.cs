using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string,string> addSir = name => "Sir " + name;
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string name in names)
            {
                Console.WriteLine(addSir(name));
            }
        }
    }
}
