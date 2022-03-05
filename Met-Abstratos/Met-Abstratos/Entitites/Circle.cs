using Met_Abstratos.Entitites.Enums;
using System;

namespace Met_Abstratos.Entitites
{
    internal class Circle :Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
