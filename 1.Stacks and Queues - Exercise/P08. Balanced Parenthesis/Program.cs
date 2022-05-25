using System;
using System.Collections.Generic;

namespace P08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> openBrackets = new Stack<char>();
            string input = Console.ReadLine();
            bool areBalanced = false;
            foreach (char bracket in input)
            {
                if (bracket == ('{') || bracket == '[' || bracket == '(')
                {
                    openBrackets.Push(bracket);
                }
                else if (bracket == ('}') || bracket == ']' || bracket == ')')
                {
                    if (openBrackets.Count == 0)
                    {
                        areBalanced = false;
                        break;
                    }
                    char lastOpenBracket = openBrackets.Pop();

                    if (lastOpenBracket == ('(') && bracket == (')'))
                    {
                        areBalanced = true;
                    }
                    else if (lastOpenBracket == ('[') && bracket == (']'))
                    {
                        areBalanced = true;
                    }
                    else if (lastOpenBracket == ('{') && bracket == ('}'))
                    {
                        areBalanced = true;
                    }
                    else
                    {
                        areBalanced = false;
                    }
                }
            }

            if (areBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
      
           
        }
    }
}
