using System;
using InternetShop.Car;
using InternetShop.Person;

namespace InternetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var consultant1 = new Consultant("Michael", "Roech", "senior");
            var customer1 = new Customer("Jorgen", "Klopp", 123 - 456 - 789);

            var auto1 = new Auto("s-class", 2.4, 185, "grey", 25000);
            var oldCar1 = new OldCar("e-class", 2.2, 150, "green", 5000, 330000, 23);

            Console.ReadLine();
        }
    }
}
