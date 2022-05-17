using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] numbers = Array.ConvertAll(input, s => int.Parse(s));
            Queue<int> queue = new Queue<int>();

            foreach(int number in numbers)
            {
                if (number%2 == 0)
                {
                    queue.Enqueue(number);
                }
            }
            while (queue.Count > 0)
            {
                if (queue.Count == 1)
                {
                    Console.Write($"{queue.Dequeue()}");
                }
                else
                {
                    Console.Write($"{queue.Dequeue()}, ");
                }
                
            }
            
        }
    }
}
