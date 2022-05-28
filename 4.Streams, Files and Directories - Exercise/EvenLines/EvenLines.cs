namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            ProcessLines(inputFilePath);
            //Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            string line = string.Empty; // чете по един ред от файла
            int counter = 0;
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                //line = reader.ReadLine();
                while ((line = reader.ReadLine())!= null)
                {
                    
                    if (counter %2 == 0)
                    {
                        
                        line = Replace(line);
                        line = Reverse(line);
                        Console.WriteLine(line);
                    }
                    counter++;
                    //line = reader.ReadLine();
                }
            }
            return line;
        }

        private static string Reverse(string line)
        {
            return string.Join(" ", line.Split().Reverse());
        }

        private static string Replace(string line)
        {
                 return line.Replace("-", "@")
                    .Replace(",", "@")
                    .Replace(".", "@")
                    .Replace("!", "@")
                    .Replace("?", "@");

        }
    }
}
