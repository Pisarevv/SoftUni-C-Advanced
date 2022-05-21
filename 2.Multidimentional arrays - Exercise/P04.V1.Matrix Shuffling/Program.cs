using System;
using System.Linq;

namespace P04.V1.Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowCount = n[0];
            int colCount = n[1];

            string[,] matrix = new string[rowCount, colCount];
            FillMatrix(matrix);

            string command = string.Empty;

            while((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = cmdArgs[0];

                if (action == "swap" && cmdArgs.Length == 5)
                {
                    int firstRow = int.Parse(cmdArgs[1]);
                    int firstCol = int.Parse(cmdArgs[2]);
                    int secondRow = int.Parse(cmdArgs[3]);
                    int secondCol = int.Parse(cmdArgs[4]);

                    if(firstRow >=0 && firstRow < matrix.GetLength(0) 
                        && firstCol >=0 && firstCol < matrix.GetLength(1)
                        && secondRow >= 0 && secondRow < matrix.GetLength(0)
                        && secondCol >= 0 && secondCol < matrix.GetLength(1)
                        )
                    {
                        string firstRowValue = matrix[firstRow,firstCol];
                        matrix[firstRow,firstCol] = matrix[secondRow,secondCol];
                        matrix[secondRow,secondCol] = firstRowValue;
                        PrintMatrix(matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }



        }

        private static void FillMatrix(string[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                        Console.Write(matrix[row, col] + " ");           

                }
                Console.WriteLine();
            }
        }
    }

}
