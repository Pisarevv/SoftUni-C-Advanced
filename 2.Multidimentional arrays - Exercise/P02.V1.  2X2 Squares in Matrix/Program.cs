using System;
using System.Linq;

namespace P02.V1.__2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowCount = n[0];
            int colCount = n[1];

            string[,] matrix = new string[rowCount, colCount];
            FillMatrix(matrix);

            int foundSquaresCount = 0;

            for (int row = 0; row < rowCount-1; row++)
            {
                for (int col = 0; col < colCount-1; col++)
                {
                    if (matrix[row, col] == matrix[row,col+1] 
                        && matrix[row,col] == matrix[row+1,col]
                        && matrix[row,col] == matrix[row+1,col+1]
                        )
                    {
                        foundSquaresCount++;
                    }
                }
            }
            Console.WriteLine(foundSquaresCount);
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] data = Console.ReadLine().Split(' ').ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];
                }
            }
        }
    }
}
