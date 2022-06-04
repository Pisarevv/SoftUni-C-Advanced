using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Engine
    {
        //field
        private string model;
        private int power;
        private int displacement;
        private string efficency;
        //prop
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }
        public string Efficency
        {
            get { return efficency; }
            set { efficency = value; }
        }
        //ctor  
        public Engine()
        {

        }
        public Engine(string model,int power)
        {
            Model = model;
            Power = power;
        }
    }
}
