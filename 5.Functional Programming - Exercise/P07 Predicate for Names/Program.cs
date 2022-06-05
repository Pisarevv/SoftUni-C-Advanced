using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int searchedLength = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<List<string>, int, List<string>> validNames = (x,y) =>
             {
                 List<string> list = new List<string>();
                 foreach (string name in names)
                 {
                     if (name.Length <= searchedLength)
                     {
                         list.Add(name);
                     }
                 }
                 return list;
             };
            List<string> filteredNames = validNames(names,searchedLength);
            foreach(string name in filteredNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
