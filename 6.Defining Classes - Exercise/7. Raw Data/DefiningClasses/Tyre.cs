using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Tyre
    {
        //field
        private double pressure;
        private int age;
        //property
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //ctor
        public Tyre(double pressure, int age)
        {
            Pressure = pressure;
            Age = age;
        }
    }
}
