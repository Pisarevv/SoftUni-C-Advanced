using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.__Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mealsAndCalories = new Dictionary<string, int>()
            {["salad"] = 350,
             ["soup"] = 490,
             ["pasta"] = 680,
             ["steak"] = 790
            };

            Queue<string> meals = new Queue<string>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));
            Stack<int> dailyCalories = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int caloriesToTransfer = 0;
            int eatenMeals = 0;
            while (true)
            {
                if(meals.Count == 0)
                {
                    Console.WriteLine($"John had {eatenMeals} meals.");
                    Console.WriteLine($"For the next few days, he can eat {string.Join(", ", dailyCalories)} calories.");
                    return;
                }
                if(dailyCalories.Count == 0)
                {
                    Console.WriteLine($"John ate enough, he had {eatenMeals} meals.");
                    Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
                    return;
                }
                string currentMeal = meals.Peek();
                int currentMealCalories = 0;
                foreach(var kvp in mealsAndCalories)
                {
                    if (kvp.Key == currentMeal)
                    {
                        currentMealCalories = kvp.Value;
                        break;
                    }
                }
                int currentDaliyCalories = dailyCalories.Pop();

                if (currentDaliyCalories - currentMealCalories > 0)
                {
                    currentDaliyCalories -= currentMealCalories;
                    dailyCalories.Push(currentDaliyCalories);
                    meals.Dequeue();
                    eatenMeals++;
                }
                else if (currentDaliyCalories - currentMealCalories < 0)
                {
                    caloriesToTransfer = currentDaliyCalories - currentMealCalories;
                    if(dailyCalories.Count > 0)
                    {
                        int transfer = dailyCalories.Pop() + caloriesToTransfer;
                        dailyCalories.Push(transfer);
                        meals.Dequeue();
                        eatenMeals++;
                    }
                    else
                    {
                        meals.Dequeue();
                        eatenMeals++;
                    }
                    
                }
            }
        }
    }
}
