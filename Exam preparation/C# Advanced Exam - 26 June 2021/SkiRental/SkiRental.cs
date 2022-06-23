using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> skis = new List<Ski>();
        private string name;
        private int capacity;

        public SkiRental(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Skis = new List<Ski>();
        }

        public List<Ski> Skis { get => skis; set => skis = value; }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public int Count => skis.Count;
        public void Add(Ski ski)
        {
            if(Skis.Count == capacity)
            {
                return;
            }
            else
            {
                skis.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            List<Ski> toRemove = new List<Ski>();
            foreach (Ski ski in Skis)
            {
                if (ski.Manufacturer == manufacturer && ski.Model == model)
                {
                    toRemove.Add(ski);
                }
            }
            foreach (Ski ski in toRemove)
            {
                skis.Remove(ski);
            }
            return toRemove.Count > 0;
        }
        public Ski GetNewestSki()
        {
            if(skis.Count == 0)
            {
                return null;
            }
            return skis.OrderByDescending(x => x.Year).FirstOrDefault();
        }
        public Ski GetSki(string manufacturer, string model)
        {
            List<Ski> foundSki = new List<Ski>();
            foreach (Ski ski in Skis)
            {
                if (ski.Manufacturer == manufacturer && ski.Model == model)
                {
                    foundSki.Add(ski);
                }
            }
            if (foundSki.Count == 0)
            {
                return null;
            }
            Ski currentSki = foundSki[0];
            return currentSki;
           
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {this.Name}:");
            foreach (Ski ski in Skis)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
