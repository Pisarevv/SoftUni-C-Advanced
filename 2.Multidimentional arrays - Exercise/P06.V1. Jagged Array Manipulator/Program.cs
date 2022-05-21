using System;
using System.Linq;

namespace P06.V1._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[n][];

            for (int i = 0; i < jaggedArr.GetLength(0); i++)
            {
                int[] values = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArr[i] = values;
            }

            for (int row = 0; row < jaggedArr.GetLength(0)-1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row + 1].Length)
                {
                    jaggedArr[row] = jaggedArr[row].Select(x => x = x * 2).ToArray();
                    jaggedArr[row+1] = jaggedArr[row+1].Select(x => x = x * 2).ToArray();
                }
                else
                {
                    jaggedArr[row] = jaggedArr[row].Select(x => x = x / 2).ToArray();
                    jaggedArr[row + 1] = jaggedArr[row + 1].Select(x => x = x / 2).ToArray();
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = cmdArgs[0];
                int givenRow = int.Parse(cmdArgs[1]);
                int givenCol = int.Parse(cmdArgs[2]);
                int value = int.Parse(cmdArgs[3]);
                
                if (action == "Add")
                {
                    if (givenRow >= 0 && givenRow < jaggedArr.GetLength(0)
                        && givenCol >= 0 && givenCol < jaggedArr[givenRow].Length)
                    {
                        jaggedArr[givenRow][givenCol] += value;
                    }
                }
                else if (action == "Subtract")
                {
                    if (givenRow >= 0 && givenRow < jaggedArr.GetLength(0)
                        && givenCol >= 0 && givenCol < jaggedArr[givenRow].Length)
                    {
                        jaggedArr[givenRow][givenCol] -= value;
                    }
                }
                
            }
            foreach(var el in jaggedArr)
            {
                Console.WriteLine(String.Join(" ",el));
            }

        }
    }
}
