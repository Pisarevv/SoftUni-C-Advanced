using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> carsList = new List<Car>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {       
                List<Tyre> tyreList = new List<Tyre>();
                string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                for (int j = 5 ; j < input.Length; j++)
                {
                    double pressure = double.Parse(input[j]);
                    int age = int.Parse(input[j+1]);
                    j++;
                    Tyre newTyre = new Tyre(pressure, age);
                    tyreList.Add(newTyre);
                }
                Engine newEngine = new Engine(speed, power);
                Cargo newCargo = new Cargo(cargoType, cargoWeight);

                Car newCar = new Car(model, newEngine, newCargo,tyreList);
                carsList.Add(newCar);
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<Car> matchedCars = new List<Car>();
                matchedCars = carsList.FindAll(x => x.Cargo.Type == command);
                foreach (Car car in matchedCars)
                {
                   
                    foreach (Tyre tyre in car.Tyres)
                    {
                        if (tyre.Pressure < 1)
                        {
                            Console.WriteLine(car.Model);
                            break;
                        }
                    }

                }
                
            }
            else if (command == "flammable")
            {
                List<Car> matchedCars = new List<Car>();
                matchedCars = carsList.FindAll(x => x.Cargo.Type == command);
                foreach (Car car in matchedCars)
                {                   
                    if (car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                
            }
        }
    }
}
