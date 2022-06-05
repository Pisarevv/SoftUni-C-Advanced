using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberToDivide = int.Parse(Console.ReadLine());

            Action<List<int>> printList = x => Console.WriteLine(string.Join(" ",x));

            Func<int[], int[]> reverseArray = x =>
             {
                 int[] reversedArray = new int[x.Length];
                 for (int i = 0; i < numbers.Length; i++)
                 {
                     int number = numbers[i];
                     reversedArray[i] = numbers[numbers.Length - 1 - i];
                     reversedArray[numbers.Length - 1 - i] = number;
                 }
                 return reversedArray;

             };
            Func<int[], int, List<int>> NonDiviasbleFind = (x, y) =>
            {
                List<int> list = new List<int>();
                foreach (int number in x)
                {
                    if (number % y != 0)
                    {
                        list.Add(number);
                    }
                }
                return list;
            };

            int[] reversedArray = reverseArray(numbers);
            List<int> NonDivisable = NonDiviasbleFind(reversedArray,numberToDivide);
            printList(NonDivisable);
        }
    }
}
