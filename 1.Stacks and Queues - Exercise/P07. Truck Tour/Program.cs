using System;
using System.Collections.Generic;
using System.Linq;

namespace P07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumpCount = int.Parse(Console.ReadLine());
            Queue<FuelPump> queue = new Queue<FuelPump>();
            int startIndex = 0;
            bool tripFinished = false;
            for (int i = 0; i < petrolPumpCount; i++)
            {
                int[] info = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int fuelInPump = info[0];
                int distanceToNextPump = info[1];
                FuelPump newFuelPump = new FuelPump(fuelInPump, distanceToNextPump,i);
                queue.Enqueue(newFuelPump);

            }

            while (true)
            {
                if (tripFinished)
                {
                    break;
                }
                FuelPump currPump = queue.Dequeue();
                int fuelInPump = currPump.Fuel;
                int distanceToNextPump = currPump.DistanceToNextPump;
                int indexOfPump = currPump.IndexOfPump;
                queue.Enqueue(currPump);

                if (fuelInPump >= distanceToNextPump)
                {
                    while (true)
                    {
                        fuelInPump-=distanceToNextPump;
                        currPump = queue.Dequeue();
                        fuelInPump += currPump.Fuel;
                        distanceToNextPump = currPump.DistanceToNextPump;
                        int indexOfPumpSecond = currPump.IndexOfPump;
                        queue.Enqueue(currPump);

                        if (indexOfPumpSecond == indexOfPump)
                        {
                            startIndex = indexOfPump;
                            tripFinished = true;
                            break;
                        }
                        else if (fuelInPump < distanceToNextPump)
                        {
                            break;
                        }

                    }
                }
            }
            Console.WriteLine(startIndex);
            

        }
    }

    public class FuelPump
    {
        public FuelPump(int Fuel, int Distance,int Index)
        {
            this.Fuel = Fuel;
            this.DistanceToNextPump = Distance;
            this.IndexOfPump = Index;
           }
        public int Fuel { get; set; }
        public int DistanceToNextPump { get; set; }

        public int IndexOfPump { get; set; }

        
    }
}
