namespace ExtractBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractBytes
    {
        static void Main(string[] args)
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            List<int> bytes = new List<int>();
            List<int> bytes2 = new List<int>();
            using (FileStream reader = new FileStream(bytesFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024];
                
                while (true)
                {
                    int bytesRead = reader.Read(buffer);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    foreach (byte b in buffer)
                    {
                        if (b == 0)
                        {
                            break;
                        }
                        bytes.Add(b);
                    }

                }

            }
            using (FileStream reader2 = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer2 = new byte[1024];

                while (true)
                {
                    int bytesRead = reader2.Read(buffer2);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    foreach (byte b in buffer2)
                    {
                        if (b == 0)
                        {
                            break;
                        }
                        bytes2.Add(b);
                    }
                }
            }

            using (FileStream writer = new FileStream(outputPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                foreach(byte byte1 in bytes)
                {
                    foreach(byte byte2 in bytes2)
                    {
                        if (byte1 == byte2)
                        {
                            writer.WriteByte(byte1);
                        }
                    }
                }
            }
        }
    }
}