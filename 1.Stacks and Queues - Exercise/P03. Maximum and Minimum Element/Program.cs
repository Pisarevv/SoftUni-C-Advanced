using System;
using System.Collections;
using System.Linq;

namespace P03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack stack = new Stack();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int command = input[0];

                if (command == 1)
                {
                    stack.Push(input[1]);
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    Console.WriteLine(GetMaxElementInStack(stack));
                }
                else if (command == 4)
                {
                    Console.WriteLine(GetMinElementInStack(stack));
                }
            }
            Console.WriteLine(string.Join(", ", stack.ToArray()));
        }

        private static int GetMinElementInStack(Stack stack)
        {
            int smallestElement = int.MaxValue;
            foreach (int element in stack)
            {
                if (element < smallestElement)
                {
                    smallestElement = element;
                }
            }
            return smallestElement;
        }

        private static int GetMaxElementInStack(Stack stack)
        {
            int biggestElement = int.MinValue;
            foreach (int element in stack)
            {
                if (element > biggestElement)
                {
                    biggestElement = element;
                }
            }
            return biggestElement;
        }
    }
}
