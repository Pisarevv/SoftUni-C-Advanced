using System;
using System.Linq;

namespace P04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowsCount = sizeOfMatrix[0];
            int colsCount = sizeOfMatrix[1];

            string[,] matrix = new string[rowsCount, colsCount];
            FillMatrix(matrix);

            string command = string.Empty;

            while((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmdArgs[0] == "swap")
                {
                    if (IsMatrixValid(cmdArgs, matrix))
                    {
                        int firstRow = int.Parse(cmdArgs[1]);
                        int firstCol = int.Parse(cmdArgs[2]);
                        int secondRow = int.Parse(cmdArgs[3]);
                        int secondCol = int.Parse(cmdArgs[4]);

                        string firstRowAndColValue = matrix[firstRow, firstCol];
                        string secondRowAndColValue = matrix[secondRow, secondCol];

                        matrix[firstRow, firstCol] = secondRowAndColValue;
                        matrix[secondRow, secondCol] = firstRowAndColValue;

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
                string[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
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

        private static bool IsMatrixValid(string[] command,string[,] matrix)
        {           
            int firstRow = int.Parse(command[1]);
            int firstCol = int.Parse(command[2]);
            int secondRow = int.Parse(command[3]);
            int secondCol = int.Parse(command[4]);
            if (firstRow >= 0 && firstRow <= matrix.GetLength(0)
                && firstCol >= 0 && firstCol <= matrix.GetLength(1)
                && secondRow >= 0 && secondRow <= matrix.GetLength(0)
                && secondCol >= 0 && secondCol <= matrix.GetLength(1)
                )
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }

}
