using System;
using System.Linq;

namespace P04._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            FillMatrix(matrix);
            char[] symbolToFind = Console.ReadLine().ToCharArray();
            char symbol = symbolToFind[0];
            int foundInRow = 0;
            int foundInColumn = 0;
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        foundInRow = row;
                        foundInColumn = col;
                        isFound = true;
                        break;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"({foundInRow}, {foundInColumn})");

            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }

        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] values = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = values[col];
                }
            }
        }
    }
}
