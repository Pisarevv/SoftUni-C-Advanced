using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> whiteTales = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> greyTales = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> furniture = new Dictionary<string, int>()
            {
                ["Sink"] = 0,
                ["Oven"] = 0,
                ["Countertop"] = 0,
                ["Wall"] = 0,
                ["Floor"] = 0,
            };
            while (true)
            {
                if (whiteTales.Count == 0 || greyTales.Count == 0)
                {
                    break;
                }
                int currentWhite = whiteTales.Pop();
                int currentGrey = greyTales.Dequeue();
                int currentSum = currentWhite + currentGrey;
                if (currentGrey == currentWhite)
                {
                    if (currentSum == 40)
                    {
                        furniture["Sink"]++;
                        continue;
                    }
                    else if (currentSum == 50)
                    {
                        furniture["Oven"]++;
                        continue;
                    }
                    else if (currentSum == 60)
                    {
                        furniture["Countertop"]++;
                        continue;
                    }
                    else if (currentSum == 70)
                    {
                        furniture["Wall"]++;
                        continue;
                    }
                    else
                    {
                        furniture["Floor"]++;
                    }
                }
                else
                {
                    currentWhite = currentWhite / 2;
                    whiteTales.Push(currentWhite);
                    greyTales.Enqueue(currentGrey);
                }
                
            }
            if (whiteTales.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else if (whiteTales.Count > 0)
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTales)}");
            }
            if (greyTales.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else if (greyTales.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTales)}");
            }
            foreach (var kvp in furniture.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
