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


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{model}:" + Environment.NewLine);
            sb.Append($"  {Engine.Model}:" + Environment.NewLine);
            sb.Append($"    Power: {Engine.Power}" + Environment.NewLine);
            if (Engine.Displacement > 0)
            {
                sb.Append($"    Displacement: {Engine.Displacement}" + Environment.NewLine);
            }
            else if (Engine.Displacement <= 0)
            {
                sb.Append($"    Displacement: n/a" + Environment.NewLine);
            }
            if (Engine.Efficency != null)
            {
                sb.Append($"    Efficiency: {Engine.Efficency}" + Environment.NewLine);
            }
            else if (Engine.Efficency == null)
            {
                sb.Append($"    Efficiency: n/a" + Environment.NewLine);
            }
            if (Weight > 0)
            {
                sb.Append($"  Weight: {Weight}" + Environment.NewLine);
            }
            else if (Weight <= 0)
            {
                sb.Append($"  Weight: n/a" + Environment.NewLine);
            }
            if (Color != null)
            {
                sb.Append($"  Color: {Color}");
            }
            else if (Color == null)
            {
                sb.Append($"  Color: n/a");
            }

            return sb.ToString();
        }


    }
}
