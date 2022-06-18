using System;
using System.Linq;

namespace Froggy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var Lake = new Lake(Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Console.WriteLine(string.Join(", ", Lake));
            
        }
    }
}
