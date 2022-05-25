using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe
                = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ",
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                string color = input[0];
                string[] dresses = input[1].Split(',').ToArray();

                foreach(string dress in dresses)
                {
                    if (!wardrobe.ContainsKey(color))
                    {
                        wardrobe[color] = new Dictionary<string, int>();
                    }
                    if (!wardrobe[color].ContainsKey(dress))
                    {
                        wardrobe[color][dress] = 0;
                    }
                    wardrobe[color][dress]++;
                }
            }
            string[] searchedDress = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string searchedColor = searchedDress[0];
            string searchedItem = searchedDress[1];

            foreach(var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach(var dress in color.Value)
                {
                    if(dress.Key == searchedItem && color.Key == searchedColor)
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {dress.Key} - {dress.Value}");
                    }
                }
            }

        }
    }
}
