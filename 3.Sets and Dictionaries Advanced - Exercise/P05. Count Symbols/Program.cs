using System;
using System.Collections.Generic;

namespace P05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char,int> symbols = new SortedDictionary<char,int>();

            string input = Console.ReadLine();
            char[] inputChar = input.ToCharArray();

            foreach(char c in inputChar)
            {
                if (!symbols.ContainsKey(c))
                {
                    symbols[c] = 0;
                }
                symbols[c]++;
            }

            foreach(var c in symbols)
            {
                Console.WriteLine($"{c.Key} : {c.Value} time\\s");
            }

        }
    }
}
