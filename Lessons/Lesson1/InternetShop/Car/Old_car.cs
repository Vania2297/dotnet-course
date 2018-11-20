namespace InternetShop.Car
{
    public class OldCar : Auto
    {
        public int CarMileage { get; set; }
        public int AgeCar { get; set; }

        public OldCar(string classCar, double engine, int horsepower, string color, decimal price, int carMileage, int ageCar)
            : base(classCar, engine, horsepower, color, price)
        {
            this.CarMileage = carMileage;
            this.AgeCar = ageCar;
        }

        public override void CalculateInsurance()
        {
            Insurance = Price * 0.05M;
        }
    }
}
