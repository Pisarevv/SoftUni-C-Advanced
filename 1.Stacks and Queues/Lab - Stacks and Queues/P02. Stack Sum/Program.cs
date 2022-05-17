using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string inputNumbers = Console.ReadLine();
            string[] numbers = inputNumbers.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string number in numbers)
            {
                stack.Push(int.Parse(number));
            }
            string command = Console.ReadLine().ToLower();

            while ((command != "end"))
            {
                string[] cmdArgs = command.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmdArgs[0] == "add")
                {
                    int n1 = int.Parse(cmdArgs[1]);
                    int n2 = int.Parse(cmdArgs[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if (cmdArgs[0] == "remove")
                {
                    int countToRemove = int.Parse(cmdArgs[1]);
                    if (stack.Count >= countToRemove)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
            


        }
    }
}
