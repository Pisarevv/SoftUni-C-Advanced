using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Engine
    {
        //field
        private int speed;
        private int power;

        //property
        public int Speed { get; set; }
        public int Power { get; set; }
        //ctor
        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
