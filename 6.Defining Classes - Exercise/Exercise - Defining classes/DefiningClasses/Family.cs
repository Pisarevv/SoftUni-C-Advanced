using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        //field
        private List<Person> familyMembers;

        //ctor
        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        //prop
        public List<Person> FamilyMembers
        {
            get { return this.familyMembers; }
            set { this.familyMembers = value; }
        }
        //method
        
        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = this.FamilyMembers.Max(member => member.Age);
            return this.FamilyMembers.First(member => member.Age == maxAge);
        }
    }
}
