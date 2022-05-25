using System;
using System.Collections.Generic;

namespace P08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputGuest = string.Empty;
            var vipGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();
            while ((inputGuest = Console.ReadLine())!= "PARTY")
            {
                char firstChar = inputGuest[0];
                if (Char.IsDigit(firstChar))
                {
                    vipGuests.Add(inputGuest);
                }
                else
                {
                    regularGuests.Add(inputGuest);
                }
            }

            string guestVisited = string.Empty;
            while ((guestVisited = Console.ReadLine())!= "END")
            {
                vipGuests.Remove(guestVisited);
                regularGuests.Remove((guestVisited));
            }
            Console.WriteLine(vipGuests.Count+regularGuests.Count);
            foreach(var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }
            foreach(var regular in regularGuests)
            {
                Console.WriteLine(regular);
            }
            
        }
    }
}
