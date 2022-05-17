using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab___Stacks_and_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
