namespace Zoo
{
    public class Animal
    {
        private string species;
        private string diet;
        private double weight;
        private double length;

        public Animal(string species, string diet, double weight, double length)
        {
            this.Species = species;
            this.Diet = diet;
            this.Weight = weight;
            this.Length = length;
        }

        public string Species { get => species; set => species = value; }
        public string Diet { get => diet; set => diet = value; }
        public double Weight { get => weight; set => weight = value; }
        public double Length { get => length; set => length = value; }

        public override string ToString()
        {
            return $"The {this.Species} is a {this.Diet} and weighs {this.Weight} kg.";
        }
    }
}
