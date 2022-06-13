using Genereics;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Genereics
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
            if(input.Length > 4)
            {
                input[3] = input[3] + " " + input[4];
            }
            Tuple<string, string, string> firstTurple = new Tuple<string, string, string>(input[0]+ " " + input[1],input[2], input[3]);
            string[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (input2[2] == "drunk")
            {
                input2[2] = "True";
            }
            else
            {
                input2[2] = "False";
            }
            Tuple<string, int, string> secondTurple = new Tuple<string, int, string>(input2[0], int.Parse(input2[1]),input2[2]);     
            string[] input3 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<string, double, string> thirdTurple = new Tuple<string, double,string>(input3[0], double.Parse(input3[1]),input3[2]);
            Console.WriteLine($"{firstTurple.Item1} -> {firstTurple.Item2} -> {firstTurple.Item3}");
            Console.WriteLine($"{secondTurple.Item1} -> {secondTurple.Item2} -> {secondTurple.Item3}");
            Console.WriteLine($"{thirdTurple.Item1} -> {thirdTurple.Item2} -> {thirdTurple.Item3}");


        }
    }
}
