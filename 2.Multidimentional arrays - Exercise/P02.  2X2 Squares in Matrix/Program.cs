using System;
using System.Linq;

namespace P02.__2X2_Squares_in_Matrix
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
            int SameMatrixes = 0;

            for (int rows = 0; rows < rowsCount-1; rows++)
            {
                for (int cols = 0; cols < colsCount-1; cols++)
                {
                    if (matrix[rows, cols] == matrix[rows+1,cols] 
                        && matrix[rows,cols+1] == matrix[rows + 1, cols + 1]
                        && matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        SameMatrixes++;
                    }
                }
            }
            Console.WriteLine(SameMatrixes);
            
        }
        private static void FillMatrix(string[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }
    }
    
}
