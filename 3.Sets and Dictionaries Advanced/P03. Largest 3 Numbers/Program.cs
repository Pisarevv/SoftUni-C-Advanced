using System;
using System.Linq;

namespace P03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).OrderByDescending(x => x).Take(3)
                .ToArray();

            Console.WriteLine(String.Join(" ", array));
            /*int[] sortedArray = new int[array.Length];

            sortedArray = array.OrderByDescending(x => x).ToArray();

            if (sortedArray.Length > 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedArray[i] + " ");
                }
            }
            else
            {
                Console.WriteLine(String.Join(" ", sortedArray));
            }
            */
        }
    }
}
