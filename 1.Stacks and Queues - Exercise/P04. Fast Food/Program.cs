using System;
using System.Collections;
using System.Linq;

namespace P04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] ordersInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Queue queue = new Queue();
            int biggestOrder = ordersInput.Max();
            foreach(int order in ordersInput)
            {
                queue.Enqueue(order);
               
            }

            for (int i = 0; i < ordersInput.Length; i++)
            {
                int orderAmount = (int)queue.Peek();
                

                if (orderAmount <= foodQuantity)
                {
                    foodQuantity -= orderAmount;
                    queue.Dequeue();
                }
                else if (orderAmount > foodQuantity)
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine($"Orders left: {string.Join(" ",queue.ToArray())}");
            }



        }
    }
}
