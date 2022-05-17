using System;
using System.Collections.Generic;

namespace P08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            Queue<string > queue = new Queue<string>();
            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count > 0)
                        {
                            string car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            totalCarsPassed++;
                        }
                    }
                }
                else if (cmd == "end")
                {
                    Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(cmd);

                }
            }
        }
    }
}
