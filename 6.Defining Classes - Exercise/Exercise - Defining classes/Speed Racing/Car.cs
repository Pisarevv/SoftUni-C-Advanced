using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    public class Car
    {
        //fields
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        //properties
        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get { return travelledDistance; } set { travelledDistance = value; } }

        //ctor  
        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
            TravelledDistance = 0;
        }

        public void DriveCar (double kilometersToDrive)
        {
            if(fuelAmount >= kilometersToDrive * fuelConsumptionPerKilometer)
            {
                FuelAmount -= kilometersToDrive * fuelConsumptionPerKilometer;
                TravelledDistance += kilometersToDrive;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
