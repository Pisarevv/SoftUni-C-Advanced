using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string input = string.Empty;

            while((input = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string trainer = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string element = cmdArgs[2];
                int pokemonHealth = int.Parse(cmdArgs[3]);
                Pokemon newPokemon = new Pokemon(pokemonName, element, pokemonHealth);
                if (!trainers.Any(x => x.Name == trainer))
                {
                    Trainer newTrainer = new Trainer(trainer);
                    newTrainer.Pokemons.Add(newPokemon);
                    trainers.Add(newTrainer);
                }
                else
                {
                    Trainer currTrainer = trainers.First(x => x.Name.Equals(trainer));
                    currTrainer.Pokemons.Add(newPokemon);
                }
            }

            while((input= Console.ReadLine()) != "End")
            {
                foreach(Trainer trainer in trainers)
                {
                    bool hasPokemon = false;
                    if (trainer.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.Badges++;
                        hasPokemon = true;
                    }

                    if (!hasPokemon)
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;

                        }
                    }
                    /*if (input == "Fire")
                    {
                        bool hasPokemon = false;
                        if (trainer.Pokemons.Any(x => x.Element == input))
                        {
                            trainer.Badges++;
                            hasPokemon = true;
                        }

                       if (!hasPokemon)
                        {
                            foreach (Pokemon pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;

                            }
                        }
                    }

                    if (input == "Water")
                    {
                        bool hasPokemon = false;
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element == "Water")
                            {
                                trainer.Badges++;
                                hasPokemon = true;
                            }
                        }
                        if (!hasPokemon)
                        {
                            foreach (Pokemon pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;

                            }
                        }
                    }

                    if (input == "Electricity")
                    {
                        bool hasPokemon = false;
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            if (pokemon.Element == "Electricity")
                            {
                                trainer.Badges++;
                                hasPokemon = true;
                            }
                        }
                        if (!hasPokemon)
                        {
                            foreach (Pokemon pokemon in trainer.Pokemons)
                            {
                                pokemon.Health -= 10;
                                
                            }
                            
                            
                        }
                    }*/
                    trainer.Pokemons.RemoveAll(pokemon => pokemon.Health <= 0);
                }
            }

            foreach(Trainer trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
