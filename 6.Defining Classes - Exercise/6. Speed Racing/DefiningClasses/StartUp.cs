using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(); 

            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = information[0];
                double fuelAmout = double.Parse(information[1]);
                double fuelConsumption = double.Parse(information[2]);

                Car car = new Car(model, fuelAmout, fuelConsumption);
                cars.Add(car);
            }

            string command = string.Empty;

            while((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string carModel = cmdArgs[1];
                double amountOfKm = double.Parse(cmdArgs[2]);

                Car carToDrive = cars.First(car => car.Model == carModel);
                carToDrive.DriveCar(amountOfKm);

            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
