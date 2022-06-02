using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        //fields - полета - характеристики !private!
        private string name;
        private int age;

        //constructor
        public Person() // По подразбиране
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age) // с параметри
        {
            Name = "No name";
            Age = age;
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
