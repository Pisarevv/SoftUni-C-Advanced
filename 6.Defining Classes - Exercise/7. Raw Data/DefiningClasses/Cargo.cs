using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Cargo
    {
        //field
        private string type;
        private int weight;
        //property
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //ctor
        public Cargo(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }
    }
}
