using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            int finalSum = 0;
            Stack<string> stack = new Stack<string>();
            for (int i = expression.Length-1; i >= 0 ; i--)
            {
                stack.Push(expression[i]);
            }
            while (stack.Count > 1)
            {
                int n1 = int.Parse(stack.Pop());
                char n2 = char.Parse(stack.Pop());
                int n3 = int.Parse(stack.Pop());

                if (n2 == '-')
                {
                    finalSum = n1 - n3;
                    stack.Push(finalSum.ToString());
                }
                else if (n2 == '+')
                {
                    finalSum = n1 + n3;
                    stack.Push(finalSum.ToString());
                }

                
            }
            Console.WriteLine(finalSum);
        }
    }
}
