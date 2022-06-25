using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int,int,int> sortFucn = (x , y) => (x % 2 == 0 && y % 2 != 0 ? -1 : x % 2 != 0 && y % 2 == 0 ? 1 : x > y ? 1 : x < y ? -1 : 0);
            Array.Sort(numbers, (x, y) => sortFucn(x, y));
            Console.WriteLine(string.Join(" ", numbers));
        }

        
    }
}
