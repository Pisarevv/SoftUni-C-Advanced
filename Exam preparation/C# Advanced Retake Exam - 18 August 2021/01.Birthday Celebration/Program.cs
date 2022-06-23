using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> plates = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wasteFood = 0;
            while (true)
            {
                if (guests.Count == 0 || plates.Count == 0)
                {
                    break;
                }
                int currentGuestCapacity = guests.Peek();
                int currentPlateCapacity = plates.Pop();

                if (currentGuestCapacity <= currentPlateCapacity)
                {
                    wasteFood += currentPlateCapacity - currentGuestCapacity;
                    guests.Dequeue();   
                }
                else if(currentGuestCapacity > currentPlateCapacity)
                {
                    while (currentGuestCapacity > 0)
                    {
                        currentGuestCapacity -= currentPlateCapacity;
                        if (currentGuestCapacity < 0)
                        {
                            wasteFood -= currentGuestCapacity;
                        }
                        if(plates.Count > 0 && currentGuestCapacity > 0)
                        {
                            currentPlateCapacity = plates.Pop();
                        }
                        
                    }
                    guests.Dequeue();
                    
                }
            }
            if (guests.Count == 0)
            {
                Console.WriteLine($"Plates: {string.Join(" ", plates)}");
            }
            if (plates.Count == 0)
            {
                Console.WriteLine($"Guests: {string.Join(" ", guests)}");
            }
            Console.WriteLine($"Wasted grams of food: {wasteFood}");
        }
    }
}
