using System;
using System.Linq;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] forest = new string[n,n];
            int blackTruffle = 0;
            int summerTruffle = 0;
            int whiteTruffle = 0;
            int boarEatenTruffles = 0;
            for (int row = 0; row < n; row++)
            {
                string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < n; col++)
                {
                    forest[row,col] = input[col];
                }
            }

            string command = string.Empty;
            while((command = Console.ReadLine()) != "Stop the hunt")
            {
                string[] cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = cmdArgs[0];
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);

                if (action == "Collect")
                {
                    string item = forest[row,col];
                    if (item == "B")
                    {
                        blackTruffle++;
                    }
                    else if (item == "S")
                    {
                        summerTruffle++;
                    }
                    else if (item == "W")
                    {
                        whiteTruffle++;
                    }
                    forest[row, col] = "-";
                }
                if (action == "Wild_Boar")
                {
                    string direction = cmdArgs[3];
                    MoveBoar(forest, direction, row, col);
                }
            }

            Console.WriteLine($"Peter manages to harvest {blackTruffle} black, {summerTruffle} summer, and {whiteTruffle} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boarEatenTruffles} truffles.");
            PrintMatrix(forest);

            void MoveBoar(string[,] forest, string direction, int row, int col)
            {
                if (direction == "up")
                {
                    while (row >= 0)
                    {
                        if (forest[row, col] == "B" || forest[row, col] == "S" || forest[row, col] == "W")
                        {
                            boarEatenTruffles++;
                            
                        };
                        forest[row, col] = "-";
                        row -=2;
                    }
                }
                else if (direction == "down")
                {
                    while (row < forest.GetLength(0))
                    {
                        if (forest[row, col] == "B" || forest[row, col] == "S" || forest[row, col] == "W")
                        {
                            boarEatenTruffles++;
                            
                        };
                        forest[row, col] = "-";
                        row += 2;
                    }
                }
                else if (direction == "left")
                {
                    while (col >= 0)
                    {
                        if (forest[row, col] == "B" || forest[row, col] == "S" || forest[row, col] == "W")
                        {
                            boarEatenTruffles++;
                            
                        };
                        forest[row, col] = "-";
                        col -= 2;
                    }
                }
                else if (direction == "right")
                {
                    while (col < forest.GetLength(1))
                    {
                        if (forest[row, col] == "B" || forest[row, col] == "S" || forest[row, col] == "W")
                        {
                            boarEatenTruffles++;
                            
                        };
                        forest[row, col] = "-";
                        col += 2;
                    }
                }
            }

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
    }
}
