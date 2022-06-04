using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        //fields
        private List<Person> familyMembers;

        //property
        public List<Person> FamilyMembers
        {
            get { return familyMembers; }
            set { familyMembers = value; }
        }

        //ctor
        public Family()
        {
           FamilyMembers = new List<Person>();
        }

        public void Addperson(Person person)
        {
            
            FamilyMembers.Add(person);

        }

        public void PrintOlderThan30()
        {
            List<Person> over30People = new List<Person>();
            foreach(Person person in familyMembers)
            {
                if (person.Age > 30)
                {
                    over30People.Add(person);
                }
            }
            
            foreach (Person person in over30People.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
