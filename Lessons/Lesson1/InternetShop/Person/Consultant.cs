using System;

namespace InternetShop.Person
{
    public class Consultant : InternetShop.Person.Person
    {
        public Consultant(string name, string surname, string qualification)
            : base(name, surname)
        {
            this.Qualification = qualification;
        }

        public string Qualification { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{FirstName} + {LastName} + {Qualification}");
        }
    }
}
