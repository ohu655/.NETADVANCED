using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Tournament")
                {
                    break;
                }

                string[] inputArray = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = inputArray[0];
                string pokemonName = inputArray[1];
                string pokemonElement = inputArray[2];
                int pokemonHealth = int.Parse(inputArray[3]);

                if (trainers.Any(x => x.Name == trainerName) == false)
                {
                    trainers.Add(new Trainer(trainerName));
                }

                Trainer currentTrainer = trainers.Find(t => t.Name == trainerName);
                currentTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    bool isTrainerHasElement = false;

                    foreach (var pokemon in trainer.Pokemons)
                    {
                        if (pokemon.Element == line)
                        {
                            trainer.NumberOfBadges++;
                            isTrainerHasElement = true;
                            break;
                        }
                    }

                    if (!isTrainerHasElement)
                    {
                        trainer.Pokemons.ForEach(pokemon => pokemon.Health -= 10);
                        trainer.Pokemons.RemoveAll(pokemon => pokemon.Health <= 0);
                    }
                }
            }

            //"{trainerName} {badges} {numberOfPokemon}"

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }

        }
    }
}
