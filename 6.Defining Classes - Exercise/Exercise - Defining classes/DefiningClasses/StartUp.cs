using System;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Peter";
            person.Age = 20;
            Person person1 = new Person("George",18);
            Person person2 = new Person("Jose", 43);
        }
    }
}
