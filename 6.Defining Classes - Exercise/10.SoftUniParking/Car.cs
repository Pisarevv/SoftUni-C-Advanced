using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    internal class Car
    {
        //fields
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;
        //fields
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }
        //ctor 
        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {make}" + Environment.NewLine);
            sb.Append($"Model: {model}" + Environment.NewLine);
            sb.Append($"HorsePower: {horsePower}" + Environment.NewLine);
            sb.Append($"RegistrationNumber: {registrationNumber}");

            return sb.ToString();
        }
    }
}
