using System;
using System.Collections;
using System.Linq;

namespace P05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCount = 0;
            if (stack.Count > 0)
            {
                rackCount = 1;
            }

            int sumOfClothes = 0;

            int clothesCount = stack.Count;

            while (stack.Count > 0)
            {
               
                sumOfClothes += (int)stack.Peek();
                if (rackCapacity > sumOfClothes)
                {
                    stack.Pop();
                }
                else if (sumOfClothes == rackCapacity)
                {
                    if(stack.Count > 1)
                    {
                        rackCount++;
                       
                    }
                    sumOfClothes = 0;
                    stack.Pop();


                }
                else if (sumOfClothes > rackCapacity)
                {
                    rackCount++;
                    sumOfClothes = 0;
                }
            }
            Console.WriteLine(rackCount);

        }
    }
}
