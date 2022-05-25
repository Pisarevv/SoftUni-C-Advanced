using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songPlaylist = new Queue<string>(Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries));

            string input = string.Empty;

            while (songPlaylist.Count > 0)
            {
                input = Console.ReadLine();              

                if (input == "Play")
                {              
                        songPlaylist.Dequeue();
                                 
                }
                else if (input.Contains("Add"))
                {
                    string songName = input.Remove(0, 4);

                    if (songPlaylist.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                    else
                    {
                        songPlaylist.Enqueue(songName);
                    }
                }
                else if (input == "Show")
                {
                    Console.WriteLine(string.Join(", ",songPlaylist));
                }
                
            }
            Console.WriteLine("No more songs!");

        }
    }
}
