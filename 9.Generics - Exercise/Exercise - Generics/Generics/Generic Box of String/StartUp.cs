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
            Console.WriteLine(box.ToString());*/
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for(int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }
            Box<string> box = new Box<string>(list);
            var elementToCompare = Console.ReadLine();

            var count = box.CountOfGreaterElements(list, elementToCompare);
            Console.WriteLine(count);
            
        }
    }
}
