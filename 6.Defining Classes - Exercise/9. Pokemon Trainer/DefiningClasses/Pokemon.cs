using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Pokemon
    {
        //fields 
        private string name;
        private string element;
        private int health;
        //prop
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Element
        {
            get { return element; }
            set { element = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        //ctor  
        public Pokemon(string name, string element,int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}
