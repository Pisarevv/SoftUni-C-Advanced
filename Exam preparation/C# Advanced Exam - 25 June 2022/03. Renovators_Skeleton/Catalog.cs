using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public Catalog(string name, int neededRenovators, string project)
        {
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
            this.Renovators = new List<Renovator>();
        }

        public List<Renovator> Renovators { get => renovators; set => renovators = value; }
        public string Name { get => name; set => name = value; }
        public int NeededRenovators { get => neededRenovators; set => neededRenovators = value; }
        public string Project { get => project; set => project = value; }

        public int Count => renovators.Count;
        public string AddRenovator(Renovator renovator)
        {
            if (renovators.Count < neededRenovators)
            {
                if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
                {
                    return "Invalid renovator's information.";
                }
                if (renovator.Rate > 350)
                {
                    return "Invalid renovator's rate.";
                }
                else
                {
                    Renovators.Add(renovator);
                    return $"Successfully added {renovator.Name} to the catalog.";
                }
            }
            else
            {

                return "Renovators are no more needed.";
            }
        }
        public bool RemoveRenovator(string name)
        {
            int count = Renovators.RemoveAll(x => x.Name == name);
            return count > 0;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = Renovators.RemoveAll(x => x.Type == type);
            return count;
        }
        public Renovator HireRenovator(string name)
        {
            Renovator currentRenovator = Renovators.Find(x => x.Name == name);
            if (currentRenovator == null)
            {
                return null;
            }
            else
            {
                currentRenovator.Hired = true;
                return currentRenovator;
            }
        }
        public List<Renovator> PayRenovators(int days)
        {
            if (renovators.Count == 0)
            {
                return null;
            }
            List<Renovator> renovatorsToPay = renovators.FindAll(x => x.Days >= days);
            return renovatorsToPay;
        }
        public string Report()
        {
            List<Renovator> notHiredRenovators = Renovators.FindAll(x => x.Hired == false);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Renovators available for Project {this.Project}:");
            foreach (var renovator in notHiredRenovators)
            {
                sb.AppendLine(renovator.ToString().Trim());
            }
            return sb.ToString().Trim();
        }
    }
}
