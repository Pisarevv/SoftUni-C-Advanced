using System;

namespace CustomDataStructures
{
    internal class MainProg
    {
        static void Main()
        {
            MyList list = new MyList();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.RemoveAt(2);

            list.Insert(2, 9);
            Console.WriteLine($"{list.Contains(9)}");
            list.Swap(1,8);
            int value = list[2];


        }
    }
}
