using System.Collections.Generic;
using System.Linq;
using System;
namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;
        private string name;
        private int capacity;

        public Zoo(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
            this.animals = new List<Animal>();
        }

        public List<Animal> Animals { get => animals; set => animals = value; }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            if (this.Animals.Count == Capacity)
            {
                return "The zoo is full.";
            }
            else
            {
                this.Animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
        }
        public int RemoveAnimals(string species)
        {
            int count = this.Animals.RemoveAll(a => a.Species == species);
            return count;
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> filteredAnimals = Animals.FindAll(x => x.Diet == diet);
            return filteredAnimals;
        }
        public Animal GetAnimalByWeight(double weight)
        {
            return Animals.Find(x => x.Weight == weight);
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (var animal in this.Animals)
            {
                if(animal.Length >= minimumLength && animal.Length <= maximumLength)
                {
                    count++;
                }
            }
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
