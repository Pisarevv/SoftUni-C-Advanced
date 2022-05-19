using System;
using System.Linq;

namespace P02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] values = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = values[j];
                }
            }

            int[] sumOfCols = new int[cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumOfCols[j] += matrix[i,j];
                    
                }
                
            }

            for (int i = 0; i < cols; i++)
            {
                Console.WriteLine(sumOfCols[i] + " ");
            }

        }
    }
}
