using System;
using System.Collections.Generic;

namespace P01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (string s in usernames)
            {
                Console.WriteLine(s);
            }
        }
    }
}
