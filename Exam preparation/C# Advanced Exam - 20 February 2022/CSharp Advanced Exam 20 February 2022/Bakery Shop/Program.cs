using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<double> water = new Queue<double>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse));
            Dictionary<string, int> bakeryProducts = new Dictionary<string, int>()
            {
                ["Croissant"] = 0,
                ["Muffin"] = 0,
                ["Baguette"] = 0,
                ["Bagel"] = 0,
            };

            while (true)
            {
                if(water.Count == 0 || flour.Count == 0)
                {
                    break;
                }
                double currentWater = water.Dequeue();
                double currentFlour = flour.Pop();
                double waterProcentage = (currentWater * 100)/(currentFlour + currentWater);

                if (waterProcentage == 40)
                {
                    bakeryProducts["Muffin"]++;
                }
                else if (waterProcentage == 50)
                {
                    bakeryProducts["Croissant"]++;
                }
                else if (waterProcentage == 30)
                {
                    bakeryProducts["Baguette"]++;
                }
                else if (waterProcentage == 20)
                {
                    bakeryProducts["Bagel"]++;
                }
                else
                {
                    double neededFlourPercentage = waterProcentage;
                    currentFlour = currentFlour - currentWater;
                    flour.Push(currentFlour);
                    bakeryProducts["Croissant"]++;
                }

            }
            foreach(var kvp in bakeryProducts.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if(kvp.Value > 0)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            if(water.Count == 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }
            if (flour.Count == 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }

        }
    }
}
