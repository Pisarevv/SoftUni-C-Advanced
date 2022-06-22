using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish;
        private string material;
        private int capacity;


        public Net(string material, int capacity)
        {
            this.Fish = new List<Fish>();
            this.Material = material;
            this.Capacity = capacity;
        }

        public List<Fish> Fish { get => fish; set => fish = value; }
        public string Material { get => material; set => material = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public int Count => fish.Count;

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Weight <= 0 || fish.Length <= 0)
            {
                return "Invalid fish.";
            }
            if (this.Fish.Count  == this.Capacity)
            {
                return "Fishing net is full.";
            }
            else
            {
                this.Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }
        public bool ReleaseFish(double weight)
        {
            int count = this.Fish.RemoveAll(x => x.Weight == weight);
            return count > 0;
        }
        public Fish GetFish(string fishType)
        {
            return this.Fish.FirstOrDefault(x => x.FishType == fishType);
        }
        public Fish GetBiggestFish()
        {
            return this.Fish.OrderByDescending(x => x.Length).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");
            foreach (var fish in this.Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(fish.ToString().Trim());
            }
            return sb.ToString().Trim();
        }
    }
}
