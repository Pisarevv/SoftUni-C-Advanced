using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public int Count => Drones.Count(d => d.Available == true);
        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }
            if (Drones.Count >= Capacity)
            {
                return "Airfield is full.";
            }
            else
            {
                Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";
            }
        }

        public bool RemoveDrone(string name)
        {
            int count = Drones.RemoveAll(d => d.Name == name);
            return count > 0;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = Drones.RemoveAll(d => d.Brand == brand);
            return count;
        }
        public Drone FlyDrone(string name)
        {
            Drone currentDrone = Drones.FirstOrDefault(x => x.Name == name);
            if (currentDrone != null)
            {
                currentDrone.Available = false;
                return currentDrone;
            }
            
            return currentDrone;
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> dronesToFly = new List<Drone>(Drones.Where(x => x.Range >= range).ToList());
            foreach (Drone drone in dronesToFly)
            {
                drone.Available = false;
            }
            return dronesToFly;
        }
        public string Report()
        {
            var availableDrones = Drones.Where(x => x.Available == true);

            return
                 $"Drones available at {this.Name}:" + Environment.NewLine +
                string.Join(Environment.NewLine, availableDrones);

        }
    }
}
