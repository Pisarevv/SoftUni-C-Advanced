using System;
using System.IO;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            using (reader)
            {
               
               StreamWriter writer = new StreamWriter("output.txt");
                using (writer)
                {
                    int lineNumber = 0;

                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (lineNumber %2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        lineNumber++;
                    }
                }

            }
        }
    }
}
