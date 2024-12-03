using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance.Utils
{
    abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;
        }

        public override double CalculateArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public override double CalculatePerimeter() => a + b + c;
    }

    class Square : Shape
    {
        private double side;

        public Square(double sideLength)
        {
            side = sideLength;
        }

        public override double CalculateArea() => side * side;

        public override double CalculatePerimeter() => 4 * side;
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea() => Math.PI * radius * radius;

        public override double CalculatePerimeter() => 2 * Math.PI * radius;
    }
}
