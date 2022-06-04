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
        private Cargo cargo;
        private List<Tyre> tyres;
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
        public Cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public List<Tyre> Tyres
        {
            get { return tyres; }
            set { tyres = value; }
        }
        public Car()
        {
            Tyres = new List<Tyre>();
        }
        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tyres)
        {
            
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tyres = tyres;

        }
    }
}
