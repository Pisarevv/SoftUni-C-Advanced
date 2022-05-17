using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();           
            Queue<string> queue = new Queue<string>(players);
            int n = int.Parse(Console.ReadLine());

            while ( queue.Count > 1)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                string lostPlayer = queue.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }
            string lastPlayer = queue.Dequeue();
            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}
