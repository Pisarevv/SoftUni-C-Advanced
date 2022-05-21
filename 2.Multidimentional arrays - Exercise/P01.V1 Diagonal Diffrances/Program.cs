using System;
using System.Linq;

namespace P01.V1_Diagonal_Diffrances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rowCount = n;
            int colCount = n;

            int[,] matrix = new int[rowCount, colCount];
            FillMatrix(matrix);

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < rowCount; row++)
            {
                primarySum += matrix[row, row];
                secondarySum += matrix[row, rowCount-1-row];
            }

            int finalSum = (primarySum-secondarySum);
            Console.WriteLine(Math.Abs(finalSum));

        }

        private static void FillMatrix (int[,]matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}
