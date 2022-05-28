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
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineNumber %2 == 1)
                        {
                            writer.WriteLine(line);
                            writer.Flush();
                        }
                        lineNumber++;
                    }
                }

            }

            
        }
    }
}
