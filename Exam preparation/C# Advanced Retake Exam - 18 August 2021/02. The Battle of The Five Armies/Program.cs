using System;
using System.Linq;

namespace _02._The_Battle_of_The_Five_Armies
{
    internal class Program
    {
        static void Main()
        {
            int armorOfArmy = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[][] map = new string[n][];
            for (int row = 0; row < map.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] inputToChar = input.ToCharArray();
                map[row] = new string[input.Length];
                for (int col = 0; col < map[row].Length; col++)
                {
                    map[row][col] = inputToChar[col].ToString();
                }
            }
            //
            int[] armyCoordinates = FindArmyLocation(map);
            int armyRow = armyCoordinates[0];
            int armyCol = armyCoordinates[1];
            bool foundMordor = false;
            bool isDefeated = false;
            while (true)
            {
                if(isDefeated || foundMordor)
                {
                    break;
                }
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                SpawnOrk(map, row, col);
                if (command == "up")
                {
                    MoveArmy(map, armyRow - 1, armyCol);
                }
                else if (command == "down")
                {
                    MoveArmy(map, armyRow + 1, armyCol);
                }
                else if (command == "left")
                {
                    MoveArmy(map, armyRow, armyCol - 1);
                }
                else if (command == "right")
                {
                    MoveArmy(map, armyRow, armyCol + 1);
                }
                //PrintMatrix(map);

            }
            if (isDefeated)
            {
                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
            }
            if (foundMordor)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armorOfArmy}");
            }
            PrintMatrix(map);


            void SpawnOrk (string[][] map, int takenRow, int takenCol)
            {
                if ((takenRow >= 0 || takenRow < map.GetLength(0)) || (takenCol >= 0 || takenCol < map.GetLength(1)))
                {
                    map[takenRow][takenCol] = "O";
                }
                
            }

            void MoveArmy(string[][] map, int newRow, int newCol)
            {
                if ((newRow < 0 || newRow >= map.GetLength(0)) || (newCol < 0 || newCol >= map[newRow].Length))
                {
                    armorOfArmy--;
                    if (armorOfArmy <= 0)
                    {
                        isDefeated = true;
                        
                        return;
                    }
                }
                else if (map[newRow][newCol] == "O")
                {
                    armorOfArmy--;
                    map[armyRow][armyCol] = "-";
                    armorOfArmy = armorOfArmy -2;
                    armyRow = newRow;
                    armyCol = newCol;
                    if (armorOfArmy <= 0)
                    {
                        isDefeated = true;
                        map[newRow][newCol] = "X";
                    }
                    else
                    {
                        map[newRow][newCol] = "A";
                    }
                }
                else if (map[newRow][newCol] == "M")
                {
                    armorOfArmy--;
                    if (armorOfArmy <= 0)
                    {
                        isDefeated = true;
                        map[newRow][newCol] = "X";
                        return;
                    }
                    map[armyRow][armyCol] = "-";
                    map[newRow][newCol] = "-";
                    foundMordor = true;
                    armyRow = newRow;
                    armyCol = newCol;
                }
                else
                {
                    map[armyRow][armyCol] = "-";
                    map[newRow][newCol] = "A";
                    armyRow = newRow;
                    armyCol = newCol;
                    armorOfArmy--;
                }
            }
        }

        static int[] FindArmyLocation(string[][] map)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map[row].Length; col++)
                {
                    if (map[row][col] == "A")
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                        break;
                    }
                }              
            }
            return coordinates;
        }
        static void PrintMatrix(string[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
