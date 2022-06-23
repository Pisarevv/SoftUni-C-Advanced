using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingridient = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> dishes = new Dictionary<string, int>()
            {
                ["Dipping sauce"] = 0,
                ["Green salad"] = 0,
                ["Chocolate cake"] = 0,
                ["Lobster"] = 0
            };

            while (true)
            {
                if(ingridient.Count == 0 || freshness.Count == 0)
                {
                    break;
                }

                int currIngridient = ingridient.Dequeue();
                if (currIngridient == 0)
                {
                    continue;
                }
                int currFreshness = freshness.Pop();                
                int multResult = currIngridient * currFreshness;
                if (multResult == 150)
                {
                    dishes["Dipping sauce"]++;
                }
                else if (multResult == 250)
                {
                    dishes["Green salad"]++;
                }
                else if (multResult == 300)
                {
                    dishes["Chocolate cake"]++;
                }
                else if (multResult == 400)
                {
                    dishes["Lobster"]++;
                }
                else
                {
                    currIngridient += 5;
                    ingridient.Enqueue(currIngridient);
                }

            }
            bool success = false;
            foreach (var kvp in dishes)
            {
                if(kvp.Value > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                    break;
                }
            }
            if (success)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            if(ingridient.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {ingridient.Sum()}");
            }
            foreach (var kvp in dishes.OrderBy(x => x.Key))
            {
                if (kvp.Value > 0)
                {
                    Console.WriteLine($" # {kvp.Key} --> {kvp.Value}");
                }
            } 
        }
    }
}
