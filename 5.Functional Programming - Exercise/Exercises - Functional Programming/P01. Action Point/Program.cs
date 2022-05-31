using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printNames = x => Console.WriteLine(x);
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            names.ForEach(printNames);
        }

       
    }
}
