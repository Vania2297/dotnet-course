using System;

namespace InternetShop.Person
{
    public class Customer : InternetShop.Person.Person
    {
        public Customer(string name, string surname, int phone)
            : base(name, surname)
        {
            this.Phone = phone;
        }

        public int Phone { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{FirstName}+{LastName}+{Phone}");
        }
    }
}
