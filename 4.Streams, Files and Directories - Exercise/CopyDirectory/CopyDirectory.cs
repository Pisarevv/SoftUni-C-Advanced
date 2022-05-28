namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }
            //създаване Output директория
            Directory.CreateDirectory(outputPath);
            //взимане на файлове от инпут директорията
            var files = Directory.GetFiles(inputPath);
            foreach (var file in files)
            {
                var fileName = Path.GetFileName(file); // взимаме файка с име
                var copyDestnation = Path.Combine(outputPath, fileName);
                File.Copy(file, copyDestnation);
                
            }

        }
    }
}
