using System;
using System.Collections.Generic;
using System.Linq;

namespace Loot_box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int claimedItems = 0;
            while (true)
            {
                if (firstBox.Count == 0 || secondBox.Count == 0)
                {
                    break;
                }
                int currentFirstBox = firstBox.Peek();
                int currentSecondBox = secondBox.Peek();
                int boxesSum = currentFirstBox + currentSecondBox;
                if (boxesSum % 2 == 0)
                {
                    claimedItems += boxesSum;
                    firstBox.Dequeue();
                    secondBox.Pop();
                }
                else
                {
                    int toTransfer = secondBox.Pop();
                    firstBox.Enqueue(toTransfer);
                }
            }
            if (firstBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondBox.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (claimedItems >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}
