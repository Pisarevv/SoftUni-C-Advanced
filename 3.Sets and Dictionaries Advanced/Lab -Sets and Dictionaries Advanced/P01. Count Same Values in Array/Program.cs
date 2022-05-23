using System;
using System.Collections.Generic;
using System.Linq;

namespace P01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double,int> sameElements = new Dictionary<double,int>();

            foreach(double element in array)
            {
                if (!sameElements.ContainsKey(element))
                {
                    sameElements.Add(element, 1);
                }
                else
                {
                    sameElements[element]++;
                }
            }
            
            foreach(var kvp in sameElements)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            } 
        }
    }
}
