using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            Func<List<int>, List<int>> add = list => list.Select(number => number += 1).ToList();
            Func<List<int>, List<int>> multiply = list => list.Select(number => number *= 2 ).ToList();
            Func<List<int>, List<int>> subract = list => list.Select(number => number -= 1).ToList();
            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);   
                }
            }

            
        }
    }
}
