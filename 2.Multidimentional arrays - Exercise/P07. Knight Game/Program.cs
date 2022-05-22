using System;
using System.Linq;

namespace P07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                int rowsCount = n;
                int colsCount = n;

                char[,] matrix = new char[rowsCount, colsCount];
                FillMatrix(matrix);
                int removalCount = 0;
                char[,] matrixModified = new char[rowsCount+4, colsCount+5];
                FillMatrixWithZero(matrixModified);

                for (int row = 0; row < rowsCount ; row++)
                {
                    for (int col = 0; col < colsCount; col++)
                    {
                        matrixModified[row+2,col+2] = matrix[row,col];
                    }
                }
                PrintMatrix(matrixModified);
                for (int row = 2; row < rowsCount; row++)
                {
                    for (int col = 2; col < colsCount; col++)
                    {
                        if (char.IsLetter(matrix[row,col]))
                        {
                            
                            char firstPositionChar = matrixModified[row + 2, col + 1];
                            char secondPositionChar = matrixModified[row + 2, col - 1];
                            char thirdPositionChar = matrixModified[row -2, col + 1];
                            char fourthPositionChar = matrixModified[row -2 , col - 1];
                            char fifthPositionChar = matrixModified[row + 1, col + 2];
                            char sixthPositionChar = matrixModified[row - 1, col + 2];
                            char seventhPositionChar = matrixModified[row + 1, col - 2];
                            char eightPositionChar = matrixModified[row -1 , col - 2];

                            if (firstPositionChar == matrixModified[row, col] )
                            {
                               
                                removalCount++;
                            }
                            else if (secondPositionChar == matrixModified[row, col])
                            {
                                
                                removalCount++;
                            }
                            else if (thirdPositionChar == matrixModified[row, col])
                            {
                                
                                removalCount++;
                            }
                            else if (fourthPositionChar == matrixModified[row, col])
                            {
                                
                                removalCount++;
                            }
                            else if (fifthPositionChar == matrixModified[row, col])
                            {
                                
                                removalCount++;
                            }
                            else if (sixthPositionChar == matrixModified[row, col])
                            {
                               
                                removalCount++;
                            }
                            else if (seventhPositionChar == matrixModified[row, col])
                            {
                               
                                removalCount++;
                            }
                            else if (eightPositionChar == matrixModified[row, col])
                            {
                                
                                removalCount++;
                            }
                        }
                    }
                }
                Console.WriteLine(removalCount);
               // PrintMatrix(matrix);

            }
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);

                }
                Console.WriteLine();
            }
        }
        private static void FillMatrix(char[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }

        private static void FillMatrixWithZero(char[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                char rowData = '0';
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData;
                }
            }
        }

    }
}
