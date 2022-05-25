using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            //List<int> matchingNumbers = new List<int>();
            HashSet<int> firstSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < m; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            /*foreach(int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    matchingNumbers.Add(number);
                }
            }*/
            firstSet.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ",firstSet));
        }
    }
}
