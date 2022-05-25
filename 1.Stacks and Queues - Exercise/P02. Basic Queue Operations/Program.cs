using System;
using System.Collections;
using System.Linq;

namespace P02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue queue = new Queue();

            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < input[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < input[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if (!queue.Contains(input[2]))
            {
                int smallestElement = GetMinElementInStack(queue);
                Console.WriteLine(smallestElement);
            }

        }

        private static int GetMinElementInStack(Queue queue)
        {
            int smallestElement = int.MaxValue;
            foreach (int element in queue)
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
