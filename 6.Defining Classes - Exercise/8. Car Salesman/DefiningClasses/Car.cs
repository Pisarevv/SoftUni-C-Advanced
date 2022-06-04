using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Car
    {
        //field
        private string model;
        private Engine engine;
        private int weight;
        private string color;
        //property
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //ctor  
        public Car()
        {

        }
        public Car(string model,Engine engine)
        {
            Model = model;
            Engine = engine;
        }

      
       
    }
}
