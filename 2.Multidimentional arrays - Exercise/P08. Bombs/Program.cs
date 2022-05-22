using System;
using System.Linq;

namespace P08._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rowsCount = n;
            int colsCount = n;

            int[,] matrix = new int[rowsCount, colsCount];
            FillMatrix(matrix);

            string[] coordinates = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] singleCoordinates = coordinates[i].Split(",").Select(int.Parse).ToArray();
                int rowCoor = singleCoordinates[0];
                int colCoor = singleCoordinates[1];

                int bombPower = matrix[rowCoor, colCoor];

                if (bombPower > 0)
                {
                    matrix[rowCoor, colCoor] = 0;
                    for (int row = 0; row < rowsCount; row++)
                    {
                        for (int col = 0; col < colsCount; col++)
                        {
                            if (row == rowCoor && col == colCoor - 1 && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                            else if (row == rowCoor && col == colCoor + 1 && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                            else if (row == rowCoor + 1 && col == colCoor - 1 && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                            else if (row == rowCoor + 1 && col == colCoor && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                            else if (row == rowCoor + 1 && col == colCoor + 1 && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                            else if (row == rowCoor - 1 && col == colCoor - 1 && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                            else if (row == rowCoor - 1 && col == colCoor && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                            else if (row == rowCoor - 1 && col == colCoor + 1 && matrix[row, col] > 0)
                            {
                                matrix[row, col] = matrix[row, col] - bombPower;
                            }
                        }
                    }
                }
                
            }
            int sumOfAliveElements = 0;
            int aliveCells = 0;
            foreach(int element in matrix)
            {
                if(element > 0)
                {
                    sumOfAliveElements += element;
                    aliveCells++;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveElements}");
            PrintMatrix(matrix);

        }



        private static void FillMatrix(int[,] numbers)
        {
            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    numbers[row, col] = rowData[col];
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
    }


}
