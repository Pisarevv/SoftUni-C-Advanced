using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    internal class Person
    {
        //fields - полета - характеристики !private!
        private string name;
        private int age;

        //constructor
        public Person() // По подразбиране
        {

        }

        public Person(string name, int age) // с параметри
        {
            Name = name;
            Age = age;
        }

        //methods
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
    }
}
