using System;
using System.Collections.Generic;
using System.Text;

namespace _4.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            NumberOfBadges = 0;
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
