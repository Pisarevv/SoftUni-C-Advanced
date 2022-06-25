using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        private string name;
        private string type;
        private double rate;
        private int days;
        private bool hired;

        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
            this.Hired = false;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Rate { get => rate; set => rate = value; }
        public int Days { get => days; set => days = value; }
        public bool Hired { get => hired; set => hired = value; }

        public override string ToString()
        {
            return $"-Renovator: {this.name}" + Environment.NewLine +
                   $"--Specialty: {this.type}" + Environment.NewLine +
                   $"--Rate per day: {this.rate} BGN";

        }
    }
}
