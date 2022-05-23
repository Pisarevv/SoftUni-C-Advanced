using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var citiesByCont =new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!citiesByCont.ContainsKey(continent))
                {
                    citiesByCont[continent] = new Dictionary<string, List<string>>();
                }
                if (!citiesByCont[continent].ContainsKey(country))
                {
                    citiesByCont[continent][country] = new List<string>();
                }
                citiesByCont[continent][country].Add(city);
            }

            foreach (var kvp in citiesByCont)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"   {kvp2.Key} -> {string.Join(", ",kvp2.Value)}");
                }
            }


        }
    }
}
