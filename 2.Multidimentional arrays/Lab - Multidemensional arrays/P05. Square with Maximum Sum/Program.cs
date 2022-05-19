using System;
using System.Linq;

namespace P05._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rowsCount = dimensions[0];
            int colsCount = dimensions[1];

            int[,] matrix = new int[rowsCount, colsCount];
            for (int i = 0; i < rowsCount; i++)
            {
                int[] values = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < colsCount; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            int maxSum = int.MinValue;
            int[,] bestSquare = new int[2,2];

            for (int row = 0; row < rowsCount-1; row++)
            {
                for (int col = 0; col < colsCount-1; col++)
                {
                    int sum = matrix[row, col] +
                             matrix[row, col+1] +
                             matrix[row+1, col] +
                             matrix[row+1, col+1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestSquare[0, 0] = matrix[row, col];
                        bestSquare[0, 1] = matrix[row, col+1];
                        bestSquare[1, 0] = matrix[row+1, col];
                        bestSquare[1, 1] = matrix[row+1, col+1];
                    }
                }
            }

            for (int i = 0; i < bestSquare.GetLength(0); i++)
            {
                for (int j = 0; j < bestSquare.GetLength(1); j++)
                {
                    Console.Write(bestSquare[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
