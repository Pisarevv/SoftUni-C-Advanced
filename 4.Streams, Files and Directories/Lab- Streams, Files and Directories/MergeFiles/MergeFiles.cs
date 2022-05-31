namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MergeFiles
    {
        static void Main(string[] args)
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader reader1 = new StreamReader(firstInputFilePath))
            {
                using (StreamReader reader2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    { 
                       
                        Queue<string> firstFileQueue = new Queue<string>(reader1.ReadToEnd().Split('\n',StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()));
                        Queue<string> secondFileQueue = new Queue<string>(reader2.ReadToEnd().Split('\n', StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()));
                        int counter = 0;
                        while (true)
                        {
                            if (counter % 2 == 0 && firstFileQueue.Count > 0)
                            {
                                writer.Write(firstFileQueue.Dequeue() + "\n");
                            }
                            if (counter % 2 != 0 && secondFileQueue.Count > 0)
                            {
                                writer.Write(secondFileQueue.Dequeue() + "\n");
                            }
                            counter++;
                            if (firstFileQueue.Count == 0 && secondFileQueue.Count == 0)
                            {
                                break;
                            }
                        }
                        
                        
                    }
                }
            }
        }
    }
}
