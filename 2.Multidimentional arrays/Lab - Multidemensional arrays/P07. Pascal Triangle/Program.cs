using System;

namespace P07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];
            jaggedArray[0] = new int[1] { 1};
            for (int i = 1; i < n; i++)
            {
                jaggedArray[i] = new int[i+1];
                jaggedArray[i][0] = 1;
                jaggedArray[i][jaggedArray[i].Length - 1] = 1;
                for (int j = 1; j < jaggedArray[i].Length-1; j++)
                {
                    jaggedArray[i][j] = jaggedArray[i-1][j-1] + jaggedArray[i-1][j];
                }
                
            }

            foreach(int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ",row));
            }

           
        }
    }
}
