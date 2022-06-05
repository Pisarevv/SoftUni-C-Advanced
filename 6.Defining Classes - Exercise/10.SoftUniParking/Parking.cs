using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    internal class Parking
    {
        //fields
        private List<Car> cars;
        private int capacity;
        //properties
        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public Parking(int capacity)
        {
            Cars = new List<Car>();
            Capacity = capacity;
        }
        public int Count { get { return cars.Count; } }
        //methods

        public string AddCar(Car car)
        {
            if (cars.Contains(car))
            {
               return ("Car with that registration number, already exists!");
            }
            else if (cars.Count >= capacity)
            {
                return ("Parking is full!");
            }
            else
            {
                cars.Add(car);
                return ($"Successfully added new car {car.Make} {car.RegistrationNumber}");
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if(cars.Exists(x => x.RegistrationNumber == registrationNumber))
            {
                cars.RemoveAll((x => x.RegistrationNumber == registrationNumber));
                return($"Successfully removed {registrationNumber}");
            }
            else
            {
                return ("Car with that registration number, doesn't exist!");
            }
        }
        
        public Car GetCar(string registrationNumber)
        {
            return cars.Find(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string registrationNumber in registrationNumbers)
            {
                cars.RemoveAll(x => x.RegistrationNumber == registrationNumber);
            }
            
        }

       

        

    }
}
