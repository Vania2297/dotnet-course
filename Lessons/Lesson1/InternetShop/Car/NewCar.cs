namespace InternetShop.Car
{
    public class NewCar : Auto
    {
        public NewCar(string classCar, double engine, int horsepower, string color, decimal price) : base(classCar, engine, horsepower, color, price)
        {
        }

        public override void CalculateInsurance()
        {
            Insurance = Price * 0.1M;
        }
    }
}
