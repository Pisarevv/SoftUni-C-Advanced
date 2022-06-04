using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Car
    {
        //fields
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;


        public Car(string model, double fuelAmout, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmout;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;

        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }

        }

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }

        }

        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }


        public void DriveCar(double amountOfKm)
        {
            if (fuelAmount >= amountOfKm * fuelConsumptionPerKilometer)
            {
                FuelAmount -= amountOfKm * fuelConsumptionPerKilometer;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
