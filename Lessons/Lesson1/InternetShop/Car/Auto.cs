using System;

namespace InternetShop.Car
{
    public class Auto
    {
        public Auto(string classCar, double engine, int horsepower, string color, decimal price)
        {
            ClassCar = classCar;
            Engine = engine;
            Horsepower = horsepower;
            Color = color;
            Price = price;
        }

        public string NameCar { get; set; }

        public string ClassCar { get; set; }

        public double Engine { get; set; }

        public int Horsepower { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }

        public decimal Insurance { get; set; }

        public virtual void CalculateInsurance()
        {
            Insurance = Price * 0.1M;
        }

        public void Display()
        {
            NameCar = "Mercedes-Benz";
            Console.WriteLine(NameCar);
        }
    }
}
