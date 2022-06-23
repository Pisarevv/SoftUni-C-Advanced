using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace StreetRacing
{
    public class Race
    {
        private List<Car> cars;
        private string name;
        private string type;
        private int laps;
        private int capacity;
        private int maxHorsePower;

        public Race(string name,string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.Cars = new List<Car>();
        }

        public List<Car> Cars { get => cars; set => cars = value; }
        public string Name { get => name; set => name = value; }
        public int Laps { get => laps; set => laps = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int MaxHorsePower { get => maxHorsePower; set => maxHorsePower = value; }
        public string Type { get => type; set => type = value; }

        public int Count => this.cars.Count;
        public void Add(Car car)
        {
            bool foundCar = cars.Any(x => x.LicensePlate == car.LicensePlate);
            if (cars.Count < this.Capacity && !foundCar && car.HorsePower <= MaxHorsePower)
            {
                cars.Add(car);
            }
        }
        public bool Remove(string licensePlate)
        {
            int count = cars.RemoveAll(x => x.LicensePlate == licensePlate);
            return count > 0;
        }
        public Car FindParticipant(string licensePlate)
        {
            return cars.FirstOrDefault(x => x.LicensePlate == licensePlate);
        }
        public Car GetMostPowerfulCar()
        {
            if (cars.Count == 0)
            {
                return null;
            }
            return cars.OrderByDescending(x => x.HorsePower).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})");
            foreach(var car in this.Cars)
            {
                sb.AppendLine(car.ToString().Trim());
            }
            return sb.ToString();
        }
    }
}
