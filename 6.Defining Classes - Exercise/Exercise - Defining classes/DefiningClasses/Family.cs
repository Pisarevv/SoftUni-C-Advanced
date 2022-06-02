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

        //method
        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = this.familyMembers.Max(member => member.Age);
            return this.familyMembers.First(member => member.Age == maxAge);
        }
    }
}
