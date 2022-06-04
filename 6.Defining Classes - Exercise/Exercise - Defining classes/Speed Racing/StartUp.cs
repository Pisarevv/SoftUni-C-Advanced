using System;
using System.Collections.Generic;
using System.Linq;

namespace Speed_Racing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                double fuelAmout = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car newCar = new Car(model,fuelAmout,fuelConsumptionFor1km);
                cars.Add(newCar);
            }

            string command = string.Empty;
            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string modelToDrive = cmdArgs[1];
                double kilometersToDrive = double.Parse(cmdArgs[2]);

                Car carToDrive = cars.First(x => x.Model == modelToDrive);
                carToDrive.DriveCar(kilometersToDrive);
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
