namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            StringBuilder sb = new StringBuilder();
            string[] files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, Dictionary<string,double>> extensionsInfo = new Dictionary<string, Dictionary<string, double>>();
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;
                if (!extensionsInfo.ContainsKey(extension))
                {
                    extensionsInfo[extension] = new Dictionary<string, double>();
                    extensionsInfo[extension][fileInfo.Name] = fileInfo.Length;
                }
                if (!extensionsInfo[extension].ContainsKey(fileInfo.Name))
                {
                    extensionsInfo[extension][fileInfo.Name] = fileInfo.Length;
                }
                

            }


            foreach (var entry in extensionsInfo.OrderByDescending(entry => entry.Value.Count).ThenBy(entry => entry.Key))
            {
                string extension = entry.Key;
                sb.AppendLine(extension);
                foreach (var value in extensionsInfo[extension].OrderBy(x => x.Value))
                {
                    string fileName = value.Key;
                    double fileSize = value.Value/1024;
                    sb.AppendLine($"--{fileName} - {fileSize:F3}kb");
                }
            }

            return sb.ToString();

        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string pathReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            File.WriteAllText(pathReport, textContent);

        }
    }
}