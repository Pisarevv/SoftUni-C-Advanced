using System;

namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList newList = new DoublyLinkedList();
            newList.AddHead(1);
            newList.AddHead(2);
            Console.WriteLine(newList.head.Value);
            Console.WriteLine(newList.tail.Value);

            newList.AddTail(7);
            Console.WriteLine(newList.tail.Value);
            newList.RemoveFirst();
            newList.RemoveFirst();
            Console.WriteLine(newList.head.Value);
            newList.AddTail(8);
            newList.AddTail(15);
            newList.AddTail(12);
            newList.RemoveLast();
            Console.WriteLine(newList.tail.Value);
            newList.AddTail(1);
            newList.AddHead(0);
            newList.ForEach(x => Console.WriteLine(x));
            int[] array = newList.ToArray();
        }
    }
}
