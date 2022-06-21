using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] pond = new string[n,n];
            Stack<string> branches = new Stack<string>();
            
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < n; col++)
                {
                    pond[row,col] = input[col];
                }
            }
            int branchesCount = FindAllBranches(pond);
            //PrintMatrix(pond);
            int[] beaverLocation = GetBeaverLocation(pond);
            int beaverRow = beaverLocation[0];
            int beaverCol = beaverLocation[1];

            string command = string.Empty;
            while((command = Console.ReadLine()) != "end")
            {
                if (branchesCount == 0)
                {
                    break;
                }
                if (command == "up")
                {
                    MoveBeaver(beaverRow - 1, beaverCol);
                }
                if (command == "down")
                {
                    MoveBeaver(beaverRow + 1, beaverCol);
                }
                if (command == "left")
                {
                    MoveBeaver(beaverRow, beaverCol - 1);
                }
                if (command == "right")
                {
                    MoveBeaver(beaverRow, beaverCol + 1);
                }
               
            }
            if (branchesCount > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {branchesCount} branches left.");
               
            }
            else if (branchesCount == 0)
            {
                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ",branches.Reverse())}.");
            } 
            PrintMatrix(pond);


            void MoveBeaver(int newRow, int newCol)
            {
                if ((newRow < 0 || newRow > pond.GetLength(0)-1) || (newCol < 0 || newCol > pond.GetLength(1)-1))
                {
                    if (branches.Count > 0)
                        branches.Pop();
                    return;
                }
                else if (char.IsLower(char.Parse(pond[newRow, newCol])))
                {
                    branches.Push(pond[newRow, newCol]);
                    pond[beaverRow, beaverCol] = "-";
                    pond[newRow, newCol] = "B";
                    beaverRow = newRow;
                    beaverCol = newCol;
                    branchesCount--;
                }
                else if (pond[newRow, newCol] == "F")
                {
                    if (newRow == 0 || newRow == pond.GetLength(0) || newCol == 0 || newCol == pond.GetLength(1))
                    {
                        if (newRow == 0)
                        {
                            pond[beaverRow, beaverCol] = "-";
                            pond[newRow, beaverCol] = "-";

                            beaverRow = pond.GetLength(0)-1;

                        }
                        else if (newRow == pond.GetLength(0)-1)
                        {
                            pond[beaverRow, beaverCol] = "-";
                            pond[newRow, beaverCol] = "-";
                            beaverRow = 0;
                        }
                        if (newCol == 0)
                        {
                            pond[beaverRow, beaverCol] = "-";
                            pond[beaverRow, newCol] = "-";
                            beaverCol = pond.GetLength(0)-1;

                        }
                        else if (newCol == pond.GetLength(0)-1)
                        {
                            pond[beaverRow, beaverCol] = "-";
                            pond[beaverRow, newCol] = "-";
                            beaverCol = 0;
                        }

                        if (char.IsLower(char.Parse(pond[beaverRow, beaverCol])))
                        {
                            branches.Push(pond[newRow, newCol]);
                            pond[beaverRow, beaverCol] = "B";
                            branchesCount--;
                        }
                        else
                        {
                            pond[beaverRow, beaverCol] = "B";
                        }
                    }
                    else
                    {
                        if (command == "up")
                        {
                            pond[beaverRow, beaverCol] = "-";
                            beaverRow = 0;
                            if (char.IsLower(char.Parse(pond[beaverRow, beaverCol])))
                            {
                                branches.Push(pond[newRow, newCol]);
                                pond[beaverRow, beaverCol] = "B";
                                branchesCount--;
                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "B";
                            }
                        }
                        if (command == "down")
                        {
                            pond[beaverRow, beaverCol] = "-";
                            beaverRow = pond.GetLength(0);
                            if (char.IsLower(char.Parse(pond[beaverRow, beaverCol])))
                            {
                                branches.Push(pond[newRow, newCol]);
                                pond[beaverRow, beaverCol] = "B";
                                branchesCount--;
                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "B";
                            }
                        }
                        if (command == "left")
                        {
                            pond[beaverRow, beaverCol] = "-";
                            beaverCol = 0;
                            if (char.IsLower(char.Parse(pond[beaverRow, beaverCol])))
                            {
                                branches.Push(pond[newRow, newCol]);
                                pond[beaverRow, beaverCol] = "B";
                                branchesCount--;
                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "B";
                            }
                        }
                        if (command == "right")
                        {
                            pond[beaverRow, beaverCol] = "-";
                            beaverCol = pond.GetLength(0);
                            if (char.IsLower(char.Parse(pond[beaverRow, beaverCol])))
                            {
                                branches.Push(pond[newRow, newCol]);
                                pond[beaverRow, beaverCol] = "B";
                                branchesCount--;
                            }
                            else
                            {
                                pond[beaverRow, beaverCol] = "B";
                            }
                        }
                    }
                    
                }
                else
                {
                    pond[beaverRow, beaverCol] = "-";
                    pond[newRow, newCol] = "B";
                    beaverRow = newRow;
                    beaverCol = newCol;
                }
                
            }


        }

        

        public static int[] GetBeaverLocation(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "B")
                    {
                        int[] coordinates = new int[] { row, col };
                        return coordinates;
                    }
                    
                }
                
            }
            return null;
        }
        public static void PrintMatrix(string[,] matrix)
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
        public static int FindAllBranches(string[,] matrix)
        {
            int branches = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (char.IsLower(char.Parse(matrix[row, col])))
                    {
                        branches++;
                    }
                }
               
            }
            return branches;
        }
    }
}
