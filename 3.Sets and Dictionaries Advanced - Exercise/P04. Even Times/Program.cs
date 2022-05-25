using System;
using System.Collections.Generic;

namespace P04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse((Console.ReadLine()));
                if (!numbers.ContainsKey(inputNumber))
                {
                    numbers[inputNumber] = 0;
                }
                numbers[inputNumber]++;
            }

            foreach(var number in numbers)
            {
                if(number.Value %2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
