namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main(string[] args)
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
           Dictionary<string, int> wordCounts = new Dictionary<string, int>();

           using (File.OpenRead(textFilePath))
            {
                string text = File.ReadAllText(textFilePath).ToString().ToLower();
                string[] textForSearch = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
               

                using (File.OpenRead(wordsFilePath))
                {
                    var words = File.ReadAllText(wordsFilePath).Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    
                    foreach (var word in words)
                    {
                        string pattern = @$"\b{word}\b";
                        Regex regex = new Regex(pattern);

                        MatchCollection matchCollection = regex.Matches(text);
                        if (!wordCounts.ContainsKey(word))
                        {
                            wordCounts[word] = matchCollection.Count;
                        }
                    }
                    
                }

                
            }
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var word in wordCounts.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
