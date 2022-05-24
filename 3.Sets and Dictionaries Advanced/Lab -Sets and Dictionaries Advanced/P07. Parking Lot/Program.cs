using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> licensePlates = new HashSet<string>();
            string input = string.Empty;

            while((input = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = cmdArgs[0];
                string plate = cmdArgs[1];
                if (command == "IN")
                {
                    licensePlates.Add(plate);
                }
                else if (command == "OUT")
                {
                    licensePlates.Remove(plate);
                }
            }
            foreach(var license in licensePlates)
            {
                Console.WriteLine(license);
            }
        }
    }
}
