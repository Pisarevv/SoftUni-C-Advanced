using System;
using System.Linq;

namespace Re_Volt
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            bool hasFinished = false;
            string[,] matrix = new string[n,n];
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                char[] inputToChar = input.ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = inputToChar[col].ToString();
                }
            }
            int[] playerCoordinates = FindPlayerCoordinates(matrix);
            if (playerCoordinates == null)
            {
                return;
            }
            int playerRow = playerCoordinates[0];
            int playerCol = playerCoordinates[1];

            for (int i = 0; i < m; i++)
            {
                if (hasFinished)
                {
                    break;
                }
                string command = Console.ReadLine();
                if (command == "up")
                {
                    MovePlayer(matrix, playerRow - 1, playerCol,command);
                }
                else if (command == "down")
                {
                    MovePlayer(matrix, playerRow + 1, playerCol, command);
                }
                else if (command == "left")
                {
                    MovePlayer(matrix, playerRow, playerCol - 1, command);
                }
                else if (command == "right")
                {
                    MovePlayer(matrix, playerRow, playerCol + 1, command);
                }
               //PrintMatrix(matrix);
            }
            if (!hasFinished)
            {
                Console.WriteLine("Player lost!");
            }
            else
            {
                Console.WriteLine("Player won!");
            }
            PrintMatrix(matrix);


            void MovePlayer(string[,] matrix,int newRow,int newCol,string command)
            {
                int[] checkedCoordinates = CheckCoordinates(matrix,newRow,newCol);
                int checkedRow = checkedCoordinates[0];
                int checkedCol = checkedCoordinates[1];
                if (matrix[checkedRow, checkedCol] == "B")
                {
                    if (command == "up")
                    {
                        checkedRow--;
                        checkedCoordinates = CheckCoordinates(matrix, checkedRow, newCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        if (matrix[playerRow, playerCol] == "F")
                        {
                            hasFinished = true;
                            matrix[playerRow, playerCol] = "-";
                            matrix[checkedRow, checkedCol] = "f";
                            playerRow = checkedRow;
                            playerCol = checkedCol;
                            return;
                        }
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                    else if (command == "down")
                    {
                        checkedRow++;
                        checkedCoordinates = CheckCoordinates(matrix, checkedRow, newCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        if (matrix[checkedRow, checkedCol] == "F")
                        {
                            hasFinished = true;
                            matrix[playerRow, playerCol] = "-";
                            matrix[checkedRow, checkedCol] = "f";
                            playerRow = checkedRow;
                            playerCol = checkedCol;
                            return;
                        }
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                    else if (command == "left")
                    {
                        checkedCol--;
                        checkedCoordinates = CheckCoordinates(matrix, newRow, checkedCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        if (matrix[checkedRow, checkedCol] == "F")
                        {
                            hasFinished = true;
                            matrix[playerRow, playerCol] = "-";
                            matrix[checkedRow, checkedCol] = "f";
                            playerRow = checkedRow;
                            playerCol = checkedCol;
                            return;
                        }
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                    else if (command == "right")
                    {
                        checkedCol++;
                        checkedCoordinates = CheckCoordinates(matrix, newRow, checkedCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        if (matrix[checkedRow, checkedCol] == "F")
                        {
                            hasFinished = true;
                            matrix[playerRow, playerCol] = "-";
                            matrix[checkedRow, checkedCol] = "f";
                            playerRow = checkedRow;
                            playerCol = checkedCol;
                            return;
                        }
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                    
                }
                else if (matrix[checkedRow, checkedCol] == "T")
                {
                    if (command == "up")
                    {
                        checkedRow++;
                        checkedCoordinates = CheckCoordinates(matrix, checkedRow, newCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                    else if (command == "down")
                    {
                        checkedRow--;
                        checkedCoordinates = CheckCoordinates(matrix, checkedRow, newCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                    else if (command == "left")
                    {
                        checkedCol++;
                        checkedCoordinates = CheckCoordinates(matrix, newRow, checkedCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                    else if (command == "right")
                    {
                        checkedCol--;
                        checkedCoordinates = CheckCoordinates(matrix, newRow, checkedCol);
                        checkedRow = checkedCoordinates[0];
                        checkedCol = checkedCoordinates[1];
                        matrix[playerRow, playerCol] = "-";
                        matrix[checkedRow, checkedCol] = "f";
                        playerRow = checkedRow;
                        playerCol = checkedCol;
                    }
                }
                else if (matrix[checkedRow, checkedCol] == "F")
                {
                    hasFinished = true;
                    matrix[playerRow, playerCol] = "-";
                    matrix[checkedRow, checkedCol] = "f";
                    playerRow = checkedRow;
                    playerCol = checkedCol;
                }
                else
                {
                    matrix[playerRow, playerCol] = "-";
                    matrix[checkedRow, checkedCol] = "f";
                    playerRow = checkedRow;
                    playerCol = checkedCol;
                }
            }

        }
        static int[] CheckCoordinates(string[,] matrix, int newRow, int newCol)
        {
            int[] coordinates = new int[2];
            if (newRow < 0)
            {
                newRow = matrix.GetLength(0) - 1;
            }
            else if (newRow == matrix.GetLength(0))
            {
                newRow = 0;
            }
            if (newCol < 0)
            {
                newCol = matrix.GetLength(1) - 1;
            }
            else if (newCol == matrix.GetLength(1))
            {
                newCol = 0;
            }
            coordinates[0] = newRow;
            coordinates[1] = newCol;
            return coordinates;
        }

        static int[] FindPlayerCoordinates(string[,] matrix)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "f")
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                        return coordinates;
                    }
                }
               
            }
             return null;
        }
        static void PrintMatrix(string[,] matrix)
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
