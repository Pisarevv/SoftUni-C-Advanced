using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<List<int>, int> findSmallest = numbers => numbers.Min();

            Console.WriteLine(findSmallest(numbers));
        }
    }
}
