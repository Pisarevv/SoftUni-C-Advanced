using System;
using System.Linq;

namespace P02.__2X2_Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = sizeOfMatrix[0];
            int cols = sizeOfMatrix[1];

            char[,] matrix = new char[rows, cols];
            FillMatrix(matrix);
            
        }
        private static void FillMatrix(char[,] numbers)
        {
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = rowData[j];
                }
            }
        }
    }
    
}
