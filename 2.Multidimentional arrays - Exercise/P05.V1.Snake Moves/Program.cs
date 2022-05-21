using System;
using System.Linq;

namespace P05.V1.Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowCount = n[0];
            int colCount = n[1];

            char[,] matrix = new char[rowCount, colCount];
            char[] snake = Console.ReadLine().ToCharArray();
            int index = 0;

            for (int row = 0; row < rowCount; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        matrix[row, col] = snake[index];
                        index++;

                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }                 
                }
                else
                {
                    for (int col = colCount-1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[index];
                        index++;

                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                
                
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);

                }
                Console.WriteLine();
            }
        }
    }
}
