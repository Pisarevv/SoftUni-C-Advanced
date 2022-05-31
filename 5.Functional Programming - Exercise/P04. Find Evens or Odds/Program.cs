using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int startNumber = input[0];
            int endNumber = input[1];
            List<int> numbers = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                numbers.Add(i);
            }

            string type = Console.ReadLine();
            Predicate<int> predicate = null;

            if (type == "even")
            {
                predicate = x => x % 2 == 0;
            }
            else if (type == "odd")
            {
                predicate = x => x % 2 != 0;
            }

            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));

        }
    }
}
