using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = new SortedDictionary<string, Dictionary<string, decimal>>();
            string input = string.Empty;

            while((input = Console.ReadLine()) != "Revision")
            {
                string[] cmdArgs = input.Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shop = cmdArgs[0];
                string product = cmdArgs[1];
                decimal price = decimal.Parse(cmdArgs[2]);

                if (!prices.ContainsKey(shop))
                {
                    prices[shop] = new Dictionary<string, decimal>();
                }
                if (!prices[shop].ContainsKey(product))
                {
                    prices[shop][product] = 0;
                }
                prices[shop][product] = price;
            }

            foreach(var kvp in prices)
            {
                Console.WriteLine($"{kvp.Key}->");
                foreach(var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"Product: {kvp2.Key}, Price: {kvp2.Value:F1}");
                }
            }

        }
    }
}
