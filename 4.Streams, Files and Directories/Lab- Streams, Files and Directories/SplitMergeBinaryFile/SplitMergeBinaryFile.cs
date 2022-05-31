namespace SplitMergeBinaryFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main(string[] args)
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            Queue<byte> collectedBytes = new Queue<byte>();
            int fileSize = 0;
            using (FileStream stream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1];
                while (true)
                {                    
                    int byteRead = stream.Read(buffer);
                    if (byteRead == 0)
                    {
                        break;
                    }
                    fileSize += byteRead;
                    foreach(byte b in buffer)
                    {
                        collectedBytes.Enqueue(b);
                    }
                    
                }
                int firstPortion = 0;
                int secondPortion = 0;
                
                if (fileSize %2 != 0)
                {
                    firstPortion = fileSize / 2 +1;
                    secondPortion = fileSize - firstPortion;
                }
                else
                {
                    firstPortion = fileSize / 2;
                    secondPortion = fileSize - secondPortion;
                }

                using (FileStream writer1 = new FileStream(partOneFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    for (int i = 0; i < firstPortion; i++)
                    {
                        writer1.WriteByte(collectedBytes.Dequeue());
                    }               
                    
                }
                using (FileStream writer2 = new FileStream(partTwoFilePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    for (int i = 0; i < secondPortion; i++)
                    {
                        writer2.WriteByte(collectedBytes.Dequeue());
                    }
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream writer = new FileStream(joinedFilePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (FileStream reader = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                {
                    FillFileWithBytes(reader, writer);
                }
                using (FileStream reader2 = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    FillFileWithBytes(reader2, writer);
                }
            }
        }

        public static void FillFileWithBytes(FileStream reader, FileStream writer)
        {
            byte[] buffer = new byte[1];
            while (true)
            {
                int bytesRead = reader.Read(buffer);
                if (bytesRead == 0)
                {
                    break;
                }
                foreach (byte b in buffer)
                {
                    writer.WriteByte(b);
                }
            }
        }
    }
}