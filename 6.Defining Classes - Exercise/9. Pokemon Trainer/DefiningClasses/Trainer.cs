using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Trainer
    {
        //fields
        private string name;
        private int badges;
        private List<Pokemon> pokemons = new List<Pokemon>();

        //prop
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }
        //ctor  
        public Trainer()
        {
            Pokemons = new List<Pokemon>();
        }
        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }
     
    }
}
