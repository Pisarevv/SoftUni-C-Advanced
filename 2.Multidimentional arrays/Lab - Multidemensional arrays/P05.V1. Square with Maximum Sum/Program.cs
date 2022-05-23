using System;
using System.Linq;

namespace P05.V1._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsCount = n[0];
            int colsCount = n[1];

            int[,] matrix = new int[rowsCount, colsCount];
            FillMatrix(matrix);
            int biggestSum = 0;
            int[,] foundMatrix = new int[2, 2];

            for (int row = 1; row < rowsCount; row++)
            {
                for (int col = 1; col < colsCount; col++)
                {
                    int currentSum = matrix[row-1,col-1]+matrix[row-1,col]+matrix[row,col-1]+matrix[row,col];
                    if(currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        foundMatrix[row-row, col-col] = matrix[row - 1, col - 1];
                        foundMatrix[row-row, col-col+1] = matrix[row - 1, col];
                        foundMatrix[row-row+1, col-col] = matrix[row, col -1];
                        foundMatrix[row-row+1 , col-col+1 ] = matrix[row, col];
                    }
                }
            }
            PrintMatrix(foundMatrix);
            Console.WriteLine(biggestSum);

        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] values = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
