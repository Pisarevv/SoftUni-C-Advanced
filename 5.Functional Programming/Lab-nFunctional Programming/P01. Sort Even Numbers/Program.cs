using System;
using System.Linq;

namespace P01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                /*Console.WriteLine(string.Join
                (", ", Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Where(x => x%2 == 0).OrderBy(x => x)));*/

            Func<string,int> parse = x => int.Parse(x);
            Func<int,bool> isEven = x => x % 2 == 0;
            Func<int,int> sort = x => x;

            int[] numbers = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(parse).Where(isEven).OrderBy(sort).ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
