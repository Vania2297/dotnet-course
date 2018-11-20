using System;

namespace Square
{
    public class Program
    {
        static void Main(string[] args)
        {
            var matrix = new Shape[3, 11];
            for (var i = 0; i < 10; i++)
            {
                matrix[0, i] = new Circle(i);
                matrix[1, i] = new Square(i);
                matrix[2, i] = new Triangle(i);
            }

            for (var i = 0; i < matrix.Rank+1; i++)
            {
                for (var j = 0; j < 10; j++)
                {
                    Console.WriteLine($" {matrix[i, j].GetSquare(),3}");
                }

                Console.ReadLine();
            }
        }
    }

    public class Shape
    {
        public virtual double GetSquare()
        {
            return 0;
        }
    }

    public class Circle : Shape
    {
        private readonly int _radius;

        public Circle(int radius)
        {
            this._radius = radius;
        }

        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(_radius,2));
        }
    }

    public class Square : Shape
    {
        private readonly int _length;

        public Square(int lenght)
        {
            this._length = lenght;
        }

        public override double GetSquare()
        {
            return (_length * _length);
        }
    }

    public class Triangle : Shape
    {
        private readonly double _side;

        public Triangle(double side)
        {
            this._side = side;
        }

        public override double GetSquare()
        { 
            return Math.Pow(_side, 2) * Math.Sqrt(3) / 4;
        }
    }
}