using System;

namespace InternetShop.Person
{
    public abstract class Person
    {
        public Person(string name, string surname)
        {
            this.FirstName = name;
            this.LastName = surname;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
