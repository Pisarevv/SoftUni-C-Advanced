using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ComparingObjects
{
    internal class Person : IComparable<Person>
    {
        //field
        private string name;
        private int age;
        private string town;
        //ctor
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }



        //prop
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Town
        {
            get { return town; }
            set { town = value; }
        }
        public int CompareTo(Person other)
        {
            int result = 0;
            if (this.Name == other.Name && this.Age == other.Age && this.Town == other.Town)
            {
                result = 0;
            }
            else
            {
                result = -1;
            }
            return result;
        }
    }
}
