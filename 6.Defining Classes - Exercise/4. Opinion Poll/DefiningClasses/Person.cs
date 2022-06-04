using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        //fields
        private string name;
        private int age;

        //ctor 
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //property
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

       

    }
}
