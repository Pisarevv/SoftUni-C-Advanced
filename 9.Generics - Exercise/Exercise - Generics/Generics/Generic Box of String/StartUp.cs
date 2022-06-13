using Genereics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.data.Add(input);         
               
            }
            int[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            box.Swap(command[0], command[1]);
            Console.WriteLine(box.ToString());
            int n = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for(int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                list.Add(input);
            }
            Box<double> box = new Box<double>(list);
            double elementToCompare = double.Parse(Console.ReadLine());

            int count = box.CountOfGreaterElements(list, elementToCompare);
            Console.WriteLine(count);*/
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<string, string> firstTurple = new Tuple<string, string>(input[0]+ " " + input[1],input[2]);
            string[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<string, int> secondTurple = new Tuple<string, int>(input2[0], int.Parse(input2[1]));
            string[] input3 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<int, double> thirdTurple = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));
            Console.WriteLine($"{firstTurple.Item1} -> {firstTurple.Item2}");
            Console.WriteLine($"{secondTurple.Item1} -> {secondTurple.Item2}");
            Console.WriteLine($"{thirdTurple.Item1} -> {thirdTurple.Item2}");


        }
    }
}
