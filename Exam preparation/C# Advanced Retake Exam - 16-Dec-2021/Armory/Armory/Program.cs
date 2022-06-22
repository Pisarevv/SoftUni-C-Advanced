using System;
using System.Linq;

namespace Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] map = new string[n,n];
            int boughtArmory = 0;
            bool outOfMap = false;
            for (int row = 0; row < map.GetLength(0); row++)
            {
                string input = Console.ReadLine();
                char[] inputToChar = input.ToCharArray();
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    map[row,col] = inputToChar[col].ToString();
                }
            }
            int[] officerCoordinates = FindOfficerLocation(map);
            int officerRow = officerCoordinates[0];
            int officerCol = officerCoordinates[1];
            while (true)
            {
                if (boughtArmory >= 65 || outOfMap == true)
                {
                    break;
                }
                string command = Console.ReadLine();

                if (command == "up")
                {
                    MoveOfficer(officerRow - 1, officerCol);
                }
                if (command == "down")
                {
                    MoveOfficer(officerRow + 1, officerCol);
                }
                if (command == "left")
                {
                    MoveOfficer(officerRow, officerCol - 1);
                }
                if (command == "right")
                {
                    MoveOfficer(officerRow, officerCol + 1);
                }
            }

            if(outOfMap == true)
            {
                Console.WriteLine($"I do not need more swords!");
            }
            if (boughtArmory >= 65)
            {
                Console.WriteLine("Very nice swords, I will come back for more!");
            }
            Console.WriteLine($"The king paid {boughtArmory} gold coins.");
            PrintMatrix(map);





            void MoveOfficer(int newRow,int newCol)
            {
                if ((newRow < 0 || newRow >= map.GetLength(0)) || (newCol < 0 || newCol >= map.GetLength(1)))
                {
                    outOfMap = true;
                    map[officerRow, officerCol] = "-";
                    return;
                }
                if (char.IsDigit(char.Parse(map[newRow, newCol])))
                {
                    boughtArmory += int.Parse(map[newRow, newCol]);
                    map[officerRow, officerCol] = "-";
                    officerRow = newRow;
                    officerCol = newCol;
                    map[newRow, newCol] = "A";
                }
                else if (map[newRow, newCol] == "M")
                {
                    int[] mirrorsLocation = FindOtherMirror(map,newRow,newCol);
                    int newMirrorRow = mirrorsLocation[0];
                    int newMirrorCol = mirrorsLocation[1];
                    map[officerRow, officerCol] = "-";
                    map[newRow, newCol] = "-";
                    map[newMirrorRow, newMirrorCol] = "A";
                    officerRow = newMirrorRow;
                    officerCol = newMirrorCol;

                }
                else
                {
                    map[officerRow, officerCol] = "-";
                    map[newRow,newCol] = "A";
                    officerRow = newRow;
                    officerCol = newCol;
                }
                
            }
        }
        
        static int[] FindOtherMirror(string[,] matrix, int currentRow, int currentCol)
        {
            int[] mirrorsLocation = new int[2];
         
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == "M")
                    {
                      if(i != currentRow && j != currentCol)
                        {
                            mirrorsLocation[0] = i;
                            mirrorsLocation[1] = j;
                            break;
                        }
                    }
                }
            }
            return mirrorsLocation;
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }
        }
        static int[] FindOfficerLocation(string[,] matrix)
        {
            int[] coordinates = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == "A")
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }

                }
            }
            return coordinates;
        }
    }
}
