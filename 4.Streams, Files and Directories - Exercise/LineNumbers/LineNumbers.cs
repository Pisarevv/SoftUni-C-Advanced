namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string line = string.Empty;
            int counter = 1;
            using(StreamReader reader = new StreamReader(inputFilePath))
            {
                using(StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    while ((line = reader.ReadLine())!= null)
                    {
                        char[] chars = line.ToCharArray();
                        int lettersCount = 0;
                        int separatorCount = 0;
                        for(int i = 0; i < chars.Length; i++)
                        {
                            if (char.IsLetter(chars[i]))
                            {
                                lettersCount++;
                            }
                            else if (char.IsPunctuation(chars[i]))
                            {
                                separatorCount++;
                            }
                        }
                        writer.WriteLine($"Line {counter}: "+ line +$"({lettersCount})({separatorCount})");
                        counter++;
                    }
                }
            }
        }
    }
}
