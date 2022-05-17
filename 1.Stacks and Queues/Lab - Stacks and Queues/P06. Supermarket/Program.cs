using System;
using System.Collections.Generic;

namespace P06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Paid")
                {
                    /*while(queue.Count > 0)
                    {
                        string person = queue.Dequeue();
                        Console.WriteLine(person);
                    }*/
                    queue.Clear();
                }
                else if (input == "End")
                {
                    int remainingCount = queue.Count;
                    Console.WriteLine($"{remainingCount} people remaining.");
                    break;
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
        }
    }
}
