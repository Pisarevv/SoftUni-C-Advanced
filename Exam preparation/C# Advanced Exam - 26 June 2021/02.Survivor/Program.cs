using System;
using System.Linq;

namespace _02.Survivor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[][] map = new string[n][];
            int pickedTockens = 0;
            int opponentTockens = 0;
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                map[row] = new string[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    map[row][col] = input[col];
                }
            }
            //PrintMatrix(map);
            string command = string.Empty;
            while((command = Console.ReadLine()) != "Gong")
            {
                string[] cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = cmdArgs[0];
                int givenRow = int.Parse(cmdArgs[1]);
                int givenCol = int.Parse(cmdArgs[2]);

                if (action == "Find")
                {
                    if(ValidCoordinates(map, givenRow, givenCol))
                    {
                        PickTocken(map, givenRow, givenCol);
                    }
                }
                else if (action == "Opponent")
                {
                    string direction = cmdArgs[3];
                    if (ValidCoordinates(map, givenRow, givenCol))
                    {
                        PickTockenOpponent(map, givenRow, givenCol,direction);
                    }
                }
            }

            PrintMatrix(map);
            Console.WriteLine($"Collected tokens: {pickedTockens}");
            Console.WriteLine($"Opponent's tokens: {opponentTockens}");


            void PickTocken(string[][] map, int row, int col)
            {
                if (map[row][col] == "T")
                {
                    pickedTockens++;
                    map[row][col] = "-";
                }
            }
            void PickTockenOpponent(string[][] map, int row, int col, string direction)
            {
                if (map[row][col] == "T")
                {
                    opponentTockens++;
                    map[row][col] = "-";
                }
                if (direction == "up")
                {
                    int stepsCount = 0;
                    for (int i = row; i > 0; i--)
                    {
                        stepsCount++;
                        if (map[row][col] == "T")
                        {
                            opponentTockens++;
                            map[row][col] = "-";
                        }
                        if (stepsCount == 3)
                        {
                            break;
                        }
                        row--;

                    }
                }
                if (direction == "down")
                {
                    int stepsCount = 0;
                    for (int i = row; i < map[row].GetLength(0); i--)
                    {
                        stepsCount++;
                        row++;
                        if (map[row][col] == "T")
                        {
                            opponentTockens++;
                            map[row][col] = "-";
                        }
                        if (stepsCount == 3)
                        {
                            break;
                        }
                        

                    }
                }
                if(direction == "left")
                {
                    int stepsCount = 0;
                    for (int i = col; i > 0; i--)
                    {
                        stepsCount++;
                        if (map[row][col] == "T")
                        {
                            opponentTockens++;
                            map[row][col] = "-";
                        }
                        if(stepsCount == 3)
                        {
                            break;
                        }
                        col--;

                    }
                }
                if (direction == "right")
                {
                    int aviableMovement = map[row].Length - 1 - col;
                    if (aviableMovement > 3)
                    {
                        aviableMovement = 3;
                    }
                    for (int i = 0; i < aviableMovement; i++)
                    {
                        col++;
                        if (map[row][col] == "T")
                        {
                            opponentTockens++;
                            map[row][col] = "-";
                        }

                    }
                }

            }
        }

        static bool ValidCoordinates(string[][] map ,int row, int col)
        {
            if (row < map.GetLength(0))
            if( col < map[row].Length)
            {
                return true;
            }
            return false;
        }
        
        static void PrintMatrix(string[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
