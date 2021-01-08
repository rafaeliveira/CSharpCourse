using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethods.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}