using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string modifiedString = string.Empty;
            Stack<String> modProcess= new Stack<string>();
            modProcess.Push(modifiedString);
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = input[0];

                if (action == "1")
                {
                    modifiedString+= input[1];
                    modProcess.Push(modifiedString);
                }
                else if (action == "2")
                {
                    int countToRemove = int.Parse(input[1]);
                    modifiedString = modifiedString.Remove(modifiedString.Length - countToRemove,countToRemove );
                    modProcess.Push(modifiedString);
                }
                else if (action == "3")
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(modifiedString[index-1]);
                    
                }
                else if (action == "4")
                {
                    
                        if (modifiedString == modProcess.Peek())
                        {
                            modProcess.Pop();
                        }
                        modifiedString = modProcess.Pop();
                    
                    
                }
                
            }
        }
    }
}
