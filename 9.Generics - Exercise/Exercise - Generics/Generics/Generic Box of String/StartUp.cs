using System;

namespace Generic_Box_of_String
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                Box<int> box = new Box<int>();
                box.data = int.Parse(Console.ReadLine());
                Console.WriteLine(box.ToString()); 
            }
        }
    }
}
