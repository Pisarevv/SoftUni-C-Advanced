using System;
using System.Linq;

namespace P06._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];
            FillJaggedArray(jaggedArray);

            string command = string.Empty;
            
            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = cmdArgs[0];
                int givenRow = int.Parse(cmdArgs[1]);
                int givenCol = int.Parse(cmdArgs[2]);
                int givenValue = int.Parse(cmdArgs[3]);

                if (givenRow>=0 && givenRow < jaggedArray.GetLength(0) && givenCol >= 0 && givenCol < jaggedArray[givenRow].Length)
                {
                    if (action == "Add")
                    {
                        jaggedArray[givenRow][givenCol] = jaggedArray[givenRow][givenCol] + givenValue;
                    }
                    else if (action == "Subtract")
                    {
                        jaggedArray[givenRow][givenCol] = jaggedArray[givenRow][givenCol] - givenValue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            foreach(int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }

        private static void FillJaggedArray (int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray[i] = values;
            }
        }
    }
}
