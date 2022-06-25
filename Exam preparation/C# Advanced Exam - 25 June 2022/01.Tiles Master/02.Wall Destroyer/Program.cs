using System;
using System.Linq;

namespace _02.Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] wall = new string[n,n];
            bool isElectocuted = false;
            int createdHoles = 0;
            int hitRods = 0;
            for (int row = 0; row < n; row++)
            {
                string input = Console.ReadLine();
                char[] inputToChar = input.ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    wall[row,col] = inputToChar[col].ToString();
                }
            }
            //
            int[] vankoCoordinates = FindVankoCoordinates(wall);
            int vankoRow = vankoCoordinates[0];
            int vankoCol = vankoCoordinates[1];
            string command = Console.ReadLine();
            while ((command != "End"))
            {                
                if (command == "up")
                {
                    MoveVanko(wall, vankoRow - 1, vankoCol);
                }
                else if (command == "down")
                {
                    MoveVanko(wall, vankoRow + 1, vankoCol);
                }
                else if (command == "left")
                {
                    MoveVanko(wall, vankoRow, vankoCol-1);
                }
                else if (command == "right")
                {
                    MoveVanko(wall, vankoRow, vankoCol+1);
                }
                //PrintMatrix(wall);
                if (isElectocuted == true)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            int holes = 0;
            for (int row = 0; row < wall.GetLength(0); row++)
            {
                for (int col = 0; col < wall.GetLength(1); col++)
                {
                    if ((wall[row, col] == "*" || wall[row, col] == "E" )&& isElectocuted)
                    {
                        holes++;
                    }
                    else if((wall[row, col] == "*" || wall[row, col] == "V") && !isElectocuted)
                    {
                        holes++;
                    }
                }

            }

            if (isElectocuted)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holes} hole(s) and he hit only {hitRods} rod(s).");
            }
            PrintMatrix(wall);

            void MoveVanko(string[,] wall, int newRow, int newCol)
            {
                if (ValidCoordinates(wall,newRow,newCol))
                {
                    if (wall[newRow,newCol] == "R")
                    {
                        Console.WriteLine("Vanko hit a rod!");
                        hitRods++;
                        return;
                    }
                    else if (wall[newRow, newCol] == "C")
                    {
                        isElectocuted = true;
                        wall[vankoRow, vankoCol] = "*";
                        wall[newRow,newCol] = "E";
                        createdHoles++;
                        return;
                    }
                    else if (wall[newRow, newCol] == "*")
                    {
                        Console.WriteLine($"The wall is already destroyed at position [{newRow}, {newCol}]!");
                        wall[vankoRow, vankoCol] = "*";
                        wall[newRow, newCol] = "V";
                        vankoRow = newRow;
                        vankoCol = newCol;
                    }
                    else
                    {
                        wall[vankoRow, vankoCol] = "*";
                        wall[newRow, newCol] = "V";
                        vankoRow = newRow;
                        vankoCol = newCol;
                        createdHoles++;
                    }
                }
                else
                {
                    return;
                }
            }

            bool ValidCoordinates(string[,] wall, int newRow, int newCol)
            {
                if ((newRow < 0 || newRow >= wall.GetLength(0)) || (newCol < 0 || newCol >= wall.GetLength(1)))
                {
                    return false;
                }
                return true;
            }
        }

        static int[] FindVankoCoordinates(string[,] matrix)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == "V")
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                        break;
                    }
                }
                
            }
            return coordinates;
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
