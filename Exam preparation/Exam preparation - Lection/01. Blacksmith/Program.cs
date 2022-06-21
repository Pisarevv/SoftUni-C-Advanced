using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> craftedWeapons = new Dictionary<string, int>()
            {
                ["Gladius"] = 0,
                ["Shamshir"] = 0,
                ["Katana"] = 0,
                ["Sabre"] = 0,
                ["Broadsword"] = 0
            };
            int forgedSwords = 0;

            while (true)
            {
                if(steel.Count == 0 || carbon.Count == 0)
                {
                    break;
                }
                int currentSteel = steel.Dequeue();
                int curentCarbon = carbon.Pop();
                int currentSumOfElements = curentCarbon + currentSteel;
                if (currentSumOfElements == 70)
                {
                    craftedWeapons["Gladius"]++;
                    forgedSwords++;
                }
                else if (currentSumOfElements == 80)
                {
                    craftedWeapons["Shamshir"]++;
                    forgedSwords++;
                }
                else if (currentSumOfElements == 90)
                {
                    craftedWeapons["Katana"]++;
                    forgedSwords++;
                }
                else if (currentSumOfElements == 110)
                {
                    craftedWeapons["Sabre"]++;
                    forgedSwords++;
                }
                else if (currentSumOfElements == 150)
                {
                    craftedWeapons["Broadsword"]++;
                    forgedSwords++;
                }

                else
                {
                    curentCarbon = curentCarbon + 5;
                    carbon.Push(curentCarbon);
                }

            }
            if (forgedSwords > 0)
            {
                Console.WriteLine($"You have forged {forgedSwords} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            if(steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else if (steel.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else if (carbon.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            foreach(var kvp in craftedWeapons.OrderBy(x => x.Key))
            {
                if(kvp.Value > 0)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
            }
        }
    }
}
