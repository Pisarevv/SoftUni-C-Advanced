using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach(string element in input)
                {
                    elements.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
