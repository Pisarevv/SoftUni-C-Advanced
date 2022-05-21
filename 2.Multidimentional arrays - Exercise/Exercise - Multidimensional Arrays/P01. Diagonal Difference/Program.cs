using System;
using System.Linq;

namespace P01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int rows = size;
            int cols = size;

            int[,] matrix = new int[rows, cols];
            FillMatrix(matrix);

            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            for (int i = 0; i < rows; i++)
            {
               sumPrimaryDiagonal += matrix[i,i];
               sumSecondaryDiagonal +=matrix[i,matrix.GetLength(0)-i-1];
            }
            int finalSum = sumPrimaryDiagonal-sumSecondaryDiagonal;
            Console.WriteLine(Math.Abs(finalSum));
            
        }

        private static void FillMatrix (int[,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = input[j];
                }
            }
        }
    }
}
