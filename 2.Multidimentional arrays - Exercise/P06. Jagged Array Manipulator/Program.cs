using System;
using System.Linq;

namespace P06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rowsCount][];
            FillJaggedMatrix(matrix);

            for(int row = 0; row < rowsCount-1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(x => x*2).ToArray();
                    matrix[row+1] = matrix[row+1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
                }
            }

            string command = string.Empty;

            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);

                if(action == "Add")
                {
                    if (row >= 0 && row < matrix.GetLength(0) &&
                        col >= 0 && col < matrix.Length)
                    {
                        matrix[row][col] =matrix[row][col] + value;
                    }
                }
                else if (action == "Subtract")
                {
                    if (row >= 0 && row < matrix.GetLength(0) &&
                        col >= 0 && col < matrix.Length)
                    {
                        matrix[row][col] = matrix[row][col] - value;
                    }
                }
            }
            foreach(int[] row in matrix)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }

        public static void FillJaggedMatrix (int[][] jaggedMatrix)
        {
            for (int row = 0; row < jaggedMatrix.GetLength(0) ; row++)
            {
                jaggedMatrix[row] = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
            }
        }

        
    }
}
