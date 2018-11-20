using System;

namespace Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Car { FuelCar = 23 };
            var c2 = new Car { FuelCar = 45 };
            var result = c1 > c2;
            Console.WriteLine(result); // false

            Console.ReadKey();
        }
    }

    public class Car
    {
        public int Engine { get; set; }
        public int FuelCar { get; set; }

        public static Car operator +(Car car1, Car car2)
        {
            return new Car { FuelCar = car1.FuelCar + car2.FuelCar };
        }
        public static bool operator >(Car c1, Car c2)
        {
            return c1.FuelCar > c2.FuelCar;
        }
        public static bool operator <(Car c1, Car c2)
        {
            return c1.FuelCar < c2.FuelCar;
        }

        public static bool operator true(Car c1)
        {
            return c1.FuelCar != 0;
        }
        public static bool operator false(Car c1)
        {
            return c1.FuelCar == 0;
        }
    }
}
