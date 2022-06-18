using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            while (true)
            {
                var tokens = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "END")
                {
                    break;
                }
                if (tokens[0] == "Push")
                {
                    stack.Push(tokens.Skip(1).Select(e => e.Split(",").First()).ToArray());
                }
                else if (tokens[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {

                        Console.WriteLine(ae.Message);
                    }
                }
            }

            foreach (var token in stack)
            {
                Console.Write(token + " ");
            }
            foreach (var token in stack)
            {
                Console.Write(token + " ");
            }
        }
    }
}
