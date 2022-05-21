using System;
using System.Linq;

namespace P03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowCount = n[0];
            int colCount = n[1];

            int[,] matrix = new int[rowCount, colCount];
            int[,] bestMatrix = new int[3, 3];
            FillMatrix(matrix);

            int maximalSum = 0;
            if (rowCount >=3 && colCount >= 3)
            {
                for (int row = 0; row < rowCount - 2; row++)
                {
                    for (int col = 0; col < colCount - 2; col++)
                    {
                        int currentSum = matrix[row, col]
                                         + matrix[row, col + 1]
                                         + matrix[row, col + 2]
                                         + matrix[row + 1, col]
                                         + matrix[row + 1, col + 1]
                                         + matrix[row + 1, col + 2]
                                         + matrix[row + 2, col]
                                         + matrix[row + 2, col + 1]
                                         + matrix[row + 2, col + 2];
                        if (currentSum > maximalSum)
                        {
                            maximalSum = currentSum;
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    bestMatrix[i, j] = matrix[row + i, col + j];
                                }
                            }
                        }


                    }
                }
                Console.WriteLine($"Sum = {maximalSum}");
                PrintMatrix(bestMatrix);
            }
            
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col == matrix.GetLength(1) - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
