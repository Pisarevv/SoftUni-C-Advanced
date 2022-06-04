using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Engine newEngine = new Engine();
                string model = input[0];
                int power = int.Parse(input[1]);
                if (input.Length == 2)
                {
                   
                    newEngine = new Engine(model, power);

                }
                else if (input.Length == 3 && char.IsDigit(input[2].ToCharArray()[0]))
                {
                    int displacement = int.Parse(input[2]);
                    newEngine = new Engine(model, power);
                    newEngine.Displacement = displacement;
                }
                else if (input.Length == 3 && char.IsLetter(input[2].ToCharArray()[0]))
                {
                    string efficency = input[2];
                    newEngine = new Engine(model, power);
                    newEngine.Efficency = efficency;
                }
                else if (input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficency = input[3];
                    newEngine = new Engine(model, power);
                    newEngine.Displacement = displacement;
                    newEngine.Efficency = efficency;
                }
                engines.Add(newEngine);
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Car newCar = new Car();
                string model = input[0];
                string engine = input[1];
                if (input.Length == 2)
                {
                    
                    Engine foundEngine = engines.First(x => x.Model.Equals(engine));
                    newCar = new Car(model, foundEngine);
                    
                }
                else if (input.Length == 3 && char.IsDigit(input[2].ToCharArray()[0]))
                {
                   
                    Engine foundEngine = engines.First(x => x.Model.Equals(engine));
                    int weight = int.Parse(input[2]);
                    newCar = new Car(model, foundEngine);
                    newCar.Weight = weight;
                }
                else if (input.Length == 3 && char.IsLetter(input[2].ToCharArray()[0]))
                {

                    Engine foundEngine = engines.First(x => x.Model.Equals(engine));
                    string color = input[2];
                    newCar = new Car(model, foundEngine);
                    newCar.Color = color;
                }
                else if (input.Length == 4)
                {

                    Engine foundEngine = engines.First(x => x.Model.Equals(engine));
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    newCar = new Car(model, foundEngine);
                    newCar.Weight = weight;
                    newCar.Color = color;
                }
                cars.Add(newCar);
            }

            foreach (Car car in cars)
            {

                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement > 0)
                {
                    Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                }
                else if (car.Engine.Displacement <= 0)
                { 
                    Console.WriteLine($"    Displacement: n/a");
                }
                if (car.Engine.Efficency != null)
                {
                    Console.WriteLine($"    Efficiency: {car.Engine.Efficency}");
                }
                else if (car.Engine.Efficency == null)
                {
                    Console.WriteLine($"    Efficiency: n/a");
                }
                if (car.Weight > 0)
                {
                    Console.WriteLine($"  Weight: {car.Weight}");
                }
                else if (car.Weight <= 0)
                {
                    Console.WriteLine($"  Weight: n/a");
                }
                if (car.Color != null)
                {
                    Console.WriteLine($"  Color: {car.Color}");
                }
                else if(car.Color == null)
                {
                    Console.WriteLine($"  Color: n/a");
                }


            }
        }

        
    }
}
