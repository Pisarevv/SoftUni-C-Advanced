using System;
using System.Collections;
using System.Linq;

namespace P01.Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack stack = new Stack();

            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < input[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(input[2]))
            {
                int smallestElement = GetMinElementInStack(stack);
                Console.WriteLine(smallestElement);
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
        }

        private static int GetMinElementInStack (Stack stack)
        {
            int smallestElement = int.MaxValue;
            foreach(int element in stack)
            {
                if (element < smallestElement)
                {
                    smallestElement = element;
                }
            }
            return smallestElement;
        }
    }
}
